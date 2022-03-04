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
            ad = new SqlDataAdapter("Select * from Penjualan order by tgl_transaksi asc", con);
            ad.Fill(ds, "Transaksi");
            Tampil();
            dgvDetail.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToAddRows = false;
            lblJumlahRec.Text = ds.Tables["Transaksi"].Rows.Count.ToString() ;
            dgvDetail.ReadOnly = true;
            con.Close();
            dtpFilter1.MaxDate = DateTime.Now.Date;
            dtpFilter2.MaxDate = DateTime.Now.Date;
            dtpFilter2.Value = DateTime.Now.Date;

            //filter date
            dtpFilter1.MinDate = Convert.ToDateTime(ds.Tables["Transaksi"].Rows[0]["tgl_transaksi"].ToString());
            dtpFilter1.Value = dtpFilter1.MinDate;

            dtpFilter2.MinDate = dtpFilter1.Value;
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
            for (int i = 2; i <= 6; i++)
            {
                dgvTransaksi.Columns[i].DefaultCellStyle.Format = "c";
            }
            //Header Properties
            dgvTransaksi.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            
        }

        //Tampilkan Detail
        private void TampilDetailBarang()
        {
            BuatKoneksi();
            if (ds.Tables["DetailBarang"] != null) ds.Tables["DetailBarang"].Clear();
            ad = new SqlDataAdapter("select t1.id_barang as ID, t2.nama_barang as Nama, sum(t1.qty_jual) as Qty, t1.harga_jual as Harga, t1.sub_total as SubTotal from Penjualan_Detail t1 inner join Barang t2 on t1.id_barang = t2.id_barang where id_penjualan = '" + invID + "' group by t1.id_barang,t2.nama_barang,t1.harga_jual,t1.sub_total", con);
            ad.Fill(ds, "DetailBarang");

            dgvDetail.DataSource = ds.Tables["DetailBarang"];
            dgvDetail.Columns[3].DefaultCellStyle.Format = "c";
            dgvDetail.Columns[4].DefaultCellStyle.Format = "c";
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

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["Transaksi"].DefaultView.RowFilter = "id_penjualan LIKE '%" + txtCari.Text + "%'";
            lblJumlahRec.Text = dgvTransaksi.Rows.Count.ToString();
        }

        private void DtpFilter1_ValueChanged(object sender, EventArgs e)
        {
            ds.Tables["Transaksi"].DefaultView.RowFilter = "tgl_transaksi >='" + dtpFilter1.Value.Date.ToString("d")  + "' and tgl_transaksi <= '" + dtpFilter2.Value.Date.ToString("d") + " 23:59:59" + "'";
            dtpFilter2.MinDate = dtpFilter1.Value;
            lblJumlahRec.Text = dgvTransaksi.Rows.Count.ToString();
        }
    }
}
