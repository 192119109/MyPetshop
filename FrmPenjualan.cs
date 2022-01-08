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
    public partial class FrmPenjualan : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        DataRow dr;
        DataRow[] arRecord;
        SqlCommandBuilder clb;
        public FrmPenjualan()
        {
            InitializeComponent();
        }

        private void FrmPenjualan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void TxtQty2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FrmPenjualan_Load(object sender, EventArgs e)
        {
            BuatKoneksi();
            ds = new DataSet();
            if (ds.Tables["Barang"] != null) ds.Tables["Barang"].Clear();
            ad = new SqlDataAdapter("select * from Barang", con);
            ad.Fill(ds, "Barang");
            DataTable dt = new DataTable("CheckoutItem");
            dt.Columns.Add(new DataColumn("ID Barang", typeof(string)));
            dt.Columns.Add(new DataColumn("Nama Barang", typeof(string)));
            dt.Columns.Add(new DataColumn("Qty", typeof(int)));
            //dt.Columns.Add(new DataColumn("harga_beli", typeof(string)));
            dt.Columns.Add(new DataColumn("Harga", typeof(string)));
            //dt.Columns.Add(new DataColumn("barcode", typeof(string)));
            ds.Tables.Add(dt);
            nudQty.Minimum = 1;
            nudQty.Value = 1;
        }

        private void Tampil()
        {
            dgvCheckoutItem.DataSource = ds.Tables["CheckoutItem"];
        }

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                arRecord = ds.Tables["Barang"].Select("barcode='" + txtBarcode.Text + "'");
                if(arRecord.Length!=0)
                {
                    dr = ds.Tables["CheckoutItem"].NewRow();
                    dr["ID Barang"] = arRecord[0]["id_barang"];
                    dr["Nama Barang"] = arRecord[0]["nama_barang"];
                    dr["Qty"] = nudQty.Value;
                    dr["Harga"] = arRecord[0]["harga_jual"];
                    ds.Tables["CheckoutItem"].Rows.Add(dr);
                    Tampil();
                }
                else
                {
                    MessageBox.Show("Produk tidak ditemukan");
                }
            }
        }
    }
}
