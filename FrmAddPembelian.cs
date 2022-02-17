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
        int selectedRowIndex;
        DataRow[] arrRow;
        SqlDataAdapter ad;
        SqlCommandBuilder clb;

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

        private void ClearContent()
        {
            txtCatatan.Clear();
            txtIdBarang.Clear();
            txtNamaBarang.Clear();
            nudHarga.Value = 0;
            nudQty.Value = 1;
            dgvPembelian.ClearSelection();
            btnBrowseBarang.Enabled = true;
            btnHapus.Enabled = false;
            btnUbah.Enabled = false;
            btnTambah.Enabled = true;
        }

        private void Tampil()
        {
            dgvPembelian.DataSource = ds.Tables["Pembelian"];
            ValidasiBtnSimpan();
        }
        private void ValidasiBtnSimpan()
        {
            if (ds.Tables["Pembelian"].Rows.Count < 1)
            {
                btnSimpan.Enabled = false;
                btnBrowseSupplier.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = true;
                btnBrowseSupplier.Enabled = false;
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
            dt.Columns.Add(new DataColumn("nama_barang", typeof(string)));
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
            nudQty.Minimum = 1;
            nudQty.Maximum = int.MaxValue;
            dgvPembelian.AllowUserToAddRows = false;
            nudHarga.Increment = 1000;
            dgvPembelian.ReadOnly = true;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            arrRow = ds.Tables["Pembelian"].Select("id_barang = '" + txtIdBarang.Text + "'");
            if(arrRow.Length!=0)
            {
                MessageBox.Show("Barang sudah ada dalam pembelian, silahkan ubah apabila ingin mengubah info pembelian barang");
            }
            else
            {
                if(txtIdBarang.Text==""||txtIdBarang.Text==null)
                {
                    MessageBox.Show("Silahkan pilih barang terlebih dahulu");
                }
                else
                {
                    dr = ds.Tables["Pembelian"].NewRow();
                    dr["id_pembelian"] = txtIdPembelian.Text;
                    dr["id_supplier"] = txtIdSupplier.Text;
                    dr["id_barang"] = txtIdBarang.Text;
                    dr["nama_barang"] = txtNamaBarang.Text;
                    dr["qty"] = nudQty.Value;
                    dr["harga/pcs"] = nudHarga.Value;
                    dr["total"] = (nudHarga.Value * nudQty.Value);
                    dr["catatan"] = txtCatatan.Text;
                    ds.Tables["Pembelian"].Rows.Add(dr);
                    Tampil();
                    ClearContent();
                }
                
            }
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

        private void DgvPembelian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPembelian.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvPembelian.CurrentRow.Selected = true;
                    txtIdBarang.Text = dgvPembelian.Rows[e.RowIndex].Cells["id_barang"].Value.ToString();
                    txtCatatan.Text = dgvPembelian.Rows[e.RowIndex].Cells["catatan"].Value.ToString();
                    txtNamaBarang.Text = dgvPembelian.Rows[e.RowIndex].Cells["nama_barang"].Value.ToString();
                    nudHarga.Value = Convert.ToInt32(dgvPembelian.Rows[e.RowIndex].Cells["harga/pcs"].Value);
                    nudQty.Value = Convert.ToInt32(dgvPembelian.Rows[e.RowIndex].Cells["qty"].Value);
                    selectedRowIndex = e.RowIndex;
                    btnTambah.Enabled = false;
                    btnHapus.Enabled = true;
                    btnUbah.Enabled = true;
                    btnBrowseBarang.Enabled = false;
                }
                else
                {
                    btnTambah.Enabled = true;
                    btnHapus.Enabled = true;
                    btnUbah.Enabled = true;
                    btnBrowseBarang.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearContent();
            btnTambah.Enabled = true;
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin mengubah item ?", this.Text, MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                arrRow = ds.Tables["Pembelian"].Select("id_barang = '" + txtIdBarang.Text + "'");
                if (arrRow.Length != 0)
                {
                    dr["qty"] = nudQty.Value;
                    dr["harga/pcs"] = nudHarga.Value;
                    dr["Catatan"] = txtCatatan.Text;
                    dr["total"] = nudQty.Value * nudHarga.Value;
                    MessageBox.Show("Data berhasil diubah");
                    Tampil();
                    ClearContent();

                }
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex > -1)
            {
                if (MessageBox.Show("Apakah anda yakin ingin menghapus item ?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ds.Tables["Pembelian"].Rows[selectedRowIndex].Delete();
                    MessageBox.Show("Item berhasil dihapus");
                    selectedRowIndex = -1;
                    Tampil();
                    ClearContent();
                }
            }
            else
            {
                MessageBox.Show("Tidak ada item yang dipilih");
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            BuatKoneksi();
            //Simpan di tabel Pembelian
            cmd = new SqlCommand("insert into Pembelian Values (@idPembelian,@idSupplier,@tglPembelian,@grandTotal)", con);
            cmd.Parameters.AddWithValue("@idPembelian", txtIdPembelian.Text);
            cmd.Parameters.AddWithValue("@idSupplier", txtIdSupplier.Text);
            cmd.Parameters.AddWithValue("@tglPembelian", DateTime.Now);
            cmd.Parameters.AddWithValue("@grandTotal", lblGrandTotal.Text);
            cmd.ExecuteNonQuery();

            //Simpan di tabel Pembelian Detail dan tabel stock
            for(int i=0;i<ds.Tables["Pembelian"].Rows.Count;i++)
            {
                //Pembelian_Detail
                cmd = new SqlCommand("insert into Pembelian_Detail Values (@idPembelian,@idBarang,@hargaPcs,@subtotal,@qty,@Catatan)",con);
                cmd.Parameters.AddWithValue("@idPembelian", txtIdPembelian.Text);
                cmd.Parameters.AddWithValue("@idBarang", dgvPembelian.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@hargaPcs", dgvPembelian.Rows[i].Cells[5].Value.ToString());
                cmd.Parameters.AddWithValue("@subTotal", dgvPembelian.Rows[i].Cells[6].Value.ToString());
                cmd.Parameters.AddWithValue("@qty", dgvPembelian.Rows[i].Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@Catatan", dgvPembelian.Rows[i].Cells[7].Value.ToString());
                cmd.ExecuteNonQuery();

                //Stock
                cmd = new SqlCommand("Insert into Stock Values (@idBarang,@idPembelian,@stock)", con);
                cmd.Parameters.AddWithValue("@idBarang", dgvPembelian.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@idPembelian", txtIdPembelian.Text);
                cmd.Parameters.AddWithValue("@stock", dgvPembelian.Rows[i].Cells[4].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Data Pembelian Berhasil Disimpan");
            this.Close();
        }

        private void DgvPembelian_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            lblJlhPembelian.Text = dgvPembelian.Rows.Count.ToString() + " Item";

            ulong grandTotal=0;
            for (int i = 0; i < dgvPembelian.Rows.Count; ++i)
            {
                grandTotal += Convert.ToUInt64(dgvPembelian.Rows[i].Cells[6].Value);
            }
            //lblGrandTotal.Text = "Rp. " + String.Format("{0:n0}",grandTotal);
            lblGrandTotal.Text = grandTotal.ToString();
        }
    }
}
