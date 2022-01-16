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
        int selectedRow;
        string invId;

        public FrmPenjualan()
        {
            InitializeComponent();
        }

        private void FrmPenjualan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }


        private void FrmPenjualan_Load(object sender, EventArgs e)
        {
            BuatKoneksi();
            ds = new DataSet();
            if (ds.Tables["Barang"] != null) ds.Tables["Barang"].Clear();
            ad = new SqlDataAdapter("select * from Barang where qty>0", con);
            ad.Fill(ds, "Barang");
            DataTable dt = new DataTable("CheckoutItem");
            dt.Columns.Add(new DataColumn("ID Barang", typeof(string)));
            dt.Columns.Add(new DataColumn("Nama Barang", typeof(string)));
            dt.Columns.Add(new DataColumn("Qty", typeof(int)));
            //dt.Columns.Add(new DataColumn("harga_beli", typeof(string)));
            dt.Columns.Add(new DataColumn("Harga Satuan", typeof(int)));
            dt.Columns.Add(new DataColumn("SubTotal", typeof(int)));
            //dt.Columns.Add(new DataColumn("barcode", typeof(string)));
            ds.Tables.Add(dt);
            nudQty.Minimum = 1;
            nudQty.Value = 1;
            dgvCheckoutItem.AllowUserToAddRows = false;
            btnHapus.Enabled = false;
            txtBarcode.Focus();
            //getInvoice ID
            getInvoiceId();
            txtTotalBarang.Text = "0";
            txtTotalHarga.Text = "Rp.0";
            btnCheckout.Enabled = false;
            nudPotongan.Minimum = 0;
            nudPotongan.Value = 0;
        }

        private void getInvoiceId()
        {
            

            cmd = new SqlCommand("SELECT TOP 1 id_penjualan FROM Penjualan ORDER BY id_penjualan DESC", con);
            var maxId = cmd.ExecuteScalar() as string;

            if (maxId == null|| Convert.ToInt32(DateTime.Now.ToString("MM")) != int.Parse(maxId.Substring(12, 2)))
            {
                invId = "PJ000001/" + DateTime.Now.Date.ToString("dd/MM/yyyy");
                txtInvoiceNum.Text = invId.ToString();
            }
            else
            {
                int intval = int.Parse(maxId.Substring(2, 6));
                intval++;
                invId = String.Format("PJ{0:000000}", intval) + "/" +DateTime.Now.ToString("dd/MM/yyyy");
                txtInvoiceNum.Text = invId;
            }
            //MessageBox.Show(int.Parse(maxId.Substring(12, 2).ToString()) + " , " + int.Parse(maxId.Substring(15, 4)));
            
        }

        private void Tampil()
        {
            dgvCheckoutItem.DataSource = ds.Tables["CheckoutItem"];

            if(ds.Tables["CheckoutItem"].Rows.Count >0)
            {
                ///tampilkan Total harga
                object sumHarga;
                sumHarga = ds.Tables["CheckoutItem"].Compute("Sum(SubTotal)", string.Empty);
                txtTotalHarga.Text = String.Format("{0:c0}", Convert.ToInt32(sumHarga.ToString()));

                //Tampilkan jumlah barang
                object sumJlhBarang;
                sumJlhBarang = ds.Tables["CheckoutItem"].Compute("Sum(qty)", string.Empty);
                txtTotalBarang.Text = sumJlhBarang.ToString();
                btnCheckout.Enabled = true;
            }
            else
            {
                txtTotalBarang.Text = "0";
                txtTotalHarga.Text = "Rp.0";
                btnCheckout.Enabled = false;
            }
           
            foreach (DataGridViewColumn column in dgvCheckoutItem.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


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
                    dr["Harga Satuan"] = arRecord[0]["harga_jual"];
                    dr["SubTotal"] = Convert.ToInt32(arRecord[0]["harga_jual"]) * nudQty.Value;
                    ds.Tables["CheckoutItem"].Rows.Add(dr);
                    Tampil();
                    txtBarcode.Clear();
                    nudQty.Value = 1;
                }
                else
                {
                    MessageBox.Show("Produk tidak ditemukan");
                }
            }
            txtBarcode.Focus();
        }


        private void BtnCari_Click(object sender, EventArgs e)
        {

            FrmCari varCari = new FrmCari();
            varCari.ShowDialog();

            
            if (Global.getBarcode != "")
            {
                KeyPressEventArgs kpea = new KeyPressEventArgs((char)13);
                txtBarcode.Text = Global.getBarcode;
                TxtBarcode_KeyPress(null, kpea);
                Global.getBarcode = "";
            }
        }


        private void DgvCheckoutItem_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCheckoutItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCheckoutItem.CurrentRow.Selected = true;
                    selectedRow = e.RowIndex;
                    btnHapus.Enabled = true;
                }
                else
                {
                    btnHapus.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if(selectedRow>-1)
            {
                if (MessageBox.Show("Apakah anda yakin ingin menghapus item ?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                        ds.Tables["CheckoutItem"].Rows[selectedRow].Delete();
                        MessageBox.Show("Item berhasil dihapus");
                        selectedRow = -1;
                        Tampil();
                        btnHapus.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Tidak ada item yang dipilih");
            }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ds.Tables["CheckoutItem"].Clear();
            txtBarcode.Focus();
            Tampil();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            FrmCheckout frmCheckout = new FrmCheckout(txtTotal.Text.ToString());
            frmCheckout.ShowDialog();

            string TotalHarga = txtTotalHarga.Text.Replace("Rp", "");

            if(Global.checkoutBerhasil)
            {
                //Proses Simpan data ke database
                //simpan ke tabel Penjualan
                cmd = new SqlCommand("insert into Penjualan Values (@id,@tgl,@total)", con);
                cmd.Parameters.AddWithValue("@id", txtInvoiceNum.Text);
                cmd.Parameters.AddWithValue("@tgl", DateTime.Now);
                cmd.Parameters.AddWithValue("@total", Convert.ToInt32(TotalHarga.Replace(".", "")));
                cmd.ExecuteNonQuery();

                ////MessageBox.Show(ds.Tables["CheckoutItem"].Rows.Count.ToString());
                //simpan ke tabel Penjualan_Detail + Kurangi qty di tabel barang
                for(int i=0;i<ds.Tables["CheckoutItem"].Rows.Count;i++)
                {
                    cmd = new SqlCommand("insert into Penjualan_Detail Values (@id,@idBrg,@qty,@subTotal,@harga)", con);
                    cmd.Parameters.AddWithValue("@id", txtInvoiceNum.Text);
                    cmd.Parameters.AddWithValue("@idBrg", dgvCheckoutItem.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[2].Value.ToString()));
                    cmd.Parameters.AddWithValue("@subTotal", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[4].Value.ToString()));
                    cmd.Parameters.AddWithValue("@harga", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[3].Value.ToString()));
                    cmd.ExecuteNonQuery();


                    cmd = new SqlCommand("select qty from Barang where id_barang=@id", con);
                    cmd.Parameters.AddWithValue("@id", dgvCheckoutItem.Rows[i].Cells[0].Value.ToString());
                    int qtyDB = Convert.ToInt32(cmd.ExecuteScalar());
                       int  qtyAfterTransaction = qtyDB-Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[2].Value.ToString());
                        //kurangi qty barang
                        cmd = new SqlCommand("update Barang set qty=@qty where id_barang = @idBrg", con);
                        cmd.Parameters.AddWithValue("@idBrg", dgvCheckoutItem.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(qtyAfterTransaction));
                        cmd.ExecuteNonQuery();

                   
                }

                ds.Tables["CheckoutItem"].Clear();
                getInvoiceId();
                txtBarcode.Focus();
                txtTotalBarang.Text = 0.ToString();
                txtTotalHarga.Text = 0.ToString();
            }

        }

        private void NudQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtBarcode.Focus();
        }
    }
}
