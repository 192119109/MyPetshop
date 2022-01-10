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

    public partial class FrmCari : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        DataRow dr;
        DataRow[] arRecord;
        SqlCommandBuilder clb;

        public FrmCari()
        {
            InitializeComponent();
        }

        private void Tampil()
        {
            dgvBarang.DataSource = ds.Tables["Barang"];
            dgvBarang.Columns["harga_jual"].DefaultCellStyle.Format = "c";
            dgvBarang.Columns[0].HeaderText = "Id Barang";
            dgvBarang.Columns[1].HeaderText = "Nama Barang";
            dgvBarang.Columns[2].HeaderText = "Qty";
            dgvBarang.Columns[3].HeaderText = "Harga";
            dgvBarang.Columns[4].HeaderText = "Barcode";
            dgvBarang.ReadOnly = true;
            dgvBarang.AllowUserToAddRows = false;
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            if (ds.Tables["Barang"] != null) ds.Tables["Barang"].Clear();
            ad = new SqlDataAdapter("select id_barang, nama_barang, qty, harga_jual, barcode from Barang where qty>0", con);
            ad.Fill(ds, "Barang"); BuatKoneksi();
            Tampil();
            cbSearchBy.SelectedIndex = 1;
        }

        private void DgvBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBarang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBarang.CurrentRow.Selected = true;
                    Global.getBarcode = dgvBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.Close();
                }
            }
            catch
            {

            }

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(cbSearchBy.SelectedIndex==1)
            {
                ds.Tables["Barang"].DefaultView.RowFilter = "nama_barang LIKE '%" + txtSearch.Text + "%'";
            }
            else if (cbSearchBy.SelectedIndex == 0)
            {
                ds.Tables["Barang"].DefaultView.RowFilter = "id_barang LIKE '%" + txtSearch.Text + "%'";
            }
            
        }
        private void MuatUlang()
        {
            ds.Tables["Barang"].Clear();
            ad.Fill(ds, "Barang");

        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            MuatUlang();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void DgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBarang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBarang.CurrentRow.Selected = true;
                }
            }
            catch
            {

            }
        }
    }
}
