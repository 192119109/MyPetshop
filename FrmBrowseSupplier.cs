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
    public partial class FrmBrowseSupplier : Form
    {

        DataSet ds;
        SqlDataAdapter ad;

        public FrmBrowseSupplier()
        {
            InitializeComponent();
        }

        private void FrmBrowseSupplier_Load(object sender, EventArgs e)
        {
            BuatKoneksi();
            ds = new DataSet();
            if (ds.Tables["Barang"] != null) ds.Tables["Suppliers"].Clear();
            ad = new SqlDataAdapter("select * from Suppliers", con);
            ad.Fill(ds, "Suppliers");
            Tampil();
            cboKategori.SelectedIndex = 0;
            con.Close();
        }

        private void Tampil()
        {
            dgvSupplier.DataSource = ds.Tables["Suppliers"];
            //dgvSupplier.Columns["harga_jual"].DefaultCellStyle.Format = "c";
            //dgvSupplier.Columns["harga_beli"].DefaultCellStyle.Format = "c";
            //dgvSupplier.Columns[0].HeaderText = "Id Barang";
            //dgvSupplier.Columns[1].HeaderText = "Nama Barang";
            //dgvSupplier.Columns[2].HeaderText = "Qty";
            //dgvSupplier.Columns[3].HeaderText = "Harga Jual";
            //dgvSupplier.Columns[4].HeaderText = "Harga Beli";
            //dgvSupplier.Columns[5].HeaderText = "Barcode";
            dgvSupplier.ReadOnly = true;
            dgvSupplier.AllowUserToAddRows = false;
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            if (cboKategori.SelectedIndex == 1)
            {
                ds.Tables["Suppliers"].DefaultView.RowFilter = "nama LIKE '%" + txtCari.Text + "%'";
            }
            else if (cboKategori.SelectedIndex == 0)
            {
                ds.Tables["Suppliers"].DefaultView.RowFilter = "id_supplier LIKE '%" + txtCari.Text + "%'";
            }
        }

        private void DgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSupplier.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvSupplier.CurrentRow.Selected = true;
                    Global.getIdSup= dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Global.getNamaSup = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.Close();
                }
            }
            catch
            {

            }
        }
    }
}
