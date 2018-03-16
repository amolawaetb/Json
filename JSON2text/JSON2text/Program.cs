using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;

namespace Json2Text
{
    class Program
    {
        SqlConnection _con = null;
        SqlCommand _cmd = null;
        SqlDataAdapter da = null;
        DataTable dataTable = new DataTable();
        ///amol from acc
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGetJson2TextFromAppID());
        }

        public SqlConnection openConnection()
        {
            try
            {
                // Get setting from config and open connection to the database
                string _connection = ConfigurationManager.AppSettings["sqlConn"];
                string _connectionString = _connection;
                _con = new SqlConnection(_connectionString);
                _con.Open();
                return _con;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void getSubmittedAppFromAppId(string applicationID, SqlConnection _con)
        {
            var workData = String.Empty;
            var submittedData = String.Empty;

            try
            {
                if (_con.State == ConnectionState.Open)
                {
                    // Set up a command to fetch work and submitted data for given application id
                    string _commandText = "SELECT work_data, submit_data FROM [dbWssmain].[ApplyFor].[Application]" +
                                         " WHERE [application_id]= '" + applicationID + "'";
                    _cmd = new SqlCommand(_commandText);
                    _cmd.Connection = _con;

                    dataTable.Load(_cmd.ExecuteReader());

                    // Fetch the JSON from reader

                    if (dataTable.Rows[0][0] != DBNull.Value)
                    {
                        workData = Unzip((byte[])dataTable.Rows[0].ItemArray[0]);
                        ExportText(workData, "WorkData.txt");
                    }
                    else { MessageBox.Show("No Work Data Available"); }

                    if (dataTable.Rows[0][1] != DBNull.Value)
                    {
                        submittedData = Unzip((byte[])dataTable.Rows[0].ItemArray[1]);
                        ExportText(submittedData, "SubmittedData.txt");
                    }
                    else { MessageBox.Show("No Submitted Data Available"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (_con.State == ConnectionState.Open)
                    _con.Close();
            }
        }

        void ExportText(string textForFile, string fileName)
        {
            string dir = @"c:\JSON2Text\";
            string path = dir + fileName;

            bool exists = System.IO.Directory.Exists(dir);

            if (!exists)
                System.IO.Directory.CreateDirectory(dir);

            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Write(textForFile);
            }
            else if (File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Write(textForFile);
            }
        }

        public static string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    gs.CopyTo(mso);
                }

                var tmp = mso.ToArray();
                return Encoding.UTF8.GetString(tmp, 0, tmp.Length);
            }
        }

        public void successfullExport()
        {
            MessageBox.Show("JSON Data exported successfully. Check C:\\JSON2Text");
        }
    }
}
