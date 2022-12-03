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
    public partial class FrmReportPembelianPreview : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        int selectedIndex;
        public FrmReportPembelianPreview()
        {
            InitializeComponent();
        }

        private void FrmReportPembelianPreview_Load(object sender, EventArgs e)
        {

            BuatKoneksi();
            ds = new DataSet();
            if (ds.Tables["Pembelian"] != null) ds.Tables["Pembelian"].Clear();
            ad = new SqlDataAdapter("select t1.id_pembelian, t1.id_supplier, t2.nama as [Nama Supplier], t1.tgl_pembelian, t1.grandTotal from Pembelian t1 inner join Suppliers t2 on t1.id_supplier = t2.id_supplier Order By t1.tgl_pembelian desc", con);
            ad.Fill(ds, "Pembelian");
            con.Close();
            Tampil();

            //datagridview properties set
            dgvPembelian.ReadOnly = true;
            dgvPembelian.AllowUserToAddRows = false;
            dgvDetail.ReadOnly = true;
            dgvDetail.AllowUserToAddRows = false;

            cbFilter.SelectedIndex = 0;

            dtpFilter1.MaxDate = DateTime.Now;
            dtpFilter2.MaxDate = DateTime.Now;
            dtpFilter2.Value = DateTime.Now.Date;

            //filter date
            if (ds.Tables["Pembelian"].Rows.Count == 0)
            {
                dtpFilter1.MinDate = DateTime.Now.Date;
            }
            else
            {
                dtpFilter1.MinDate = Convert.ToDateTime(ds.Tables["Pembelian"].Rows[ds.Tables["Pembelian"].Rows.Count - 1]["tgl_pembelian"]);
            }

            dtpFilter1.Value = dtpFilter1.MinDate;

            dtpFilter2.MinDate = dtpFilter1.Value;

        }
        private void formRefresh()
        {
            BuatKoneksi();
            ds = new DataSet();
            if (ds.Tables["Pembelian"] != null) ds.Tables["Pembelian"].Clear();
            ad = new SqlDataAdapter("Select * from Pembelian Order By tgl_pembelian desc", con);
            ad.Fill(ds, "Pembelian");
            con.Close();
        }

        private void Tampil()
        {
            dgvPembelian.DataSource = ds.Tables["Pembelian"];
            dgvPembelian.Columns["grandTotal"].DefaultCellStyle.Format = "c";
        }

        private void TampilDetailPembelian()
        {
            BuatKoneksi();
            if (ds.Tables["DetailPembelian"] != null) ds.Tables["DetailPembelian"].Clear();
            ad = new SqlDataAdapter("select t1.id_pembelian, t1.id_barang, t2.nama_barang as [Nama Barang], t1.[harga/pcs], t1.subTotal, t1.Qty, t1.Catatan from Pembelian_Detail t1 inner join Barang t2 on t1.id_barang=t2.id_barang where t1.id_pembelian = '" + dgvPembelian.Rows[selectedIndex].Cells[0].Value.ToString() + "'", con);
            ad.Fill(ds, "DetailPembelian");

            dgvDetail.DataSource = ds.Tables["DetailPembelian"];
            dgvDetail.Columns[2].DefaultCellStyle.Format = "c";
            dgvDetail.Columns[3].DefaultCellStyle.Format = "c";
            con.Close();
        }
        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 1)
            {
                ds.Tables["Pembelian"].DefaultView.RowFilter = "id_supplier LIKE '%" + txtCari.Text + "%'";
            }
            else if (cbFilter.SelectedIndex == 0)
            {
                ds.Tables["Pembelian"].DefaultView.RowFilter = "id_pembelian LIKE '%" + txtCari.Text + "%'";
            }
        }
        private void DtpFilter1_ValueChanged(object sender, EventArgs e)
        {
            ds.Tables["Pembelian"].DefaultView.RowFilter = "tgl_pembelian >='" + dtpFilter1.Value.Date.ToString("d") + "' and tgl_pembelian <= '" + dtpFilter2.Value.Date.ToString("d") + " 23:59:59" + "'";
            //dtpFilter2.MinDate = dtpFilter1.Value;
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            ReportPembelianPreview reportPembelianPreview = new ReportPembelianPreview(dtpFilter1.Value, dtpFilter2.Value);
            reportPembelianPreview.ShowDialog();
        }
        private void DgvPembelian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPembelian.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvPembelian.CurrentRow.Selected = true;
                    selectedIndex = e.RowIndex;
                    TampilDetailPembelian();
                }
            }
            catch
            {

            }
        }
    }
}
