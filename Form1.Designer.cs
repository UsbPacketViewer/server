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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Addr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(278, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Start TCP";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(66, 16);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 21);
            this.textIP.TabIndex = 5;
            this.textIP.Text = "127.0.0.1";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(211, 15);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(58, 21);
            this.textPort.TabIndex = 6;
            this.textPort.Text = "17924";
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(14, 133);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(501, 246);
            this.textLog.TabIndex = 7;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(14, 76);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "List Device";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnOpenDevice
            // 
            this.btnOpenDevice.Location = new System.Drawing.Point(96, 76);
            this.btnOpenDevice.Name = "btnOpenDevice";
            this.btnOpenDevice.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDevice.TabIndex = 9;
            this.btnOpenDevice.Text = "Open Device";
            this.btnOpenDevice.UseVisualStyleBackColor = true;
            this.btnOpenDevice.Click += new System.EventHandler(this.btnOpenDevice_Click);
            // 
            // btnCloseDevice
            // 
            this.btnCloseDevice.Location = new System.Drawing.Point(437, 76);
            this.btnCloseDevice.Name = "btnCloseDevice";
            this.btnCloseDevice.Size = new System.Drawing.Size(75, 23);
            this.btnCloseDevice.TabIndex = 10;
            this.btnCloseDevice.Text = "Close";
            this.btnCloseDevice.UseVisualStyleBackColor = true;
            this.btnCloseDevice.Click += new System.EventHandler(this.btnCloseDevice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "SN:";
            // 
            // textSN
            // 
            this.textSN.Location = new System.Drawing.Point(202, 76);
            this.textSN.Name = "textSN";
            this.textSN.Size = new System.Drawing.Size(72, 21);
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
            this.comboSpeed.Location = new System.Drawing.Point(323, 77);
            this.comboSpeed.Name = "comboSpeed";
            this.comboSpeed.Size = new System.Drawing.Size(59, 20);
            this.comboSpeed.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Speed";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(440, 15);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 15;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnUDP
            // 
            this.btnUDP.Location = new System.Drawing.Point(359, 14);
            this.btnUDP.Name = "btnUDP";
            this.btnUDP.Size = new System.Drawing.Size(75, 23);
            this.btnUDP.TabIndex = 16;
            this.btnUDP.Text = "Start UDP";
            this.btnUDP.UseVisualStyleBackColor = true;
            this.btnUDP.Click += new System.EventHandler(this.btnUDP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 391);
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
    }
}

