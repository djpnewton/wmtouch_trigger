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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.cbActivateOnce = new System.Windows.Forms.CheckBox();
            this.numActivationHoldoff = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numActivationHoldoff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.textBox1.Location = new System.Drawing.Point(15, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(12, 57);
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
            this.cbActivateOnce.Location = new System.Drawing.Point(12, 90);
            this.cbActivateOnce.Name = "cbActivateOnce";
            this.cbActivateOnce.Size = new System.Drawing.Size(223, 21);
            this.cbActivateOnce.TabIndex = 3;
            this.cbActivateOnce.Text = "Only activate once per resume";
            this.cbActivateOnce.UseVisualStyleBackColor = true;
            // 
            // numActivationHoldoff
            // 
            this.numActivationHoldoff.Location = new System.Drawing.Point(12, 117);
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
            this.label2.Location = new System.Drawing.Point(93, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Activation Holdoff (ms)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numActivationHoldoff);
            this.Controls.Add(this.cbActivateOnce);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "wmtouch trigger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numActivationHoldoff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.CheckBox cbActivateOnce;
        private System.Windows.Forms.NumericUpDown numActivationHoldoff;
        private System.Windows.Forms.Label label2;
    }
}

