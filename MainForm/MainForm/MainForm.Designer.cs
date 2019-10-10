namespace MainForm
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
            this.txLogin = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txLogin
            // 
            this.txLogin.Location = new System.Drawing.Point(20, 35);
            this.txLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(423, 27);
            this.txLogin.TabIndex = 0;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(20, 99);
            this.txPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(423, 27);
            this.txPassword.TabIndex = 1;
            this.txPassword.UseSystemPasswordChar = true;
            // 
            // cbSite
            // 
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(396, 17);
            this.cbSite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(200, 26);
            this.cbSite.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txLogin);
            this.panel1.Controls.Add(this.txPassword);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 145);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.ForeColor = System.Drawing.Color.Lime;
            this.btStart.Location = new System.Drawing.Point(466, 100);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(117, 26);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Automation Process Login";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(232, 212);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(377, 18);
            this.lbWarning.TabIndex = 6;
            this.lbWarning.Text = "Something is wrong, please check the fields!";
            this.lbWarning.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(621, 237);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbSite);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txLogin;
        public System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Label lbWarning;
    }
}

