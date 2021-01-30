using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usbpv_server_demo_cs
{
    public partial class Form1 : Form
    {
        public const byte CMD_START_FLAG = (byte)'X';
        // command
        public const byte CMD_LIST = (byte)'L';
        public const byte CMD_OPEN = (byte)'O';
        public const byte CMD_CLOSE = (byte)'C';
        // response
        public const byte CMD_R_PASS = (byte)'P';
        public const byte CMD_R_ERROR = (byte)'E';
        // data
        public const byte CMD_D_BUS = (byte)'B';
        public const byte CMD_D_US = (byte)'0';
        public const byte CMD_D_LS = (byte)'1';
        public const byte CMD_D_FS = (byte)'2';
        public const byte CMD_D_HS = (byte)'3';
        // speed
        public const byte SPEED_HS = (byte)0;
        public const byte SPEED_FS = (byte)1;
        public const byte SPEED_LS = (byte)2;
        public const byte SPEED_AUTO = (byte)3;
        // bus event
        public const byte PT_RESET_BEGIN = (byte)1;
        public const byte PT_RESET_END = (byte)2;
        public const byte PT_SUSPEND_BEGIN = (byte)3;
        public const byte PT_SUSPEND_END = (byte)4;
        public const byte PT_OVERFLOW = (byte)0xf;

        private SynchronizationContext m_uiContext;
        private TcpClient m_tcpClient = new TcpClient();
        private UdpClient m_udpClient = null;
        const int RECV_BUFF_LEN = 4096;
        private byte[] m_readBuffer = new byte[RECV_BUFF_LEN];
        private bool m_tcpMode = false;
        public Form1()
        {
            InitializeComponent();

            m_uiContext = SynchronizationContext.Current;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Log(string info)
        {
            textLog.AppendText(info);
            textLog.AppendText("\r\n");
        }
        void LogInOtherThread(string info)
        {
            m_uiContext.Post((obj) =>
            {
                Log(info);
            }, null);
        }
        private void TcpAsyncConnect(IAsyncResult res)
        {
            try
            {
                m_tcpClient.EndConnect(res);
                m_uiContext.Post((obj)=>
                {
                    Log("Connect success");
                    TcpConnectionChanged(true);
                }, null);
                m_tcpClient.GetStream().BeginRead(m_readBuffer, 0, RECV_BUFF_LEN,TcpAsyncReadDone,null);

                return;
            }
            catch(Exception e)
            {
                m_uiContext.Post((obj) =>
                {
                    Log("Connect fail. " + e.ToString());
                    TcpConnectionChanged(false);
                }, null);
                
            }
        }
        private void TcpAsyncReadDone(IAsyncResult res)
        {
            try
            {
                int len = m_tcpClient.GetStream().EndRead(res);
                IncomingData(m_readBuffer, len);
                m_tcpClient.GetStream().BeginRead(m_readBuffer, 0, RECV_BUFF_LEN, TcpAsyncReadDone, null);
            }
            catch (Exception e)
            {
                m_uiContext.Post((obj) =>
                {
                    Log("Read fail. Connection loss");
                    TcpConnectionChanged(false);
                }, null);
            }
        }
        private void TcpAsyncSendDone(IAsyncResult res)
        {
            try
            {
                m_tcpClient.GetStream().EndWrite(res);
            }
            catch (Exception e)
            {
                m_uiContext.Post((obj) =>
                {
                    Log("Write fail. " + e.ToString());
                }, null);
            }
        }
        private void TcpConnectionChanged(bool isConnected)
        {
            if (isConnected)
            {
                btnConnect.Text = "Stop TCP";
            }
            else
            {
                btnConnect.Text = "Start TCP";
                btnUDP.Enabled = true;
            }
            btnConnect.Enabled = true;
        }
        private void UdpAsyncReadDone(IAsyncResult res)
        {
            if (m_udpClient != null)
            {
                try
                {
                    IPEndPoint ep = new IPEndPoint(0, 0);
                    byte[] data = m_udpClient.EndReceive(res, ref ep);
                    IncomingData(data, data.Length);
                    m_udpClient.BeginReceive(UdpAsyncReadDone, null);
                }
                catch (Exception e)
                {
                }
            }
        }
        private void IncomingData(byte[] buf, int len)
        {
            for (int i = 0; i < len; i++) {
                ProcessByte(buf[i]);
            }
        }
        private void SendCommand(byte[] data, int len) 
        {
            Log("Send data: " + BitConverter.ToString(data, 0).Replace("-", string.Empty).ToLower());
            if (m_tcpMode)
            {
                if (m_tcpClient.Connected)
                {
                    m_tcpClient.GetStream().BeginWrite(data, 0, len, TcpAsyncSendDone, null);
                }
            }
            else
            {
                if (m_udpClient != null) {
                    m_udpClient.Send(data, len);
                }
            }
        }

        private int state = ST_INIT;
        public const int ST_INIT = 1;
        public const int ST_CMD = 2;
        public const int ST_LEN1 = 3;
        public const int ST_LEN2 = 4;
        public const int ST_DATA = 5;
        public int cmd_len;
        public int recv_cmd_len;
        public byte cmd;
        public byte[] cmd_buff = new byte[RECV_BUFF_LEN];
        private void ProcessByte(byte b)
        {
            switch (state) {
                case ST_INIT:
                    if (b == CMD_START_FLAG) {
                        state = ST_CMD;
                    }
                    break;
                case ST_CMD:
                    state = ST_LEN1;
                    cmd_len = 0;
                    recv_cmd_len = 0;
                    cmd = b;
                    break;
                case ST_LEN1:
                    state = ST_LEN2;
                    cmd_len = b;
                    break;
                case ST_LEN2:
                    cmd_len = cmd_len + (b << 8);
                    if (cmd_len == 0)
                    {
                        state = ST_INIT;
                        OnCommand(cmd, cmd_buff, 0);
                    }
                    else if (cmd_len <= RECV_BUFF_LEN - 4)
                    {
                        state = ST_DATA;
                    }
                    else {
                        LogInOtherThread("cmd length error");
                        state = ST_INIT;
                        OnCommand(cmd, cmd_buff, 0);
                    }
                    break;
                case ST_DATA:
                    cmd_buff[recv_cmd_len] = b;
                    recv_cmd_len++;
                    if (recv_cmd_len == cmd_len) {
                        state = ST_INIT;
                        OnCommand(cmd, cmd_buff, recv_cmd_len);
                    }
                    break;
                default:
                    if (b == CMD_START_FLAG)
                    {
                        state = ST_CMD;
                    }
                    break;
            }
        }

        UInt32 GetUint32(byte[] data, int pos) {
            return (UInt32)(data[0+pos] | (data[1+pos] << 8) | (data[2+pos] << 16) | (data[3+pos]<<24));
        }

        private void OnCommand(byte cmd, byte[] data, int len)
        {
            string speed = "unknown";
            bool hasData = false;
            switch (cmd) {
                case CMD_R_PASS:
                    string info = "";
                    if (len > 0) {
                        info = System.Text.Encoding.ASCII.GetString(data, 0, len);
                    }
                    LogInOtherThread("Response pass " + info);
                    break;
                case CMD_R_ERROR:
                    string err = "";
                    if (len > 0) {
                        err = "Error Code: " + data[0];
                    }
                    if (len > 1) {
                        err += " Sub Code: " + data[1];
                    }
                    LogInOtherThread("Response fail " + err);
                    break;
                case CMD_D_BUS:
                    if (len < 10)
                    {
                        LogInOtherThread("Wrong bus event length " + len);
                    }
                    else {
                        UInt32 ts = GetUint32(data, 0);
                        UInt32 nano = GetUint32(data, 4);
                        switch (data[8]) {
                            case PT_RESET_BEGIN: LogInOtherThread("Reset Begin: "+ ts + "." + nano); break;
                            case PT_RESET_END:   LogInOtherThread("Reset End: " + ts + "." + nano); break;
                            case PT_SUSPEND_BEGIN: LogInOtherThread("Suspend Begin: " + ts + "." + nano); break;
                            case PT_SUSPEND_END: LogInOtherThread("Suspend End: " + ts + "." + nano); break;
                            case PT_OVERFLOW: LogInOtherThread("Overflow " + data[9] + ": " + ts + "." + nano); break;
                            default: LogInOtherThread("Bus Event Unknown"); break;
                        }
                    }
                    break;
                case CMD_D_US: speed = "US"; hasData = true; break;
                case CMD_D_LS: speed = "LS"; hasData = true; break;
                case CMD_D_FS: speed = "FS"; hasData = true; break;
                case CMD_D_HS: speed = "HS"; hasData = true; break;
                default:
                    LogInOtherThread("Response Unknown"); break;

            }
            if (hasData) {
                if (len > 9)
                {
                    UInt32 ts = GetUint32(data, 0);
                    UInt32 nano = GetUint32(data, 4);
                    LogInOtherThread("Got " + speed + " data " + ts + "." + nano + " data len " + (len - 8) + " PID " + (data[8] & 0x0f));
                }
                else {
                    LogInOtherThread("Wrong data len " + len);
                }
            }
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            SendCommand(new byte[] { CMD_START_FLAG, CMD_LIST, 0, 0 }, 4);
        }
        private void btnOpenDevice_Click(object sender, EventArgs e)
        {
            byte[] sn = System.Text.Encoding.ASCII.GetBytes(textSN.Text);
            byte[] data = new byte[4 + sn.Length + 2];
            data[0] = CMD_START_FLAG;
            data[1] = CMD_OPEN;
            data[2] = (byte)((sn.Length + 2) & 0xff);
            data[3] = (byte)((sn.Length + 2) >> 8);
            Array.Copy(sn, 0, data, 4, sn.Length);
            data[4 + sn.Length] = 0;
            byte speed = SPEED_AUTO;
            switch (comboSpeed.SelectedIndex)
            {
                case 0: speed = SPEED_HS; break;
                case 1: speed = SPEED_FS; break;
                case 2: speed = SPEED_LS; break;
                case 3: speed = SPEED_AUTO; break;
            }
            data[5 + sn.Length] = speed;

            SendCommand(data, data.Length);
        }
        private void btnCloseDevice_Click(object sender, EventArgs e)
        {
            SendCommand(new byte[] { CMD_START_FLAG, CMD_CLOSE, 0, 0 }, 4);
        }
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            textLog.Clear();
        }
        private void btnUDP_Click(object sender, EventArgs e)
        {

            if (m_udpClient == null)
            {
                m_udpClient = new UdpClient();
                m_udpClient.Connect(textIP.Text, int.Parse(textPort.Text));
                btnUDP.Text = "Stop UDP";
                btnConnect.Enabled = false;
                m_udpClient.BeginReceive(UdpAsyncReadDone, null);
            }
            else {
                m_udpClient.Close();
                m_udpClient = null;
                btnUDP.Text = "Start UDP";
                btnConnect.Enabled = true;
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnUDP.Enabled = false;
            if (m_tcpClient.Connected)
            {
                m_tcpClient.Close();
                TcpConnectionChanged(false);
                btnUDP.Enabled = true;
                m_tcpMode = false;
            }
            else
            {
                m_tcpMode = true;
                m_tcpClient = new TcpClient();
                m_tcpClient.BeginConnect(
                    IPAddress.Parse(textIP.Text),
                    Int32.Parse(textPort.Text),
                    TcpAsyncConnect, this);
                btnConnect.Enabled = false;
            }
        }
    }
}
