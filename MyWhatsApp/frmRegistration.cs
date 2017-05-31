using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWhatsApp
{
    public partial class frmRegistration : Form
    {
        string password;

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbPhoneNum.Text))
            {
                MessageBox.Show("Please enter your phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbPhoneNum.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtbFullName.Text))
            {
                MessageBox.Show("Please enter your full name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbPhoneNum.Focus();
                return;
            }
            string temp = "";
            if (WhatsAppApi.Register.WhatsRegisterV2.RequestCode(txtbPhoneNum.Text, out password, out temp))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    Save();
                }
                else
                {
                    grpbRequest.Enabled = false;
                    grpbConfirm.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Could not generate password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void Save()
        {
            grpbRequest.Enabled = false;
            grpbConfirm.Enabled = false;
            Properties.Settings.Default.PhoneNumber = txtbPhoneNum.Text;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.FullName = txtbFullName.Text;
            Properties.Settings.Default.Save();

            if (Globals.DB.Accounts.FindByAccountId(txtbPhoneNum.Text) == null)
            {
                AppData.AccountsRow row = Globals.DB.Accounts.NewAccountsRow();
                row.AccountId = txtbPhoneNum.Text;
                row.FullName = txtbFullName.Text;
                row.Password = password;
                Globals.DB.Accounts.AddAccountsRow(row);
                Globals.DB.Accounts.AcceptChanges();
                Globals.DB.Accounts.WriteXml(string.Format("{0}\\\accounts.dat", Application.StartupPath));
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbSMScode.Text))
            {
                MessageBox.Show("Please enter a secure code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbSMScode.Focus();
                return;
            }
            string temp = "";
            password = WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(txtbPhoneNum.Text, txtbSMScode.Text, out temp);
            Save();

            //AppData.AccountsRow row = Globals.DB.Accounts.NewAccountsRow();
            //row.AccountId = "123456789";
            //row.FullName = "admin";
            //row.Password = "123456";
            //Globals.DB.Accounts.AddAccountsRow(row);
            //Globals.DB.Accounts.AcceptChanges();
            //Globals.DB.Accounts.WriteXml(string.Format("{0}\\accounts.dat", Application.StartupPath));



            var q = Globals.DB.Accounts.ToList();
            MessageBox.Show(q.Count.ToString());


        }
    }
}
