using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace PetShop
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }


        private void LblTutupApps_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
        }

        private void LblTutupApps_MouseEnter(object sender, EventArgs e)
        {
            lblTutupApps.Font = new Font("Microsoft YaHei", 22);
        }

        private void LblTutupApps_MouseLeave(object sender, EventArgs e)
        {
            lblTutupApps.Font = new Font("Microsoft YaHei", 20);
        }

        private void BtnPenjualan_MouseEnter(object sender, EventArgs e)
        {
            btnPenjualan.Text = "Penjualan";
            btnPenjualan.Font = new Font("Mircorsoft YaHei", 25, FontStyle.Bold);
            btnPenjualan.BackgroundImage = Properties.Resources.trade_blur;
            btnPenjualan.ForeColor = Color.CornflowerBlue;
        }

        private void BtnPenjualan_MouseLeave(object sender, EventArgs e)
        {
            btnPenjualan.Text = "";
            btnPenjualan.BackgroundImage = Properties.Resources.trade;
        }

        private void BtnPersediaan_MouseEnter(object sender, EventArgs e)
        {
            btnPersediaan.Text = "Persediaan";
            btnPersediaan.Font = new Font("Mircorsoft YaHei", 25, FontStyle.Bold);
            btnPersediaan.BackgroundImage = Properties.Resources.inventory_blur;
            btnPersediaan.ForeColor = Color.SpringGreen;
        }

        private void BtnPersediaan_MouseLeave(object sender, EventArgs e)
        {
            btnPersediaan.Text = "";
            btnPersediaan.BackgroundImage = Properties.Resources.inventory;
        }

        private void BtnBiayaTambahan_MouseEnter(object sender, EventArgs e)
        {
            btnBiayaTambahan.Text = "Biaya Lainnya";
            btnBiayaTambahan.Font = new Font("Mircorsoft YaHei", 25, FontStyle.Bold);
            btnBiayaTambahan.BackgroundImage = Properties.Resources.budget_blur;
            btnBiayaTambahan.ForeColor = Color.Tomato;
        }

        private void BtnBiayaTambahan_MouseLeave(object sender, EventArgs e)
        {
            btnBiayaTambahan.Text = "";
            btnBiayaTambahan.BackgroundImage = Properties.Resources.budget;
        }

        private void BtnLaporan_MouseEnter(object sender, EventArgs e)
        {
            btnLaporan.Text = "Laporan";
            btnLaporan.Font = new Font("Mircorsoft YaHei", 25, FontStyle.Bold);
            btnLaporan.BackgroundImage = Properties.Resources.report_blur;
            btnLaporan.ForeColor = Color.BlueViolet;
        }

        private void BtnLaporan_MouseLeave(object sender, EventArgs e)
        {
            btnLaporan.Text = "";
            btnLaporan.BackgroundImage = Properties.Resources.report;
        }

        private void BtnAccount_MouseEnter(object sender, EventArgs e)
        {
            btnAccount.Text = "Akun";
            btnAccount.Font = new Font("Mircorsoft YaHei", 25, FontStyle.Bold);
            btnAccount.BackgroundImage = Properties.Resources.account_blur;
            btnAccount.ForeColor = Color.Black;
        }

        private void BtnAccount_MouseLeave(object sender, EventArgs e)
        {
            btnAccount.Text = "";
            btnAccount.BackgroundImage = Properties.Resources.account;
        }

        private void LblBantuan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form frmBantuan = new FrmBantuan();

            //frmBantuan.ShowDialog();
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Help.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, global::PetShop.Properties.Resources.Help);//the resource automatically creates            
            System.Diagnostics.Process.Start(openPDFFile);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.White;
            btnLaporan.BackColor = Color.White;
            btnPenjualan.BackColor = Color.White;
            btnPersediaan.BackColor = Color.White;
            btnBiayaTambahan.BackColor = Color.White;
            btnSupplier.BackColor = Color.White;
            btnManageData.BackColor = Color.White;
            btnManageUser.BackColor = Color.White;

            if (Global.statusUser != "superadmin")
            {
                btnManageUser.Hide();
            }
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            FrmAkun frmAkun = new FrmAkun();
            frmAkun.Show();
            this.Hide();
        }

        private void BtnPenjualan_Click(object sender, EventArgs e)
        {
            FrmPenjualan frmPenjualan= new FrmPenjualan();
            frmPenjualan.Show();
            this.Hide();
        }

        private void BtnPersediaan_Click(object sender, EventArgs e)
        {
            FrmStock frmStock = new FrmStock();
            frmStock.Show();
            this.Hide();
        }

        private void BtnLaporan_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.Show();
            this.Hide();
        }

        private void BtnSupplier_MouseEnter(object sender, EventArgs e)
        {
            btnSupplier.Text = "Supplier";
            btnSupplier.Font = new Font("Mircorsoft YaHei", 25, FontStyle.Bold);
            btnSupplier.BackgroundImage = Properties.Resources.supplier_blur;
            btnSupplier.ForeColor = Color.Navy;
        }

        private void BtnSupplier_MouseLeave(object sender, EventArgs e)
        {
            btnSupplier.Text = "";
            btnSupplier.BackgroundImage = Properties.Resources.supplier;
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplier frmSupplier = new FrmSupplier();
            frmSupplier.Show();
            this.Hide();
        }

        private void BtnManageData_MouseLeave(object sender, EventArgs e)
        {
            btnManageData.Text = "";
            btnManageData.BackgroundImage = Properties.Resources.backup_file;
        }

        private void BtnManageData_MouseEnter(object sender, EventArgs e)
        {
            btnManageData.Text = "Kelola Database";
            btnManageData.Font = new Font("Mircorsoft YaHei", 25, FontStyle.Bold);
            btnManageData.BackgroundImage = Properties.Resources.backup_file_blur;
            btnManageData.ForeColor = Color.DarkOrange;
        }

        private void BtnManageData_Click(object sender, EventArgs e)
        {
            FrmBackupData frmBackupDB = new FrmBackupData();
            frmBackupDB.Show();
            this.Hide();
        }

        private void BtnManageUser_Click(object sender, EventArgs e)
        {
            FrmManageUser frmuser = new FrmManageUser();
            frmuser.Show();
            this.Hide();
        }

        private void BtnManageUser_MouseEnter(object sender, EventArgs e)
        {
            btnManageUser.Text = "Kelola Pengguna";
            btnManageUser.Font = new Font("Mircorsoft YaHei", 25, FontStyle.Bold);
            btnManageUser.BackgroundImage = Properties.Resources.user_blur;
            btnManageUser.ForeColor = Color.PaleVioletRed;
        }

        private void BtnManageUser_MouseLeave(object sender, EventArgs e)
        {
            btnManageUser.Text = "";
            btnManageUser.BackgroundImage = Properties.Resources.user;
        }

        private void BtnBiayaTambahan_Click(object sender, EventArgs e)
        {
            FrmBiayaTambahan frmBiayaTambahan = new FrmBiayaTambahan();
            frmBiayaTambahan.Show();
            this.Hide();
        }
    }
}
