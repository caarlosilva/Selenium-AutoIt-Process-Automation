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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txLogin = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogos = new System.Windows.Forms.PictureBox();
            this.tesseractOCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).BeginInit();
            this.SuspendLayout();
            // 
            // txLogin
            // 
            this.txLogin.Location = new System.Drawing.Point(15, 31);
            this.txLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(296, 23);
            this.txLogin.TabIndex = 0;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(15, 88);
            this.txPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(296, 23);
            this.txPassword.TabIndex = 1;
            this.txPassword.UseSystemPasswordChar = true;
            // 
            // cbSite
            // 
            this.cbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSite.Location = new System.Drawing.Point(335, 30);
            this.cbSite.Margin = new System.Windows.Forms.Padding(3, 4, 15, 4);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(170, 24);
            this.cbSite.TabIndex = 2;
            this.cbSite.SelectedIndexChanged += new System.EventHandler(this.cbSite_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSite);
            this.panel1.Controls.Add(this.txLogin);
            this.panel1.Controls.Add(this.txPassword);
            this.panel1.Location = new System.Drawing.Point(10, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 129);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(333, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Site";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.ForeColor = System.Drawing.Color.Lime;
            this.btStart.Location = new System.Drawing.Point(388, 215);
            this.btStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(144, 27);
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
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login Module";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(14, 219);
            this.lbWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(304, 16);
            this.lbWarning.TabIndex = 6;
            this.lbWarning.Text = "Something is wrong, please check the fields!";
            this.lbWarning.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tesseractOCRToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pbLogos
            // 
            this.pbLogos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogos.Image = global::MainForm.Properties.Resources._008_twitter;
            this.pbLogos.Location = new System.Drawing.Point(483, 28);
            this.pbLogos.Name = "pbLogos";
            this.pbLogos.Size = new System.Drawing.Size(46, 44);
            this.pbLogos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogos.TabIndex = 7;
            this.pbLogos.TabStop = false;
            // 
            // tesseractOCRToolStripMenuItem
            // 
            this.tesseractOCRToolStripMenuItem.Name = "tesseractOCRToolStripMenuItem";
            this.tesseractOCRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tesseractOCRToolStripMenuItem.Text = "Tesseract OCR";
            this.tesseractOCRToolStripMenuItem.Click += new System.EventHandler(this.tesseractOCRToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(543, 254);
            this.Controls.Add(this.pbLogos);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "S.A.P.A - Selenium/AutoIt Process Automation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).EndInit();
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
        private System.Windows.Forms.PictureBox pbLogos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesseractOCRToolStripMenuItem;
    }
}

