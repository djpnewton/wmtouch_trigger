namespace wmtouch_trigger
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.cbActivateOnce = new System.Windows.Forms.CheckBox();
            this.numActivationHoldoff = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbToAddr = new System.Windows.Forms.TextBox();
            this.cbUseSSL = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbSMTPHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.cbDockBottom = new System.Windows.Forms.CheckBox();
            this.tmrEmail = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.tmrEmailTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numActivationHoldoff)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "WMTOUCH command:";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(18, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(15, 63);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(75, 27);
            this.btnActivate.TabIndex = 2;
            this.btnActivate.Text = "Activate Command";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // cbActivateOnce
            // 
            this.cbActivateOnce.AutoSize = true;
            this.cbActivateOnce.Checked = true;
            this.cbActivateOnce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActivateOnce.Location = new System.Drawing.Point(15, 96);
            this.cbActivateOnce.Name = "cbActivateOnce";
            this.cbActivateOnce.Size = new System.Drawing.Size(223, 21);
            this.cbActivateOnce.TabIndex = 3;
            this.cbActivateOnce.Text = "Only activate once per resume";
            this.cbActivateOnce.UseVisualStyleBackColor = true;
            // 
            // numActivationHoldoff
            // 
            this.numActivationHoldoff.Location = new System.Drawing.Point(15, 123);
            this.numActivationHoldoff.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numActivationHoldoff.Name = "numActivationHoldoff";
            this.numActivationHoldoff.Size = new System.Drawing.Size(75, 22);
            this.numActivationHoldoff.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Activation Holdoff (ms)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbDockBottom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.numActivationHoldoff);
            this.panel1.Controls.Add(this.btnActivate);
            this.panel1.Controls.Add(this.cbActivateOnce);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 381);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnStopTimer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbToAddr);
            this.groupBox1.Controls.Add(this.cbUseSSL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.tbSMTPHost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numTimeout);
            this.groupBox1.Location = new System.Drawing.Point(11, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 189);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email on activation timeout";
            // 
            // tbToAddr
            // 
            this.tbToAddr.Location = new System.Drawing.Point(6, 160);
            this.tbToAddr.Name = "tbToAddr";
            this.tbToAddr.Size = new System.Drawing.Size(100, 22);
            this.tbToAddr.TabIndex = 17;
            // 
            // cbUseSSL
            // 
            this.cbUseSSL.AutoSize = true;
            this.cbUseSSL.Location = new System.Drawing.Point(6, 133);
            this.cbUseSSL.Name = "cbUseSSL";
            this.cbUseSSL.Size = new System.Drawing.Size(85, 21);
            this.cbUseSSL.TabIndex = 16;
            this.cbUseSSL.Text = "Use SSL";
            this.cbUseSSL.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Username";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(7, 105);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "SMTP host";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(7, 77);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 22);
            this.tbUsername.TabIndex = 11;
            // 
            // tbSMTPHost
            // 
            this.tbSMTPHost.Location = new System.Drawing.Point(7, 49);
            this.tbSMTPHost.Name = "tbSMTPHost";
            this.tbSMTPHost.Size = new System.Drawing.Size(100, 22);
            this.tbSMTPHost.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Timeout (sec)";
            // 
            // numTimeout
            // 
            this.numTimeout.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTimeout.Location = new System.Drawing.Point(7, 21);
            this.numTimeout.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(75, 22);
            this.numTimeout.TabIndex = 5;
            // 
            // cbDockBottom
            // 
            this.cbDockBottom.AutoSize = true;
            this.cbDockBottom.Location = new System.Drawing.Point(12, 151);
            this.cbDockBottom.Name = "cbDockBottom";
            this.cbDockBottom.Size = new System.Drawing.Size(143, 21);
            this.cbDockBottom.TabIndex = 6;
            this.cbDockBottom.Text = "Dock UI at Bottom";
            this.cbDockBottom.UseVisualStyleBackColor = true;
            this.cbDockBottom.CheckedChanged += new System.EventHandler(this.cbDockBottom_CheckedChanged);
            // 
            // tmrEmail
            // 
            this.tmrEmail.Tick += new System.EventHandler(this.tmrEmail_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "To";
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Location = new System.Drawing.Point(189, 17);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(135, 29);
            this.btnStopTimer.TabIndex = 19;
            this.btnStopTimer.Text = "Stop Timer";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Visible = false;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // tmrEmailTime
            // 
            this.tmrEmailTime.Enabled = true;
            this.tmrEmailTime.Interval = 1000;
            this.tmrEmailTime.Tick += new System.EventHandler(this.tmrEmailTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 447);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "wmtouch trigger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numActivationHoldoff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.CheckBox cbActivateOnce;
        private System.Windows.Forms.NumericUpDown numActivationHoldoff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDockBottom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUseSSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbSMTPHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.Timer tmrEmail;
        private System.Windows.Forms.TextBox tbToAddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Timer tmrEmailTime;
    }
}

