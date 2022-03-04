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
using static PetShop.Global;

namespace PetShop
{
    public partial class ProccesAnimate : Form
    {
        string date = DateTime.Now.Date.ToString("ddMMyyyy") + "_" + DateTime.Now.ToString("HHmm");
        public ProccesAnimate()
        {
            InitializeComponent();
        }

        private void ProccesAnimate_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            
            try
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=localhost; Integrated Security = True;");
                Server dbServer = new Server(new ServerConnection (sqlCon));
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = "db_petshop" };
                dbBackup.Devices.AddDevice($@"C:\Data\Petshop\Backup\db_petshop_{date}_.bak" , DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error!=null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });
            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = $"{e.Percent}%";
            });

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
                BuatKoneksi();
                cmd = new SqlCommand("insert into BackupTrackRecord Values (@tgl,@filepath)",con);
                cmd.Parameters.AddWithValue("@tgl", DateTime.Now);
                cmd.Parameters.AddWithValue("@filepath", $@"C:\Data\Petshop\Backup\db_petshop_{date}_.bak");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil mencadangkan data");
                this.Close();
            }
            
        }
    }
}
