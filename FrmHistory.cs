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
    public partial class FrmHistory : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        DataRow dr;
        DataRow[] arRecord;
        SqlCommandBuilder clb;
        string invID = "";

        public FrmHistory()
        {
            InitializeComponent();
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            cboKategori.SelectedIndex = 0;
            BuatKoneksi();
            ds = new DataSet();
            if (ds.Tables["Transaksi"] != null) ds.Tables["Transaksi"].Clear();
            ad = new SqlDataAdapter("Select * from Penjualan", con);
            ad.Fill(ds, "Transaksi");
            Tampil();
            dgvDetail.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToAddRows = false;
            lblJumlahRec.Text = ds.Tables["Transaksi"].Rows.Count.ToString() ;
            con.Close();
        }

        private void Tampil()
        {
            
            dgvTransaksi.DataSource = ds.Tables["Transaksi"];
            dgvTransaksi.Columns[0].HeaderText = "Invoice";
            dgvTransaksi.Columns[1].HeaderText = "Tanggal & Waktu";
            dgvTransaksi.Columns[2].HeaderText = "Total Harga";
            dgvTransaksi.Columns[3].HeaderText = "Potongan";
            dgvTransaksi.Columns[4].HeaderText = "Grand Total";
            dgvTransaksi.Columns[5].HeaderText = "Dibayarkan";
            dgvTransaksi.Columns[6].HeaderText = "Kembalian";

            //Header Properties
            dgvTransaksi.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            
        }

        //Tampilkan Detail
        private void TampilDetailBarang()
        {
            BuatKoneksi();
            if (ds.Tables["DetailBarang"] != null) ds.Tables["DetailBarang"].Clear();
            ad = new SqlDataAdapter("select t1.id_barang as ID, t2.nama_barang as Nama, t1.qty_jual as Qty, t1.harga_jual as Harga, t1.sub_total as SubTotal from Penjualan_Detail t1 inner join Barang t2 on t1.id_barang = t2.id_barang where id_penjualan = '" + invID + "'", con);
            ad.Fill(ds, "DetailBarang");

            dgvDetail.DataSource = ds.Tables["DetailBarang"];
        }

        private void DgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTransaksi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvTransaksi.CurrentRow.Selected = true;
                    invID = dgvTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
                    TampilDetailBarang();
                    lblJlhJenisBarang.Text = dgvDetail.Rows.Count.ToString();

                    object sumJlhBarang;
                    sumJlhBarang = ds.Tables["DetailBarang"].Compute("Sum(Qty)", string.Empty);
                    lblJlhBarang.Text = sumJlhBarang.ToString();
                }
            }
            catch
            {

            }
        }

        private void DgvTransaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
