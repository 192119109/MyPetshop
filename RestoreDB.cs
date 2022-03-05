using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class RestoreDB : Form
    {
        public RestoreDB()
        {
            InitializeComponent();
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\Data\Petshop\Backup";
            openFileDialog1.Filter = "Backup File (*.bak*)|*.bak*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName!="")
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=localhost; Integrated Security = True;");
                Server dbServer = new Server(new ServerConnection(sqlCon));
                dbServer.KillAllProcesses("db_petshop");
                Restore dbRestore = new Restore() { Database="db_petshop",Action=RestoreActionType.Database,ReplaceDatabase=true, NoRecovery=false};
                dbRestore.Devices.AddDevice($@"{textBox1.Text}", DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(dbServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error!=null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
            MessageBox.Show("Berhasil Memulihkan Database");
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });
        }

        private void RestoreDB_Load(object sender, EventArgs e)
        {
           
        }
    }
}
