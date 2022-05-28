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
using Microsoft.Reporting.WinForms;

namespace PetShop
{
    public partial class rptReceiptPreview : Form
    {
        SqlDataAdapter ad;
        
        public rptReceiptPreview()
        {
            InitializeComponent();
        }

        private void RptReceiptPreview_Load(object sender, EventArgs e)
        {
            BuatKoneksi();
            ad = new SqlDataAdapter("select t1.id_penjualan,t1.tgl_transaksi,t1.total_harga,t1.potongan,t1.grand_total," +
                "t1.dibayarkan,t1.kembalian,t2.id_barang, t3.nama_barang, sum(t2.qty_jual) as Qty, t2.harga_jual as Harga, " +
                "t2.sub_total as SubTotal from Penjualan t1 inner join Penjualan_Detail t2 on t1.id_penjualan= t2.id_penjualan " +
                "inner join Barang t3 ON t2.id_barang=t3.id_barang where t1.id_penjualan = '"+ receiptInv + "' group by t1.id_penjualan, " +
                "t1.tgl_transaksi,t1.total_harga,t1.potongan,t1.grand_total,t1.dibayarkan,t1.kembalian,t2.id_barang,t3.nama_barang,t2.harga_jual," +
                "t2.sub_total",con);
            db_petshopReceipt ds = new db_petshopReceipt();
            ad.Fill(ds, "DataTable1");
            ReportDataSource dataSource = new ReportDataSource("ds_Receipt",ds.Tables[0]);
            this.rptReceipt.LocalReport.DataSources.Clear();
            this.rptReceipt.LocalReport.DataSources.Add(dataSource);
            this.rptReceipt.RefreshReport();
        }
    }
}
