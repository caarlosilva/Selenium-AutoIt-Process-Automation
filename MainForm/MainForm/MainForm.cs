using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;


namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (cbSite.Text.Equals("Twitter") && txLogin.Text != "" && txPassword.Text != "")
            {
                if (lbWarning.Visible) lbWarning.Visible = false;
                Main.loginTwitter(txLogin.Text, txPassword.Text);
            }
            else
            {
                lbWarning.Visible = true;
            }
                

        }
    }
}
