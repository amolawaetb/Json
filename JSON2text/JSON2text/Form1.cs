using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json2Text
{
    public partial class frmGetJson2TextFromAppID : Form
    {
        public frmGetJson2TextFromAppID()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetJson_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtWPApplicationID.Text))
            {
                var myProgram = new Program();
                SqlConnection _con = myProgram.openConnection();
                myProgram.getSubmittedAppFromAppId(txtWPApplicationID.Text, _con);
                myProgram.successfullExport();
                this.Close();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("WP Application ID cannot be null");
            }
        }

        private void lnkGetAppFromEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var submittedApps = new frmJson2TextFromEmail();
            submittedApps.Show();
            this.Hide();
        }
    }
}
