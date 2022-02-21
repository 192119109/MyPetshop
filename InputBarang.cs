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
        string idBrg;
        int selectedRowIndex;

        public InputBarang()
        {
            InitializeComponent();
        }

        private void InputBarang_Load(object sender, EventArgs e)
        {
            GetIdBarang();
            txtIdBrg.Enabled = false;
            ds = new DataSet();
            dt = new DataTable("Barang");
            dt.Columns.Add(new DataColumn("id_barang", typeof(string)));
            dt.Columns.Add(new DataColumn("nama_barang", typeof(string)));
            dt.Columns.Add(new DataColumn("harga_jual", typeof(int)));
            dt.Columns.Add(new DataColumn("barcode", typeof(string)));
            dt.Columns.Add(new DataColumn("deskripsi", typeof(string)));
            dt.Columns.Add(new DataColumn("discontinued", typeof(byte)));
            ds.Tables.Add(dt);
            if (ds.Tables["Barang"] != null) ds.Tables["Barang"].Clear();
            Tampil();
            dgvBarang.ReadOnly = true;
            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnUbah.Enabled = false;

            dgvBarang.AllowUserToAddRows = false;
        }
        
        private void GetIdBarang()
        {
            if(dgvBarang.Rows.Count<1)
            {
                cmd = new SqlCommand("SELECT TOP 1 id_barang FROM Barang ORDER BY id_barang DESC", con);
                var maxId = cmd.ExecuteScalar() as string;

                if (maxId == null)
                {
                    idBrg = "BRG0001";
                    txtIdBrg.Text = idBrg.ToString();
                }
                else
                {
                    int intval = int.Parse(maxId.Substring(3, 4));
                    intval++;
                    idBrg = String.Format("BRG{0:0000}", intval);
                    txtIdBrg.Text = idBrg;
                }
            }
            else
            {
                int intval = int.Parse(dgvBarang.Rows[dgvBarang.Rows.Count - 1].Cells[0].Value.ToString().Substring(3, 4));
                intval++;
                idBrg= String.Format("BRG{0:0000}", intval);
                txtIdBrg.Text = idBrg;
            }
        }

        private void Tampil()
        {
            //dgvBarang.ColumnCount = 6;

            dgvBarang.DataSource = ds.Tables["Barang"];
            dgvBarang.Columns["discontinued"].Visible = false;
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

        private void ValidasiBtnSimpan()
        {
            if(ds.Tables["Barang"].Rows.Count<1)
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
            txtBarcode.Clear();
            txtDeskripsi.Clear();
            txtHargaJual.Clear();
            txtIdBrg.Clear();
            txtNamaBarang.Clear();
            txtIdBrg.Focus();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            dr = ds.Tables["Barang"].NewRow();
            dr["id_barang"] = txtIdBrg.Text;
            dr["nama_barang"] = txtNamaBarang.Text;
            dr["harga_jual"] = txtHargaJual.Text;
            dr["barcode"] = txtBarcode.Text;
            dr["deskripsi"] = txtDeskripsi.Text;
            dr["discontinued"] = 0;
            ds.Tables["Barang"].Rows.Add(dr);
            ValidasiBtnSimpan();
            Reset();
            GetIdBarang();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            BuatKoneksi();
            ad = new SqlDataAdapter("Select * from Barang",con);
            clb = new SqlCommandBuilder(ad);
            ad = clb.DataAdapter;
            ad.Update(ds, "Barang");
            MessageBox.Show("Data Berhasil Disimpan");
            this.Close();

        }

        private void DgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBarang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBarang.CurrentRow.Selected = true;
                    txtIdBrg.Text = dgvBarang.Rows[e.RowIndex].Cells["id_barang"].Value.ToString();
                    selectedRowIndex = e.RowIndex;
                }
            }
            catch
            {

            }
        }

        private void Validasi()
        {
            try
            {
                if (ds.Tables["Barang"] != null)
                {
                    arrRow = ds.Tables["Barang"].Select("id_barang = '" + txtIdBrg.Text + "'");
                    if (arrRow.Length != 0)
                    {
                        btnTambah.Enabled = false;
                        btnHapus.Enabled = true;
                        btnUbah.Enabled = true;
                        txtNamaBarang.Text = arrRow[0]["nama_barang"].ToString();
                        txtHargaJual.Text = string.Format("{0:n0}", float.Parse(arrRow[0]["harga_jual"].ToString()));
                        txtBarcode.Text = arrRow[0]["barcode"].ToString();
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

        private void TxtIdBrg_TextChanged(object sender, EventArgs e)
        {
            Validasi();
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin mengubah item ?", this.Text, MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                arrRow = ds.Tables["Barang"].Select("id_barang = '" + txtIdBrg.Text + "'");
                if (arrRow.Length != 0)
                {
                    arrRow[0]["barcode"] = txtBarcode.Text;
                    arrRow[0]["nama_barang"] = txtNamaBarang.Text;
                    arrRow[0]["harga_jual"] = int.Parse(txtHargaJual.Text.Replace(".", ""));
                    arrRow[0]["deskripsi"] = txtDeskripsi.Text;
                    MessageBox.Show("Data berhasil diubah");
                    Tampil();
                }
            }
            ValidasiBtnSimpan();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus item ?", this.Text, MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                arrRow = ds.Tables["Barang"].Select("id_barang = '" + txtIdBrg.Text + "'");
                if (arrRow.Length != 0)
                {
                    if (selectedRowIndex != dgvBarang.Rows.Count - 1)
                    {
                        ds.Tables["Barang"].Rows[selectedRowIndex + 1]["id_barang"] = txtIdBrg.Text;
                    }
                    arrRow[0].Delete();
                    txtNamaBarang.Clear();
                    txtBarcode.Clear();
                    txtDeskripsi.Clear();
                    txtHargaJual.Clear();
                    MessageBox.Show("Data berhasil dihapus");
                    Tampil();
                    btnHapus.Enabled = false;
                    btnUbah.Enabled = false;
                    btnTambah.Enabled = true;
                }
            }
            ValidasiBtnSimpan();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNamaBarang.Clear();
            txtHargaJual.Clear();
            txtDeskripsi.Clear();
            txtBarcode.Clear();
            dgvBarang.ClearSelection();
            btnTambah.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            GetIdBarang();
        }
    }
}
