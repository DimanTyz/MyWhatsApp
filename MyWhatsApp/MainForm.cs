using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace MyWhatsApp
{
   
    public partial class MainForm : Form
    {
        WhatsApp wa;
        public MainForm()
        {
            InitializeComponent();
        }

      

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel2.Enabled = false;
            listUsers.DisplayMember = "Display";
            listUsers.ValueMember = "PhoneNumber";
            signOutToolStripMenuItem.Visible = false;
            if (Properties.Settings.Default.Remember)
            {
                txtbPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
                txtbPassword.Text = Properties.Settings.Default.Password;
                cckbRememberME.Checked = Properties.Settings.Default.Remember;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cckbRememberME_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = cckbRememberME.Checked;
            Properties.Settings.Default.PhoneNumber = txtbPhoneNumber.Text;
            Properties.Settings.Default.Password = txtbPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void lnklblGetANewAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmRegistration form = new frmRegistration())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    txtbPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
                    txtbPassword.Text = Properties.Settings.Default.PhoneNumber;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAbout frm = new frmAbout())
            {
                frm.ShowDialog();
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signOutToolStripMenuItem.Visible = false;
            wa.Disconnect();
            panel2.Enabled = false;
            panel1.Enabled = true;
            panel1.BringToFront();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            wa = new WhatsApp(Properties.Settings.Default.PhoneNumber, Properties.Settings.Default.Password, Properties.Settings.Default.FullName, true);

        }
    }
}
