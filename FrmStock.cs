using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using static PetShop.Global;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class FrmStock : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        DataRow dr;
        DataRow[] arRecord;
        SqlCommandBuilder clb;

        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void Tampil()
        {
            //dgvBarang.ColumnCount = 6;
            dgvBarang.DataSource = ds.Tables["Barang"];
            dgvBarang.Columns["harga_jual"].DefaultCellStyle.Format = "c";
            dgvBarang.Columns["harga_beli"].DefaultCellStyle.Format = "c";
            dgvBarang.Columns[0].HeaderText = "Id Barang";
            dgvBarang.Columns[1].HeaderText = "Nama Barang";
            dgvBarang.Columns[2].HeaderText = "Qty";
            dgvBarang.Columns[3].HeaderText = "Harga Beli";
            dgvBarang.Columns[4].HeaderText = "Harga Jual";
            dgvBarang.Columns[5].HeaderText = "Barcode";
            dgvBarang.ReadOnly = true;
            dgvBarang.AllowUserToAddRows = false;
        }

        private void Validasi()
        {
            bool tersedia;

            arRecord = ds.Tables["Barang"].Select("id_barang='" + txtIdBarang.Text + "'");
            if(arRecord.Length!=0)
            {
                tersedia = true;
            }
            else
            {
                tersedia = false;
            }
            if (string.IsNullOrEmpty(txtIdBarang.Text)||!tersedia)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                txtBarcode.Enabled = false;
                txtHargaBeli.Enabled = false;
                txtHargaJual.Enabled = false;
                txtNamaBarang.Enabled = false;
                nudQty.Enabled = false;
                txtIdBarang.Clear();
                txtBarcode.Clear();
                txtHargaBeli.Clear();
                txtHargaJual.Clear();
                nudQty.Value = 0;
                txtNamaBarang.Clear();

            }
            else
            {
                arRecord = ds.Tables["Barang"].Select("id_barang='" + txtIdBarang.Text + "'");
                if (arRecord.Length != 0)
                {
                    txtNamaBarang.Text = arRecord[0]["nama_barang"].ToString();
                    txtBarcode.Text = arRecord[0]["barcode"].ToString();
                    nudQty.Value = Convert.ToInt32(arRecord[0]["qty"]);
                    txtHargaBeli.Text = string.Format("{0:n0}", float.Parse(arRecord[0]["harga_beli"].ToString()));
                    txtHargaJual.Text = string.Format("{0:n0}", float.Parse(arRecord[0]["harga_jual"].ToString()));
                    //txtIdBarang.Text = arRecord[0]["id_barang"].ToString();
                }
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                txtBarcode.Enabled = true;
                txtHargaBeli.Enabled = true;
                txtHargaJual.Enabled = true;
                txtNamaBarang.Enabled = true;
                nudQty.Enabled = true;
            }
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            BuatKoneksi();
            ds = new DataSet();
            if (ds.Tables["Barang"] != null) ds.Tables["Barang"].Clear();
            ad = new SqlDataAdapter("select * from Barang", con);
            ad.Fill(ds, "Barang");
            Tampil();
            Validasi();
        }

        private void BtnNewStock_Click(object sender, EventArgs e)
        {
            InputBarang frmInputBarang = new InputBarang();
            frmInputBarang.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
             MuatUlang();
        }


        private void TxtIdBarang_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    arRecord = ds.Tables["Barang"].Select("id_barang='" + txtIdBarang.Text + "'");
            //    if (arRecord.Length != 0)
            //    {
            //        txtNamaBarang.Text = arRecord[0]["nama_barang"].ToString();
            //        txtBarcode.Text = arRecord[0]["barcode"].ToString();
            //        nudQty.Value = Convert.ToInt32(arRecord[0]["qty"]);
            //        txtHargaBeli.Text = string.Format("{0:c}", float.Parse(arRecord[0]["harga_beli"].ToString()));
            //        txtHargaJual.Text = string.Format("{0:c}", float.Parse(arRecord[0]["harga_jual"].ToString()));
            //        txtIdBarang.Text = arRecord[0]["id_barang"].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Barang Tidak Ditemukan");
            //    }
            //}
        }

        private void DgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBarang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBarang.CurrentRow.Selected = true;
                    txtIdBarang.Text = dgvBarang.Rows[e.RowIndex].Cells["id_barang"].Value.ToString();
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            Tampil();
            txtIdBarang.Clear();
            txtBarcode.Clear();
            txtHargaBeli.Clear();
            txtHargaJual.Clear();
            nudQty.Value = 0;
            txtNamaBarang.Clear();
        }

        private void MuatUlang()
        {
            ds.Tables["Barang"].Clear();
            ad.Fill(ds, "Barang");

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //ds.Tables["Barang"].DefaultView.RowFilter = string.Format("nama_barang LIKE '%{0}%'",txtSearch.Text);
            ds.Tables["Barang"].DefaultView.RowFilter = "nama_barang LIKE '%" + txtSearch.Text + "%'";
            //dgvBarang.DataSource = ds.Tables["Barang"]; 
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin ingin menghapus item ?",this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from Barang where id_barang=@id", con);
                cmd.Parameters.AddWithValue("@id", txtIdBarang.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item berhasil dihapus");
                MuatUlang();
                Tampil();
            }
        }

        private void TxtIdBarang_TextChanged(object sender, EventArgs e)
        {
            Validasi();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin mengubah item ?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                arRecord = ds.Tables["Barang"].Select("id_barang = '" + txtIdBarang.Text + "'");
                if (arRecord.Length != 0)
                {
                    arRecord[0]["barcode"] = txtBarcode.Text;
                    arRecord[0]["nama_barang"] = txtNamaBarang.Text;
                    arRecord[0]["qty"] = nudQty.Value.ToString();
                    arRecord[0]["harga_beli"] = int.Parse(txtHargaBeli.Text.Replace(".", ""));
                    arRecord[0]["harga_jual"] = int.Parse(txtHargaJual.Text.Replace(".", ""));
                    clb = new SqlCommandBuilder(ad);
                    ad = clb.DataAdapter;
                    ad.Update(ds, "Barang");
                    MessageBox.Show("Data berhasil diubah");
                }
            }
        }

        private void BtnGenerateCode_Click(object sender, EventArgs e)
        {
            arRecord = ds.Tables["Barang"].Select("id_barang = '" + txtIdBarang.Text + "'");
            if (arRecord.Length != 0)
            { 
                SampleBarcode frmBarcode = new SampleBarcode(arRecord[0]["barcode"].ToString());
                frmBarcode.ShowDialog();
            }
        }
    }
}