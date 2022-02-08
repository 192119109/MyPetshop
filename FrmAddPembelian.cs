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
    public partial class FrmAddPembelian : Form
    {
        DataSet ds;
        DataTable dt;
        DataRow dr;
        string idPembelian="";

        public FrmAddPembelian()
        {
            InitializeComponent();
        }

        private void BtnBrowseSupplier_Click(object sender, EventArgs e)
        {
            FrmBrowseSupplier browseSupplier = new FrmBrowseSupplier();
            browseSupplier.ShowDialog();

            if(Global.getIdSup!=""&&Global.getNamaSup!="")
            {
                txtIdSupplier.Text = Global.getIdSup;
                txtNamaSupplier.Text = Global.getNamaSup;

                Global.getIdSup = "";
                Global.getNamaSup = "";
            }
            
        }

        private void Tampil()
        {
            if (dgvPembelian.Rows.Count > 1)
            {
                btnBrowseSupplier.Enabled = false;
            }
            else
            {
                btnBrowseSupplier.Enabled = true;
            }

            dgvPembelian.DataSource = ds.Tables["Pembelian"];
            ValidasiBtnSimpan();
        }
        private void ValidasiBtnSimpan()
        {
            if (ds.Tables["Pembelian"].Rows.Count < 1)
            {
                btnSimpan.Enabled = false;
            }
            else
            {
                btnSimpan.Enabled = true;
            }
        }

        private void BtnBrowseBarang_Click(object sender, EventArgs e)
        {
            FrmBrowseBarang browseBarang = new FrmBrowseBarang();
            browseBarang.ShowDialog();

            if (Global.getNamaBrg != "" && Global.getIdBrg!= "")
            {
                txtIdBarang.Text = Global.getIdBrg;
                txtNamaBarang.Text = Global.getNamaBrg;

                Global.getIdBrg = "";
                Global.getNamaBrg = "";
            }
        }

        private void TxtIdSupplier_TextChanged(object sender, EventArgs e)
        {
            if(txtIdSupplier.Text==""||txtIdSupplier.Text==null)
            {
                btnBrowseBarang.Enabled = false;
            }
            else
            {
                btnBrowseBarang.Enabled = true;
            }
            ValidasiBtnTambah();
           
        }

        private void GetIdPembelian()
        {
            BuatKoneksi();
            cmd = new SqlCommand("SELECT TOP 1 id_pembelian FROM Pembelian ORDER BY tgl_pembelian DESC", con);
            var maxId = cmd.ExecuteScalar() as string;

            if (maxId == null || Convert.ToInt32(DateTime.Now.ToString("MM")) != int.Parse(maxId.Substring(12, 2)))
            {
                idPembelian = "PB000001/" + DateTime.Now.Date.ToString("dd/MM/yyyy");
                txtIdPembelian.Text = idPembelian.ToString();
            }
            else
            {
                int intval = int.Parse(maxId.Substring(2, 6));
                intval++;
                idPembelian = String.Format("PB{0:000000}", intval) + "/" + DateTime.Now.ToString("dd/MM/yyyy");
                txtIdPembelian.Text = idPembelian;
            }
            con.Close();
        }


        private void FrmAddPembelian_Load(object sender, EventArgs e)
        {
            GetIdPembelian();
            btnBrowseBarang.Enabled = false;
            ds = new DataSet();
            dt = new DataTable("Pembelian");
            dt.Columns.Add(new DataColumn("id_pembelian", typeof(string)));
            dt.Columns.Add(new DataColumn("id_supplier", typeof(string)));
            dt.Columns.Add(new DataColumn("id_barang", typeof(string)));
            dt.Columns.Add(new DataColumn("qty", typeof(string)));
            dt.Columns.Add(new DataColumn("harga/pcs", typeof(string)));
            dt.Columns.Add(new DataColumn("total", typeof(string)));
            dt.Columns.Add(new DataColumn("catatan", typeof(string)));
            ds.Tables.Add(dt);
            if (ds.Tables["Pembelian"] != null) ds.Tables["Pembelian"].Clear();
            ValidasiBtnSimpan();
            btnTambah.Enabled = false;
            btnHapus.Enabled = false;
            btnUbah.Enabled = false;
            nudHarga.Maximum = ulong.MaxValue;
            nudHarga.Minimum = 0;
            nudQty.Minimum = 0;
            nudQty.Maximum = int.MaxValue;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            dr = ds.Tables["Pembelian"].NewRow();
            dr["id_pembelian"] = txtIdPembelian.Text;
            dr["id_supplier"] = txtIdSupplier.Text;
            dr["id_barang"] = txtIdBarang.Text;
            dr["qty"] = nudQty.Value;
            dr["harga/pcs"] = nudHarga.Value;
            dr["total"] = (nudHarga.Value * nudQty.Value);
            dr["catatan"] = txtCatatan.Text;
            ds.Tables["Pembelian"].Rows.Add(dr);
            Tampil();

        }

        private void ValidasiBtnTambah()
        {
            if (txtIdSupplier.Text == "" || txtIdSupplier.Text == null || txtIdBarang.Text == "" || txtIdBarang == null)
            {
                btnTambah.Enabled = false;
            }
            else
            {
                btnTambah.Enabled = true;
            }
        }

        private void TxtIdBarang_TextChanged(object sender, EventArgs e)
        {
            ValidasiBtnTambah();
        }
    }
}
