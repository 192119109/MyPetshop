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
    public partial class FrmBrowseBarang : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        public FrmBrowseBarang()
        {
            InitializeComponent();
        }

        private void FrmBrowseBarang_Load(object sender, EventArgs e)
        {
            BuatKoneksi();
            ds = new DataSet();
            if (ds.Tables["Barang"] != null) ds.Tables["Barang"].Clear();
            ad = new SqlDataAdapter("select id_barang, nama_barang, harga_jual,barcode,deskripsi from Barang where discontinued=0", con);
            ad.Fill(ds, "Barang");
            Tampil();
            cboKategori.SelectedIndex = 0;
            txtCari.Focus();
        }

        private void Tampil()
        {
            dgvBarang.DataSource = ds.Tables["Barang"];
            dgvBarang.Columns["harga_jual"].DefaultCellStyle.Format = "c";
            dgvBarang.Columns[0].HeaderText = "Id Barang";
            dgvBarang.Columns[1].HeaderText = "Nama Barang";
            dgvBarang.Columns[2].HeaderText = "Harga Jual";
            dgvBarang.Columns[3].HeaderText = "Barcode";
            dgvBarang.Columns[4].HeaderText = "Deskripsi";
            dgvBarang.ReadOnly = true;
            dgvBarang.AllowUserToAddRows = false;
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            if (cboKategori.SelectedIndex == 1)
            {
                ds.Tables["Barang"].DefaultView.RowFilter = "nama_barang LIKE '%" + txtCari.Text + "%'";
            }
            else if (cboKategori.SelectedIndex == 0)
            {
                ds.Tables["Barang"].DefaultView.RowFilter = "id_barang LIKE '%" + txtCari.Text + "%'";
            }
        }

        private void DgvBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBarang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBarang.CurrentRow.Selected = true;
                    Global.getIdBrg = dgvBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Global.getNamaBrg = dgvBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.Close();
                }
            }
            catch
            {

            }
        }
    }
}
