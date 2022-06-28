namespace DashboardComDemo
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblStatusDesc = new System.Windows.Forms.Label();
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDashStatus = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.cbDashboardCommand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDashboardStatus = new System.Windows.Forms.Label();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblUrScriptStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lbRobotPoses = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblStatusDesc);
            this.groupBox1.Controls.Add(this.rbStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RTDE Connection";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblStatusDesc
            // 
            this.lblStatusDesc.AutoSize = true;
            this.lblStatusDesc.Location = new System.Drawing.Point(82, 112);
            this.lblStatusDesc.Name = "lblStatusDesc";
            this.lblStatusDesc.Size = new System.Drawing.Size(0, 16);
            this.lblStatusDesc.TabIndex = 5;
            // 
            // rbStatus
            // 
            this.rbStatus.AutoCheck = false;
            this.rbStatus.AutoSize = true;
            this.rbStatus.Enabled = false;
            this.rbStatus.Location = new System.Drawing.Point(133, 74);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(117, 20);
            this.rbStatus.TabIndex = 4;
            this.rbStatus.TabStop = true;
            this.rbStatus.Text = "Not Connected";
            this.rbStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "status:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIP
            // 
            this.txtIP.AutoCompleteCustomSource.AddRange(new string[] {
            "10.233.180.57"});
            this.txtIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIP.Location = new System.Drawing.Point(133, 21);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(173, 22);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "10.130.252.69";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(427, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tool Position";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(485, 417);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDashStatus);
            this.groupBox3.Controls.Add(this.labl);
            this.groupBox3.Controls.Add(this.cbDashboardCommand);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.lblDashboardStatus);
            this.groupBox3.Controls.Add(this.btnSendCommand);
            this.groupBox3.Location = new System.Drawing.Point(12, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 219);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dashboard Connection";
            // 
            // lblDashStatus
            // 
            this.lblDashStatus.AutoSize = true;
            this.lblDashStatus.Location = new System.Drawing.Point(112, 111);
            this.lblDashStatus.Name = "lblDashStatus";
            this.lblDashStatus.Size = new System.Drawing.Size(0, 16);
            this.lblDashStatus.TabIndex = 10;
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Location = new System.Drawing.Point(59, 111);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(45, 16);
            this.labl.TabIndex = 9;
            this.labl.Text = "status:";
            // 
            // cbDashboardCommand
            // 
            this.cbDashboardCommand.FormattingEnabled = true;
            this.cbDashboardCommand.Items.AddRange(new object[] {
            "Load program",
            "play",
            "stop",
            "pause",
            "quit",
            "shutdown",
            "running",
            "robotmode",
            "get loaded program",
            "popup",
            "close popup",
            "addToLog",
            "isProgramSaved"});
            this.cbDashboardCommand.Location = new System.Drawing.Point(133, 60);
            this.cbDashboardCommand.Name = "cbDashboardCommand";
            this.cbDashboardCommand.Size = new System.Drawing.Size(176, 24);
            this.cbDashboardCommand.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Command:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "Send Command";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDashboardStatus
            // 
            this.lblDashboardStatus.AutoSize = true;
            this.lblDashboardStatus.Location = new System.Drawing.Point(15, 29);
            this.lblDashboardStatus.Name = "lblDashboardStatus";
            this.lblDashboardStatus.Size = new System.Drawing.Size(0, 16);
            this.lblDashboardStatus.TabIndex = 5;
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(56, 152);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(102, 44);
            this.btnSendCommand.TabIndex = 2;
            this.btnSendCommand.Text = "Connect to Dashboard";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.lbRobotPoses);
            this.groupBox4.Controls.Add(this.lblUrScriptStatus);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(924, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 435);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "URscript commands";
            // 
            // lblUrScriptStatus
            // 
            this.lblUrScriptStatus.AutoSize = true;
            this.lblUrScriptStatus.Location = new System.Drawing.Point(65, 357);
            this.lblUrScriptStatus.Name = "lblUrScriptStatus";
            this.lblUrScriptStatus.Size = new System.Drawing.Size(0, 16);
            this.lblUrScriptStatus.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Recorded robot positions:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "Send Command";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbRobotPoses
            // 
            this.lbRobotPoses.FormattingEnabled = true;
            this.lbRobotPoses.ItemHeight = 16;
            this.lbRobotPoses.Location = new System.Drawing.Point(11, 40);
            this.lbRobotPoses.Name = "lbRobotPoses";
            this.lbRobotPoses.Size = new System.Drawing.Size(373, 308);
            this.lbRobotPoses.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(143, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 44);
            this.button5.TabIndex = 12;
            this.button5.Text = "Record current pose";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(276, 385);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 44);
            this.button6.TabIndex = 13;
            this.button6.Text = "Remove selected pose";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 462);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Dashboard Demo";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatusDesc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDashboardStatus;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.ComboBox cbDashboardCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label lblDashStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblUrScriptStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox lbRobotPoses;
    }
}

