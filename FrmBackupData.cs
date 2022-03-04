using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PetShop.Global;
using System.Data.SqlClient;


namespace PetShop
{
    public partial class FrmBackupData : Form
    {
        SqlDataReader reader;
        public FrmBackupData()
        {
            InitializeComponent();
        }

        private void FrmBackupData_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu mainMenu = new FrmMenu();
            mainMenu.Show();
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin mencadangkan database?", this.Text, MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProccesAnimate prosesBackup = new ProccesAnimate();
                prosesBackup.ShowDialog();
                refreshForm();
            }
        }

        private void refreshForm ()
        {
            BuatKoneksi();
            cmd = new SqlCommand("select Top 1 tgl_backup, file_path from BackupTrackRecord order by tgl_backup DESC", con);
            reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                lblLastBackup.Text = reader["tgl_backup"].ToString();
                lblPath.Text = reader["file_path"].ToString();
            }
            con.Close();
        }

        private void FrmBackupData_Load(object sender, EventArgs e)
        {
            refreshForm();
        }
    }
}
