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
            this.lblStatusDesc = new System.Windows.Forms.Label();
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTextinput = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDashStatus = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.cbDashboardCommand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDashboardStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNewTCPPosition = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMoveType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRz = new System.Windows.Forms.TextBox();
            this.txtRy = new System.Windows.Forms.TextBox();
            this.txtRx = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemovePoses = new System.Windows.Forms.Button();
            this.btnRecordPose = new System.Windows.Forms.Button();
            this.lbRobotPoses = new System.Windows.Forms.ListBox();
            this.lblUrScriptStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatusDesc);
            this.groupBox1.Controls.Add(this.rbStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RTDE Connection";
            // 
            // lblStatusDesc
            // 
            this.lblStatusDesc.AutoSize = true;
            this.lblStatusDesc.Location = new System.Drawing.Point(19, 94);
            this.lblStatusDesc.Name = "lblStatusDesc";
            this.lblStatusDesc.Size = new System.Drawing.Size(0, 16);
            this.lblStatusDesc.TabIndex = 5;
            // 
            // rbStatus
            // 
            this.rbStatus.AutoCheck = false;
            this.rbStatus.AutoSize = true;
            this.rbStatus.Enabled = false;
            this.rbStatus.Location = new System.Drawing.Point(65, 64);
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
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "status:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 21);
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
            this.txtIP.Location = new System.Drawing.Point(94, 30);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(173, 22);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "10.130.255.117";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(427, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 515);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tool Position";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 21);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(424, 488);
            this.webBrowser1.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTextinput);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblDashStatus);
            this.groupBox3.Controls.Add(this.labl);
            this.groupBox3.Controls.Add(this.cbDashboardCommand);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.lblDashboardStatus);
            this.groupBox3.Location = new System.Drawing.Point(13, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 165);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dashboard Connection";
            // 
            // txtTextinput
            // 
            this.txtTextinput.Location = new System.Drawing.Point(93, 85);
            this.txtTextinput.Name = "txtTextinput";
            this.txtTextinput.Size = new System.Drawing.Size(176, 22);
            this.txtTextinput.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 16);
            this.label17.TabIndex = 11;
            this.label17.Text = "text:";
            // 
            // lblDashStatus
            // 
            this.lblDashStatus.AutoSize = true;
            this.lblDashStatus.Location = new System.Drawing.Point(72, 129);
            this.lblDashStatus.Name = "lblDashStatus";
            this.lblDashStatus.Size = new System.Drawing.Size(0, 16);
            this.lblDashStatus.TabIndex = 10;
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Location = new System.Drawing.Point(19, 129);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(45, 16);
            this.labl.TabIndex = 9;
            this.labl.Text = "status:";
            // 
            // cbDashboardCommand
            // 
            this.cbDashboardCommand.FormattingEnabled = true;
            this.cbDashboardCommand.Items.AddRange(new object[] {
            "load",
            "play",
            "stop",
            "pause",
            "quit",
            "shutdown",
            "running",
            "robotmode",
            "get loaded program",
            "isProgramSaved",
            "programState",
            "PolyscopeVersion",
            "set operational mode",
            "get operational mode",
            "clear operational mode",
            "power on",
            "power off",
            "brake release",
            "safetystatus",
            "unlock protective stop",
            "close safety popup",
            "load installation <default.installation>",
            "restart safety",
            "is in remote control",
            "get serial number",
            "get robot model"});
            this.cbDashboardCommand.Location = new System.Drawing.Point(93, 42);
            this.cbDashboardCommand.Name = "cbDashboardCommand";
            this.cbDashboardCommand.Size = new System.Drawing.Size(176, 24);
            this.cbDashboardCommand.TabIndex = 8;
            this.cbDashboardCommand.SelectedIndexChanged += new System.EventHandler(this.cbDashboardCommand_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Command:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 44);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNewTCPPosition);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtT);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtV);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtA);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbMoveType);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtRz);
            this.groupBox4.Controls.Add(this.txtRy);
            this.groupBox4.Controls.Add(this.txtRx);
            this.groupBox4.Controls.Add(this.txtZ);
            this.groupBox4.Controls.Add(this.txtY);
            this.groupBox4.Controls.Add(this.txtX);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnRemovePoses);
            this.groupBox4.Controls.Add(this.btnRecordPose);
            this.groupBox4.Controls.Add(this.lbRobotPoses);
            this.groupBox4.Controls.Add(this.lblUrScriptStatus);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnSend);
            this.groupBox4.Location = new System.Drawing.Point(873, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 524);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "URscript commands";
            // 
            // btnNewTCPPosition
            // 
            this.btnNewTCPPosition.Enabled = false;
            this.btnNewTCPPosition.Location = new System.Drawing.Point(20, 484);
            this.btnNewTCPPosition.Name = "btnNewTCPPosition";
            this.btnNewTCPPosition.Size = new System.Drawing.Size(387, 31);
            this.btnNewTCPPosition.TabIndex = 37;
            this.btnNewTCPPosition.Text = "Try and Insert new TCP Position";
            this.btnNewTCPPosition.UseVisualStyleBackColor = true;
            this.btnNewTCPPosition.Click += new System.EventHandler(this.btnNewTCPPosition_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(217, 450);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(190, 22);
            this.textBox7.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 456);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "bend radius (m):";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(217, 422);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(190, 22);
            this.txtT.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 428);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "time (s):";
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(217, 391);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(190, 22);
            this.txtV.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 400);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "set joint speed (rad/s):";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(217, 363);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(190, 22);
            this.txtA.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 369);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "set joint acceleration (rad/s^2):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "select a move type:";
            // 
            // cbMoveType
            // 
            this.cbMoveType.FormattingEnabled = true;
            this.cbMoveType.Items.AddRange(new object[] {
            "movej",
            "movel",
            "servoj"});
            this.cbMoveType.Location = new System.Drawing.Point(217, 329);
            this.cbMoveType.Name = "cbMoveType";
            this.cbMoveType.Size = new System.Drawing.Size(190, 24);
            this.cbMoveType.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Rz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ry";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Rx";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "X";
            // 
            // txtRz
            // 
            this.txtRz.Location = new System.Drawing.Point(310, 273);
            this.txtRz.Name = "txtRz";
            this.txtRz.Size = new System.Drawing.Size(48, 22);
            this.txtRz.TabIndex = 20;
            // 
            // txtRy
            // 
            this.txtRy.Location = new System.Drawing.Point(256, 273);
            this.txtRy.Name = "txtRy";
            this.txtRy.Size = new System.Drawing.Size(48, 22);
            this.txtRy.TabIndex = 19;
            // 
            // txtRx
            // 
            this.txtRx.Location = new System.Drawing.Point(202, 273);
            this.txtRx.Name = "txtRx";
            this.txtRx.Size = new System.Drawing.Size(48, 22);
            this.txtRx.TabIndex = 18;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(148, 273);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(48, 22);
            this.txtZ.TabIndex = 17;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(94, 273);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(48, 22);
            this.txtY.TabIndex = 16;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(40, 273);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(48, 22);
            this.txtX.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter TCP Position (m for X, Y and Z)(Radian for Rx,Ry,Rz):";
            // 
            // btnRemovePoses
            // 
            this.btnRemovePoses.Enabled = false;
            this.btnRemovePoses.Location = new System.Drawing.Point(232, 113);
            this.btnRemovePoses.Name = "btnRemovePoses";
            this.btnRemovePoses.Size = new System.Drawing.Size(177, 29);
            this.btnRemovePoses.TabIndex = 13;
            this.btnRemovePoses.Text = "Remove selected pose";
            this.btnRemovePoses.UseVisualStyleBackColor = true;
            this.btnRemovePoses.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnRecordPose
            // 
            this.btnRecordPose.Enabled = false;
            this.btnRecordPose.Location = new System.Drawing.Point(232, 66);
            this.btnRecordPose.Name = "btnRecordPose";
            this.btnRecordPose.Size = new System.Drawing.Size(177, 30);
            this.btnRecordPose.TabIndex = 12;
            this.btnRecordPose.Text = "Record current pose";
            this.btnRecordPose.UseVisualStyleBackColor = true;
            this.btnRecordPose.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbRobotPoses
            // 
            this.lbRobotPoses.FormattingEnabled = true;
            this.lbRobotPoses.ItemHeight = 16;
            this.lbRobotPoses.Location = new System.Drawing.Point(15, 21);
            this.lbRobotPoses.Name = "lbRobotPoses";
            this.lbRobotPoses.ScrollAlwaysVisible = true;
            this.lbRobotPoses.Size = new System.Drawing.Size(200, 196);
            this.lbRobotPoses.TabIndex = 11;
            // 
            // lblUrScriptStatus
            // 
            this.lblUrScriptStatus.AutoSize = true;
            this.lblUrScriptStatus.Location = new System.Drawing.Point(69, 225);
            this.lblUrScriptStatus.Name = "lblUrScriptStatus";
            this.lblUrScriptStatus.Size = new System.Drawing.Size(0, 16);
            this.lblUrScriptStatus.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "status:";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(232, 21);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(177, 31);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send Command";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPositionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewPositionToolStripMenuItem
            // 
            this.addNewPositionToolStripMenuItem.Name = "addNewPositionToolStripMenuItem";
            this.addNewPositionToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.addNewPositionToolStripMenuItem.Text = "Add new position";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 569);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDashboardStatus;
        private System.Windows.Forms.ComboBox cbDashboardCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label lblDashStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblUrScriptStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRemovePoses;
        private System.Windows.Forms.Button btnRecordPose;
        private System.Windows.Forms.ListBox lbRobotPoses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRz;
        private System.Windows.Forms.TextBox txtRy;
        private System.Windows.Forms.TextBox txtRx;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblStatusDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMoveType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPositionToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTextinput;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnNewTCPPosition;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtA;
    }
}

