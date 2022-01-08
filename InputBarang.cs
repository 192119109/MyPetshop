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
            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnUbah.Enabled = false;
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
            ValidasiBtnSimpan();
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

        private void DgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBarang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBarang.CurrentRow.Selected = true;
                    txtIdBrg.Text = dgvBarang.Rows[e.RowIndex].Cells["id_barang"].Value.ToString();
                    //txtBarcode.Text = dgvBarang.Rows[e.RowIndex].Cells["barcode"].Value.ToString();
                    //txtNamaBarang.Text = dgvBarang.Rows[e.RowIndex].Cells["nama_barang"].Value.ToString();
                    //nudQty.Value = Convert.ToInt32(dgvBarang.Rows[e.RowIndex].Cells["qty"].Value);
                    //txtHargaBeli.Text = dgvBarang.Rows[e.RowIndex].Cells["harga_beli"].Value.ToString();
                    //txtHargaBeli.Text = string.Format("{0:c}", float.Parse(txtHargaBeli.Text));
                    //txtHargaJual.Text = dgvBarang.Rows[e.RowIndex].Cells["harga_jual"].Value.ToString();
                    //txtHargaJual.Text = string.Format("{0:c}", float.Parse(txtHargaJual.Text));

                }
            }
            catch
            {

            }
        }

        private void Validasi()
        {
            arrRow = ds.Tables["Barang"].Select("id_barang = '" + txtIdBrg.Text + "'");
            if (arrRow.Length != 0)
            {
                btnTambah.Enabled = false;
                btnHapus.Enabled = true;
                btnUbah.Enabled = true;
                txtNamaBarang.Text = arrRow[0]["nama_barang"].ToString();
                txtBarcode.Text = arrRow[0]["barcode"].ToString();
                nudQty.Value = Convert.ToInt32(arrRow[0]["qty"]);
                txtHargaBeli.Text = string.Format("{0:n0}", float.Parse(arrRow[0]["harga_beli"].ToString()));
                txtHargaJual.Text = string.Format("{0:n0}", float.Parse(arrRow[0]["harga_jual"].ToString()));
            }
            else
            {
                btnTambah.Enabled = true;
                btnHapus.Enabled = false;
                btnUbah.Enabled = false;
               
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
                    arrRow[0]["qty"] = nudQty.Value.ToString();
                    arrRow[0]["harga_beli"] = int.Parse(txtHargaBeli.Text.Replace(".", ""));
                    arrRow[0]["harga_jual"] = int.Parse(txtHargaJual.Text.Replace(".", ""));
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
                    arrRow[0].Delete();
                    txtNamaBarang.Clear();
                    txtBarcode.Clear();
                    txtHargaBeli.Clear();
                    txtHargaJual.Clear();
                    nudQty.Value = 0;
                    MessageBox.Show("Data berhasil dihapus");
                    Tampil();
                    btnHapus.Enabled = false;
                    btnUbah.Enabled = false;
                    btnTambah.Enabled = true;
                }
            }
            ValidasiBtnSimpan();
        }
    }
}
