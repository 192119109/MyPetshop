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
    public partial class InputBarang : Form
    {
        DataSet ds;
        DataRow dr;
        DataRow[] arrRow;
        SqlDataAdapter ad;
        DataColumn[] dc;
        SqlCommandBuilder clb;
        DataTable dt;


        public InputBarang()
        {
            InitializeComponent();
        }

        private void InputBarang_Load(object sender, EventArgs e)
        {
            nudQty.Minimum = 0;
            ds = new DataSet();
            dt = new DataTable("Barang");
            dt.Columns.Add(new DataColumn("id_barang", typeof(string)));
            dt.Columns.Add(new DataColumn("nama_barang", typeof(string)));
            dt.Columns.Add(new DataColumn("qty", typeof(int)));
            dt.Columns.Add(new DataColumn("harga_beli", typeof(string)));
            dt.Columns.Add(new DataColumn("harga_jual", typeof(string)));
            dt.Columns.Add(new DataColumn("barcode", typeof(string)));
            ds.Tables.Add(dt);
            if (ds.Tables["Barang"] != null) ds.Tables["Barang"].Clear();
            Tampil();
            dgvBarang.ReadOnly = true;
        }

        private void Tampil()
        {
            //dgvBarang.ColumnCount = 6;

            dgvBarang.DataSource = ds.Tables["Barang"];
            //dgvBarang.Columns[0].HeaderText = "Id Barang";
            //dgvBarang.Columns[1].HeaderText = "Nama Barang";
            //dgvBarang.Columns[2].HeaderText = "Qty";
            //dgvBarang.Columns[3].HeaderText = "Harga Beli";
            //dgvBarang.Columns[4].HeaderText = "Harga Jual";
            //dgvBarang.Columns[5].HeaderText = "Barcode";
            //dgvBarang.Rows.Clear();

            //foreach (DataRow dr in ds.Tables["Barang"].Rows)
            //{
            //    dgvBarang.Rows.Add(dr["id_barang"], dr["nama_barang"], dr["qty"], dr["harga_beli"], dr["harga_jual"], dr["barcode"]);
            //}

        }

        private void Reset()
        {
            txtBarcode.Clear();
            txtHargaBeli.Clear();
            txtHargaJual.Clear();
            txtIdBrg.Clear();
            txtNamaBarang.Clear();
            nudQty.Value = 0;
            txtIdBrg.Focus();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            dr = ds.Tables["Barang"].NewRow();
            dr["id_barang"] = txtIdBrg.Text;
            dr["nama_barang"] = txtNamaBarang.Text;
            dr["qty"] = nudQty.Value;
            dr["harga_beli"] = txtHargaBeli.Text;
            dr["harga_jual"] = txtHargaJual.Text;
            dr["barcode"] = txtBarcode.Text;
            ds.Tables["Barang"].Rows.Add(dr);

            //dgvBarang.ReadOnly = false;
            //dr = ds.Tables["Barang"].NewRow();
            //dr = dt.NewRow();
            //dr["id_barang"] = txtIdBrg.Text;
            //dr["nama_barang"] = txtNamaBarang.Text;
            //dr["qty"] = nudQty.Value;
            //dr["harga_beli"] = txtHargaBeli.Text;
            //dr["harga_jual"] = txtHargaJual.Text;
            //dr["barcode"] = txtBarcode.Text;
            //dt.Rows.Add(dr);
            //ds.Tables["Barang"].Rows.Add(dt);
            //dgvBarang.ReadOnly = true;

            Reset();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            BuatKoneksi();
            ad = new SqlDataAdapter("Select * from barang",con);
            clb = new SqlCommandBuilder(ad);
            ad = clb.DataAdapter;
            ad.Update(ds, "Barang");
            MessageBox.Show("Data Berhasil Disimpan");
            this.Close();

        }
    }
}
