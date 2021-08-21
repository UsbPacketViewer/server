namespace usbpv_server_demo_cs
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnOpenDevice = new System.Windows.Forms.Button();
            this.btnCloseDevice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textSN = new System.Windows.Forms.TextBox();
            this.comboSpeed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnUDP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textFWIP = new System.Windows.Forms.TextBox();
            this.textFWPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textFWEP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboEpType = new System.Windows.Forms.ComboBox();
            this.btnFWTcp = new System.Windows.Forms.Button();
            this.btnFWUdp = new System.Windows.Forms.Button();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Addr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(417, 21);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 34);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Start TCP";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(99, 24);
            this.textIP.Margin = new System.Windows.Forms.Padding(4);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(148, 28);
            this.textIP.TabIndex = 5;
            this.textIP.Text = "127.0.0.1";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(316, 22);
            this.textPort.Margin = new System.Windows.Forms.Padding(4);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(85, 28);
            this.textPort.TabIndex = 6;
            this.textPort.Text = "17924";
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(21, 200);
            this.textLog.Margin = new System.Windows.Forms.Padding(4);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(750, 367);
            this.textLog.TabIndex = 7;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(21, 131);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(112, 34);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "List Device";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnOpenDevice
            // 
            this.btnOpenDevice.Location = new System.Drawing.Point(144, 131);
            this.btnOpenDevice.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenDevice.Name = "btnOpenDevice";
            this.btnOpenDevice.Size = new System.Drawing.Size(112, 34);
            this.btnOpenDevice.TabIndex = 9;
            this.btnOpenDevice.Text = "Open Device";
            this.btnOpenDevice.UseVisualStyleBackColor = true;
            this.btnOpenDevice.Click += new System.EventHandler(this.btnOpenDevice_Click);
            // 
            // btnCloseDevice
            // 
            this.btnCloseDevice.Location = new System.Drawing.Point(656, 131);
            this.btnCloseDevice.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseDevice.Name = "btnCloseDevice";
            this.btnCloseDevice.Size = new System.Drawing.Size(112, 34);
            this.btnCloseDevice.TabIndex = 10;
            this.btnCloseDevice.Text = "Close";
            this.btnCloseDevice.UseVisualStyleBackColor = true;
            this.btnCloseDevice.Click += new System.EventHandler(this.btnCloseDevice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "SN:";
            // 
            // textSN
            // 
            this.textSN.Location = new System.Drawing.Point(303, 131);
            this.textSN.Margin = new System.Windows.Forms.Padding(4);
            this.textSN.Name = "textSN";
            this.textSN.Size = new System.Drawing.Size(106, 28);
            this.textSN.TabIndex = 12;
            // 
            // comboSpeed
            // 
            this.comboSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpeed.FormattingEnabled = true;
            this.comboSpeed.Items.AddRange(new object[] {
            "High",
            "Full",
            "Low",
            "Auto"});
            this.comboSpeed.Location = new System.Drawing.Point(484, 133);
            this.comboSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.comboSpeed.Name = "comboSpeed";
            this.comboSpeed.Size = new System.Drawing.Size(86, 26);
            this.comboSpeed.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Speed";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(660, 22);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(112, 34);
            this.btnClearLog.TabIndex = 15;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnUDP
            // 
            this.btnUDP.Location = new System.Drawing.Point(538, 21);
            this.btnUDP.Margin = new System.Windows.Forms.Padding(4);
            this.btnUDP.Name = "btnUDP";
            this.btnUDP.Size = new System.Drawing.Size(112, 34);
            this.btnUDP.TabIndex = 16;
            this.btnUDP.Text = "Start UDP";
            this.btnUDP.UseVisualStyleBackColor = true;
            this.btnUDP.Click += new System.EventHandler(this.btnUDP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = " FW Addr:";
            // 
            // textFWIP
            // 
            this.textFWIP.Location = new System.Drawing.Point(97, 77);
            this.textFWIP.Margin = new System.Windows.Forms.Padding(4);
            this.textFWIP.Name = "textFWIP";
            this.textFWIP.Size = new System.Drawing.Size(102, 28);
            this.textFWIP.TabIndex = 18;
            this.textFWIP.Text = "127.0.0.1";
            // 
            // textFWPort
            // 
            this.textFWPort.Location = new System.Drawing.Point(259, 76);
            this.textFWPort.Margin = new System.Windows.Forms.Padding(4);
            this.textFWPort.Name = "textFWPort";
            this.textFWPort.Size = new System.Drawing.Size(56, 28);
            this.textFWPort.TabIndex = 20;
            this.textFWPort.Text = "12345";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Port:";
            // 
            // textFWEP
            // 
            this.textFWEP.Location = new System.Drawing.Point(612, 79);
            this.textFWEP.Margin = new System.Windows.Forms.Padding(4);
            this.textFWEP.Name = "textFWEP";
            this.textFWEP.Size = new System.Drawing.Size(51, 28);
            this.textFWEP.TabIndex = 21;
            this.textFWEP.Text = "-1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ep:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Type:";
            // 
            // comboEpType
            // 
            this.comboEpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEpType.FormattingEnabled = true;
            this.comboEpType.Items.AddRange(new object[] {
            "All",
            "In",
            "Out"});
            this.comboEpType.Location = new System.Drawing.Point(720, 80);
            this.comboEpType.Margin = new System.Windows.Forms.Padding(4);
            this.comboEpType.Name = "comboEpType";
            this.comboEpType.Size = new System.Drawing.Size(47, 26);
            this.comboEpType.TabIndex = 24;
            // 
            // btnFWTcp
            // 
            this.btnFWTcp.Location = new System.Drawing.Point(325, 73);
            this.btnFWTcp.Margin = new System.Windows.Forms.Padding(4);
            this.btnFWTcp.Name = "btnFWTcp";
            this.btnFWTcp.Size = new System.Drawing.Size(102, 34);
            this.btnFWTcp.TabIndex = 25;
            this.btnFWTcp.Text = "Start TCP";
            this.btnFWTcp.UseVisualStyleBackColor = true;
            this.btnFWTcp.Click += new System.EventHandler(this.btnFWTcp_Click);
            // 
            // btnFWUdp
            // 
            this.btnFWUdp.Location = new System.Drawing.Point(439, 75);
            this.btnFWUdp.Margin = new System.Windows.Forms.Padding(4);
            this.btnFWUdp.Name = "btnFWUdp";
            this.btnFWUdp.Size = new System.Drawing.Size(103, 34);
            this.btnFWUdp.TabIndex = 26;
            this.btnFWUdp.Text = "Start UDP";
            this.btnFWUdp.UseVisualStyleBackColor = true;
            this.btnFWUdp.Click += new System.EventHandler(this.btnFWUdp_Click);
            // 
            // countTimer
            // 
            this.countTimer.Interval = 1000;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 586);
            this.Controls.Add(this.btnFWUdp);
            this.Controls.Add(this.btnFWTcp);
            this.Controls.Add(this.comboEpType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textFWEP);
            this.Controls.Add(this.textFWPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textFWIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUDP);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSpeed);
            this.Controls.Add(this.textSN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseDevice);
            this.Controls.Add(this.btnOpenDevice);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Test USBPV Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnOpenDevice;
        private System.Windows.Forms.Button btnCloseDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSN;
        private System.Windows.Forms.ComboBox comboSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnUDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFWIP;
        private System.Windows.Forms.TextBox textFWPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFWEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboEpType;
        private System.Windows.Forms.Button btnFWTcp;
        private System.Windows.Forms.Button btnFWUdp;
        private System.Windows.Forms.Timer countTimer;
    }
}

