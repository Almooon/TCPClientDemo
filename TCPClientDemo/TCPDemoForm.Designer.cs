namespace TCPClientDemo
{
    partial class TCPDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbReadtimeout = new System.Windows.Forms.TextBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.rbrn = new System.Windows.Forms.RadioButton();
            this.rbn = new System.Windows.Forms.RadioButton();
            this.rbr = new System.Windows.Forms.RadioButton();
            this.btnSendBt = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDiscon = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnSendStr = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbReceived = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCMD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbReadtimeout);
            this.panel1.Controls.Add(this.tbInterval);
            this.panel1.Controls.Add(this.rbrn);
            this.panel1.Controls.Add(this.rbn);
            this.panel1.Controls.Add(this.rbr);
            this.panel1.Controls.Add(this.btnSendBt);
            this.panel1.Controls.Add(this.lbTimer);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDiscon);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.btnReceive);
            this.panel1.Controls.Add(this.btnSendStr);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.lbReceived);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbCMD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPort);
            this.panel1.Controls.Add(this.tbIP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 388);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "RTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "ITV:";
            // 
            // tbReadtimeout
            // 
            this.tbReadtimeout.Location = new System.Drawing.Point(143, 39);
            this.tbReadtimeout.Name = "tbReadtimeout";
            this.tbReadtimeout.Size = new System.Drawing.Size(68, 21);
            this.tbReadtimeout.TabIndex = 19;
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(37, 39);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(54, 21);
            this.tbInterval.TabIndex = 18;
            // 
            // rbrn
            // 
            this.rbrn.AutoSize = true;
            this.rbrn.Location = new System.Drawing.Point(284, 57);
            this.rbrn.Name = "rbrn";
            this.rbrn.Size = new System.Drawing.Size(47, 16);
            this.rbrn.TabIndex = 17;
            this.rbrn.TabStop = true;
            this.rbrn.Text = "\\r\\n";
            this.rbrn.UseVisualStyleBackColor = true;
            this.rbrn.CheckedChanged += new System.EventHandler(this.OnRadiobuttonChecked);
            // 
            // rbn
            // 
            this.rbn.AutoSize = true;
            this.rbn.Location = new System.Drawing.Point(284, 35);
            this.rbn.Name = "rbn";
            this.rbn.Size = new System.Drawing.Size(35, 16);
            this.rbn.TabIndex = 16;
            this.rbn.TabStop = true;
            this.rbn.Text = "\\n";
            this.rbn.UseVisualStyleBackColor = true;
            this.rbn.CheckedChanged += new System.EventHandler(this.OnRadiobuttonChecked);
            // 
            // rbr
            // 
            this.rbr.AutoSize = true;
            this.rbr.Location = new System.Drawing.Point(284, 13);
            this.rbr.Name = "rbr";
            this.rbr.Size = new System.Drawing.Size(35, 16);
            this.rbr.TabIndex = 15;
            this.rbr.TabStop = true;
            this.rbr.Text = "\\r";
            this.rbr.UseVisualStyleBackColor = true;
            this.rbr.CheckedChanged += new System.EventHandler(this.OnRadiobuttonChecked);
            // 
            // btnSendBt
            // 
            this.btnSendBt.Location = new System.Drawing.Point(193, 126);
            this.btnSendBt.Name = "btnSendBt";
            this.btnSendBt.Size = new System.Drawing.Size(103, 23);
            this.btnSendBt.TabIndex = 14;
            this.btnSendBt.Text = "Send by bytes";
            this.btnSendBt.UseVisualStyleBackColor = true;
            this.btnSendBt.Click += new System.EventHandler(this.btnSendBt_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.Location = new System.Drawing.Point(185, 359);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(151, 18);
            this.lbTimer.TabIndex = 13;
            this.lbTimer.Text = "Connecting: 0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(342, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDiscon
            // 
            this.btnDiscon.Location = new System.Drawing.Point(342, 39);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(75, 23);
            this.btnDiscon.TabIndex = 11;
            this.btnDiscon.Text = "DisCon.";
            this.btnDiscon.UseVisualStyleBackColor = true;
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.ForeColor = System.Drawing.Color.Brown;
            this.lbStatus.Location = new System.Drawing.Point(12, 359);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(101, 18);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "Offline";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(344, 354);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 9;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnSendStr
            // 
            this.btnSendStr.Location = new System.Drawing.Point(316, 126);
            this.btnSendStr.Name = "btnSendStr";
            this.btnSendStr.Size = new System.Drawing.Size(103, 23);
            this.btnSendStr.TabIndex = 8;
            this.btnSendStr.Text = "Send by string";
            this.btnSendStr.UseVisualStyleBackColor = true;
            this.btnSendStr.Click += new System.EventHandler(this.btnSendStr_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(342, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbReceived
            // 
            this.lbReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbReceived.Location = new System.Drawing.Point(12, 152);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(407, 198);
            this.lbReceived.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "CDM:";
            // 
            // tbCMD
            // 
            this.tbCMD.Location = new System.Drawing.Point(14, 99);
            this.tbCMD.Name = "tbCMD";
            this.tbCMD.Size = new System.Drawing.Size(405, 21);
            this.tbCMD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(178, 12);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 21);
            this.tbPort.TabIndex = 1;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(37, 12);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 21);
            this.tbIP.TabIndex = 0;
            // 
            // TCPDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(429, 388);
            this.Controls.Add(this.panel1);
            this.Name = "TCPDemoForm";
            this.ShowIcon = false;
            this.Text = "TCPDemoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnSendStr;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbReceived;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCMD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnDiscon;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Button btnSendBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReadtimeout;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.RadioButton rbrn;
        private System.Windows.Forms.RadioButton rbn;
        private System.Windows.Forms.RadioButton rbr;
    }
}