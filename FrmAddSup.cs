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
    public partial class FrmAddSup : Form
    {
        string supID;
        SqlCommand cmd;
        DataRow dr;
        DataRow[] arrRow;
        SqlDataAdapter ad;
        DataColumn[] dc;
        SqlCommandBuilder clb;
        DataTable dt;
        DataSet ds;
        public FrmAddSup()
        {
            InitializeComponent();
        }

        private void FrmAddSup_Load(object sender, EventArgs e)
        {
            GetSupplierID();
            ds = new DataSet();
            dt = new DataTable("Suppliers");
            dt.Columns.Add(new DataColumn("id_supplier", typeof(string)));
            dt.Columns.Add(new DataColumn("nama", typeof(string)));
            dt.Columns.Add(new DataColumn("alamat", typeof(string)));
            dt.Columns.Add(new DataColumn("provinsi", typeof(string)));
            dt.Columns.Add(new DataColumn("kota", typeof(string)));
            dt.Columns.Add(new DataColumn("telp", typeof(string)));
            dt.Columns.Add(new DataColumn("email", typeof(string)));
            dt.Columns.Add(new DataColumn("deskripsi", typeof(string)));
            ds.Tables.Add(dt);
            if (ds.Tables["Suppliers"] != null) ds.Tables["Suppliers"].Clear();
            ValidasiBtnSimpan();
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void GetSupplierID()
        {
            if(dgvSupplier.Rows.Count<1)
            {
                cmd = new SqlCommand("SELECT TOP 1 id_supplier FROM Suppliers ORDER BY id_supplier DESC", con);
                var maxId = cmd.ExecuteScalar() as string;

                if (maxId == null)
                {
                    supID = "SUP0001";
                    txtIdSupplier.Text = supID.ToString();
                }
                else
                {
                    int intval = int.Parse(maxId.Substring(3, 4));
                    intval++;
                    supID = String.Format("SUP{0:0000}", intval);
                    txtIdSupplier.Text = supID;
                }
            }
            else
            {
                int intval = int.Parse(dgvSupplier.Rows[0].Cells[0].Value.ToString().Substring(3, 4));
                intval++;
                supID = String.Format("SUP{0:0000}", intval);
                txtIdSupplier.Text = supID;
            }
            
        }

        private void Tampil()
        {
            dgvSupplier.DataSource = ds.Tables["Suppliers"];
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if(txtNamaSupplier.Text=="")
            {
                MessageBox.Show("Masukkan data supplier");
            }
            else
            {
                dr = ds.Tables["Suppliers"].NewRow();
                dr["id_supplier"] = txtIdSupplier.Text;
                dr["nama"] = txtNamaSupplier.Text;
                dr["alamat"] = txtAlamat.Text;
                dr["provinsi"] = txtProvinsi.Text;
                dr["kota"] = txtKota.Text;
                dr["telp"] = txtNoTelp.Text;
                dr["email"] = txtEmail.Text;
                dr["deskripsi"] = txtDeskripsi.Text;
                ds.Tables["Suppliers"].Rows.Add(dr);
                Tampil();
                ValidasiBtnSimpan();
                Reset();
                GetSupplierID();
            }
            
        }
        private void ValidasiBtnSimpan()
        {
            if (ds.Tables["Suppliers"].Rows.Count < 1)
            {
                btnSimpan.Enabled = false;
            }
            else
            {
                btnSimpan.Enabled = true;
            }
        }

        private void Reset()
        {
            txtAlamat.Clear();
            txtDeskripsi.Clear();
            txtEmail.Clear();
            txtIdSupplier.Clear();
            txtKota.Clear();
            txtNamaSupplier.Clear();
            txtNoTelp.Clear();
            txtProvinsi.Clear();
            dgvSupplier.ClearSelection();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            BuatKoneksi();
            ad = new SqlDataAdapter("Select * from Suppliers", con);
            clb = new SqlCommandBuilder(ad);
            ad = clb.DataAdapter;
            ad.Update(ds, "Suppliers");
            MessageBox.Show("Data Berhasil Disimpan");
            this.Close();
        }

        private void DgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSupplier.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvSupplier.CurrentRow.Selected = true;
                    txtIdSupplier.Text = dgvSupplier.Rows[e.RowIndex].Cells["id_supplier"].Value.ToString();

                }
            }
            catch
            {

            }
        }

        private void TxtIdSupplier_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables["Suppliers"] != null)
                {
                    arrRow = ds.Tables["Suppliers"].Select("id_supplier = '" + txtIdSupplier.Text + "'");
                    if (arrRow.Length != 0)
                    {
                        btnTambah.Enabled = false;
                        btnHapus.Enabled = true;
                        btnUbah.Enabled = true;
                        txtNamaSupplier.Text = arrRow[0]["nama"].ToString();
                        txtAlamat.Text = arrRow[0]["alamat"].ToString();
                        txtProvinsi.Text = arrRow[0]["provinsi"].ToString();
                        txtKota.Text = arrRow[0]["kota"].ToString();
                        txtEmail.Text = arrRow[0]["email"].ToString();
                        txtNoTelp.Text = arrRow[0]["telp"].ToString();
                        txtDeskripsi.Text = arrRow[0]["deskripsi"].ToString();
                    }
                    else
                    {
                        btnTambah.Enabled = true;
                        btnHapus.Enabled = false;
                        btnUbah.Enabled = false;

                    }
                }
            }
            catch
            {

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            GetSupplierID();
            Reset();
            
        }
    }
}
