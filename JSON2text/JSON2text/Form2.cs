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
    public partial class frmJson2TextFromEmail : Form
    {
        SqlConnection _con = null;
        SqlCommand _cmd = null;
        SqlDataAdapter da = null;
        Program myProgram = new Program();

        public frmJson2TextFromEmail()
        {
            InitializeComponent();
        }

        private void btnGetSubmittedApps_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmail.Text))
            {
                try
                {
                    _con = myProgram.openConnection();

                    // Set up a command to fetch data
                    string _commandText = "SELECT [application_id],[date_started],APP.[la_date_time] FROM [dbWssmain].[ApplyFor].[Application] APP " +
                                          "JOIN [dbWssmain].[dbo].[Online_User_Profile] OUP ON APP.[online_profile_id] = OUP.[online_profile_id] " +
                                          "WHERE [email]='" + txtEmail.Text + "'";
                    _cmd = new SqlCommand(_commandText);
                    _cmd.Connection = _con;

                    da = new SqlDataAdapter(_cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No applications found for given Email Id");
                    }
                    else
                    {
                        BindGrid(ds);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Supervisor/Chairperson Email ID cannot be null");
            }
        }

        private void BindGrid(DataSet ds)
        {
            var count = ds.Tables[0].Rows[0][0];

            //Set AutoGenerateColumns False
            dgvWPSubmittedApplication.AutoGenerateColumns = false;

            //Set Columns Count
            dgvWPSubmittedApplication.ColumnCount = 3;

            //Add Columns
            dgvWPSubmittedApplication.Columns[0].Name = "application_id";
            dgvWPSubmittedApplication.Columns[0].HeaderText = "Application ID";
            dgvWPSubmittedApplication.Columns[0].DataPropertyName = "application_id";
            dgvWPSubmittedApplication.Columns[0].Width = 225;

            dgvWPSubmittedApplication.Columns[1].HeaderText = "Date Started";
            dgvWPSubmittedApplication.Columns[1].Name = "date_started ";
            dgvWPSubmittedApplication.Columns[1].DataPropertyName = "date_started";
            dgvWPSubmittedApplication.Columns[1].Width = 100;

            dgvWPSubmittedApplication.Columns[2].Name = "la_date_time";
            dgvWPSubmittedApplication.Columns[2].HeaderText = "LA Date Time";
            dgvWPSubmittedApplication.Columns[2].DataPropertyName = "la_date_time";
            dgvWPSubmittedApplication.Columns[2].Width = 100;

            var buttonCol = new DataGridViewButtonColumn();
            buttonCol.Name = "GetJson";
            buttonCol.HeaderText = "Get Json";
            buttonCol.Text = "Get Json";
            dgvWPSubmittedApplication.Columns.Add(buttonCol);
            dgvWPSubmittedApplication.Columns[3].Width = 100;

            dgvWPSubmittedApplication.DataSource = ds.Tables[0];

            this.Controls.Add(dgvWPSubmittedApplication);
            dgvWPSubmittedApplication.Show();
            dgvWPSubmittedApplication.Visible = true;
        }

        private void dgvWPSubmittedApplication_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                myProgram.getSubmittedAppFromAppId(dgvWPSubmittedApplication[0, e.RowIndex].Value.ToString(), _con);
                myProgram.successfullExport();
                this.Close();
                Application.Exit();
            }
        }
    }
}
