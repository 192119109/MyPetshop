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
    public partial class FrmReportPenguranganBarangPreview : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        public FrmReportPenguranganBarangPreview()
        {
            InitializeComponent();
        }

        private void FrmReportPenguranganBarangPreview_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            TampilHistoryPengurangan();
            setDataGridView();
            string startDate = $"01/01/{DateTime.Now.Year}";
            dtpStartDate.Value = Convert.ToDateTime(startDate);
            dtpEndDate.Value = DateTime.Now;
            cbSearchBy.SelectedIndex = 0;
        }
        private void TampilHistoryPengurangan()
        {
            BuatKoneksi();
            if (ds.Tables["Pengurangan"] != null) ds.Tables["Pengurangan"].Clear();
            ad = new SqlDataAdapter("select t1.id_pengurangan, t1.id_barang, t2.nama_barang, t1.id_pembelian," +
                " t3.id_supplier, t4.nama as nama_supplier, t1.tglPengurangan, t1.qtyAwal, t1. qtyAkhir,t1.jlhPengurangan, " +
                "t1.Keterangan from Pengurangan_Stock t1 inner join Barang t2 on t1.id_barang = t2.id_barang inner join Pembelian t3 " +
                "on t1.id_pembelian=t3.id_pembelian inner join Suppliers t4 on t3.id_supplier=t4.id_supplier order by t1.tglPengurangan DESC", con);
            ad.Fill(ds, "Pengurangan");
            con.Close();
        }

        private void setDataGridView()
        {
            dgvHistoryPengurangan.DataSource = ds.Tables["Pengurangan"];
            dgvHistoryPengurangan.Columns[0].HeaderText = "ID Pengurangan";
            dgvHistoryPengurangan.Columns[1].HeaderText = "ID Barang";
            dgvHistoryPengurangan.Columns[2].HeaderText = "Nama Barang";
            dgvHistoryPengurangan.Columns[3].HeaderText = "ID Pembelian";
            dgvHistoryPengurangan.Columns[4].HeaderText = "ID Supplier";
            dgvHistoryPengurangan.Columns[5].HeaderText = "Nama Supplier";
            dgvHistoryPengurangan.Columns[6].HeaderText = "Tgl Pengurangan";
            dgvHistoryPengurangan.Columns[7].HeaderText = "Qty Awal";
            dgvHistoryPengurangan.Columns[8].HeaderText = "Qty Akhir";
            dgvHistoryPengurangan.Columns[9].HeaderText = "Jumlah Pengurangan";
            dgvHistoryPengurangan.Columns[10].HeaderText = "Keterangan";
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterBy = "";
            switch (cbSearchBy.SelectedIndex)
            {
                case 0: FilterBy = "id_pengurangan"; break;
                case 1: FilterBy = "id_barang"; break;
                case 2: FilterBy = "id_pembelian"; break;
                case 3: FilterBy = "nama_barang"; break;
                case 4: FilterBy = "nama_supplier"; break;
                default: FilterBy = ""; break;
            }

            ds.Tables["Pengurangan"].DefaultView.RowFilter = $"{FilterBy} LIKE '%" + txtSearch.Text + "%'";
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            ds.Tables["Pengurangan"].DefaultView.RowFilter = $" tglPengurangan >= '{dtpStartDate.Value}' AND tglPengurangan<='{dtpEndDate.Value}'";
        }
    }
}
