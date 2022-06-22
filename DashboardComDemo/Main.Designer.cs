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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(302, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblStatusDesc
            // 
            this.lblStatusDesc.AutoSize = true;
            this.lblStatusDesc.Location = new System.Drawing.Point(37, 134);
            this.lblStatusDesc.Name = "lblStatusDesc";
            this.lblStatusDesc.Size = new System.Drawing.Size(0, 16);
            this.lblStatusDesc.TabIndex = 5;
            // 
            // rbStatus
            // 
            this.rbStatus.AutoCheck = false;
            this.rbStatus.AutoSize = true;
            this.rbStatus.Enabled = false;
            this.rbStatus.Location = new System.Drawing.Point(88, 96);
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
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "status:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(88, 43);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(193, 22);
            this.txtIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(321, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 469);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Joint angles";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(974, 448);
            this.webBrowser1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Dashboard Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
    }
}

