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
            comboSource.Add("gh", "GitHub");
            comboSource.Add("lkd", "Linkedin");
            comboSource.Add("insta", "Instagram");
            comboSource.Add("twc", "Twitch");
            cbSite.DataSource = new BindingSource(comboSource, null);
            cbSite.DisplayMember = "Value";
            cbSite.ValueMember = "Key";
            // initial value
            cbSite.SelectedValue = "twt";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            else if (cbSite.Text.Equals("GitHub") && txLogin.Text != "" && txPassword.Text != "")
            {
                if (lbWarning.Visible) lbWarning.Visible = false;
                Main.loginGit(txLogin.Text, txPassword.Text);
            }
            else if (cbSite.Text.Equals("Linkedin") && txLogin.Text != "" && txPassword.Text != "")
            {
                if (lbWarning.Visible) lbWarning.Visible = false;
                Main.loginLinkedin(txLogin.Text, txPassword.Text);
            }
            else if (cbSite.Text.Equals("Instagram") && txLogin.Text != "" && txPassword.Text != "")
            {
                if (lbWarning.Visible) lbWarning.Visible = false;
                Main.loginInsta(txLogin.Text, txPassword.Text);
            }
            else if (cbSite.Text.Equals("Twitch") && txLogin.Text != "" && txPassword.Text != "")
            {
                if (lbWarning.Visible) lbWarning.Visible = false;
                Main.loginTwitch(txLogin.Text, txPassword.Text);
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
            if (cbSite.SelectedValue.Equals("gh"))
            {
                pbLogos.Image = Resources.git;
            }
            if(cbSite.SelectedValue.Equals("lkd"))
            {
                pbLogos.Image = Resources.linkedin;
            }
            if (cbSite.SelectedValue.Equals("insta"))
            {
                pbLogos.Image = Resources.instagram;
            }
            if (cbSite.SelectedValue.Equals("twc"))
            {
                pbLogos.Image = Resources.twitch;
            }
        }

        private void tesseractOCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TessOCR ocr = new TessOCR();
            ocr.Show();
        }

    }
}
