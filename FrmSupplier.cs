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
    public partial class FrmSupplier : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu mainMenu = new FrmMenu();
            mainMenu.Show();
        }

        private void BtnNewStock_Click(object sender, EventArgs e)
        {
            FrmAddSup frmInputSupplier = new FrmAddSup();
            frmInputSupplier.ShowDialog();
            RefreshData();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            BuatKoneksi();
            ds = new DataSet();
            RefreshData();
        }

        private void tampil()
        {
            dgvSupplier.DataSource = ds.Tables["Suppliers"];
        }

        private void RefreshData()
        {
            if (ds.Tables["Suppliers"] != null) ds.Tables["Suppliers"].Clear();
            ad = new SqlDataAdapter("select * from Suppliers", con);
            ad.Fill(ds, "Suppliers");
            tampil();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
