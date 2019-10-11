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
using MainForm.Properties;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("twt", "Twitter");
            comboSource.Add("fb", "Facebook");
            comboSource.Add("gm", "Gmail");
            cbSite.DataSource = new BindingSource(comboSource, null);
            cbSite.DisplayMember = "Value";
            cbSite.ValueMember = "Key";
            cbSite.SelectedValue = "twt";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (cbSite.Text.Equals("Twitter") && txLogin.Text != "" && txPassword.Text != "")
            {
                if (lbWarning.Visible) lbWarning.Visible = false;
                Main.loginTwitter(txLogin.Text, txPassword.Text);
            }
            else if (cbSite.Text.Equals("Facebook") && txLogin.Text != "" && txPassword.Text != "")
            {
                if (lbWarning.Visible) lbWarning.Visible = false;
                Main.loginFacebook(txLogin.Text, txPassword.Text);
            }
            else if (cbSite.Text.Equals("Gmail") && txLogin.Text != "" && txPassword.Text != "")
            {
                if (lbWarning.Visible) lbWarning.Visible = false;
                Main.loginGmail(txLogin.Text, txPassword.Text);
            }
            else
            {
                lbWarning.Visible = true;
            }

        }

        private void cbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSite.SelectedValue.Equals("twt"))
            {
                pbLogos.Image = Resources._008_twitter;
            }
            if (cbSite.SelectedValue.Equals("fb"))
            {
                pbLogos.Image = Resources._036_facebook;
            }
            if (cbSite.SelectedValue.Equals("gm"))
            {
                pbLogos.Image = Resources.gmail;
            }
        }
    }
}
