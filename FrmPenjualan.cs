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
        DataRow[] arRecord,CheckoutRecord;
        SqlCommandBuilder clb;
        SqlDataReader dataRead;
        int selectedRow;
        string invId;

        public FrmPenjualan()
        {
            InitializeComponent();
        }

        private void FrmPenjualan_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }


        private void FrmPenjualan_Load(object sender, EventArgs e)
        {
            txtNamaKasir.Text = user;
            BuatKoneksi();
            ds = new DataSet();
            if (ds.Tables["Barang"] != null) ds.Tables["Barang"].Clear();
            ad = new SqlDataAdapter("select t1.id_barang, t1.nama_barang, t1.harga_jual, Sum(t2.stock) as 'stock' ,t1.barcode, t1.deskripsi from Barang t1 inner join Stock t2 on t1.id_barang=t2.id_barang where t1.discontinued=0 Group by t1.id_barang,t1.nama_barang,t1.harga_jual,t1.barcode,t1.discontinued,t1.deskripsi Having ISNull(Sum(t2.stock),0) >0", con);
            ad.Fill(ds, "Barang");
            DataTable dt = new DataTable("CheckoutItem");
            dt.Columns.Add(new DataColumn("ID Barang", typeof(string)));
            dt.Columns.Add(new DataColumn("Nama Barang", typeof(string)));
            dt.Columns.Add(new DataColumn("Qty", typeof(int)));
            dt.Columns.Add(new DataColumn("Harga Beli", typeof(string)));
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
            nudPotongan.Maximum = Int32.MaxValue;
            nudPotongan.ThousandsSeparator = true;
            txtTotal.Text = "Rp. 0";
        }

        private void getInvoiceId()
        {
            cmd = new SqlCommand("SELECT TOP 1 id_penjualan FROM Penjualan ORDER BY tgl_transaksi DESC", con);
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
            dgvCheckoutItem.Columns["Harga Beli"].Visible = true;

            if(ds.Tables["CheckoutItem"].Rows.Count >0)
            {
                ///tampilkan Total harga
                HitungTotal();

                //Tampilkan jumlah barang
                object sumJlhBarang;
                sumJlhBarang = ds.Tables["CheckoutItem"].Compute("Sum(qty)", string.Empty);
                txtTotalBarang.Text = sumJlhBarang.ToString();
                btnCheckout.Enabled = true;

            }
            else
            {
                txtTotalBarang.Text = "0";
                txtTotalHarga.Text = "Rp0";
                txtTotal.Text = "Rp0";
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
                    if(Convert.ToInt32(arRecord[0]["stock"])<nudQty.Value)
                    {
                        MessageBox.Show("Stok tidak mencukupi");
                    }
                    else
                    {
                        CheckoutRecord = ds.Tables["CheckoutItem"].Select("[ID Barang] = '" + arRecord[0]["id_barang"] + "'");
                        if (CheckoutRecord.Length != 0)
                        {
                            MessageBox.Show("Barang sudah ada dalam daftar checkout");
                        }
                        else
                        {
                            //Ambil harga beli barang
                            cmd = new SqlCommand("select top 1 t1.id_barang, t1.stock, t2.tgl_pembelian, t3.[harga/pcs] from Stock t1 inner join Pembelian t2 on t1.id_pembelian=t2.id_pembelian inner join Pembelian_Detail t3 on t2.id_pembelian=t3.id_pembelian where t1.id_barang=@idBRG and t1.stock>0 order by tgl_pembelian asc", con);
                            cmd.Parameters.AddWithValue("@idBRG", arRecord[0]["id_barang"]);
                            dataRead = cmd.ExecuteReader();
                            if (dataRead.Read())
                            {
                                dr = ds.Tables["CheckoutItem"].NewRow();
                                dr["ID Barang"] = arRecord[0]["id_barang"];
                                dr["Nama Barang"] = arRecord[0]["nama_barang"];
                                dr["Qty"] = nudQty.Value;
                                dr["Harga Beli"] = Convert.ToInt32(dataRead["harga/pcs"]);
                                dr["Harga Satuan"] = arRecord[0]["harga_jual"];
                                dr["SubTotal"] = Convert.ToInt32(arRecord[0]["harga_jual"]) * nudQty.Value;
                                ds.Tables["CheckoutItem"].Rows.Add(dr);
                                Tampil();
                                txtBarcode.Clear();
                                nudQty.Value = 1;
                            }
                            dataRead.Close();
                        }
                    }
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
            string GrandTotal = txtTotal.Text.Replace("Rp", "");

            if(Global.checkoutBerhasil)
            {
                //Proses Simpan data ke database
                //simpan ke tabel Penjualan
                cmd = new SqlCommand("insert into Penjualan Values (@id,@tgl,@total,@potongan,@grandTotal,@dibayarkan,@kembalian)", con);
                cmd.Parameters.AddWithValue("@id", txtInvoiceNum.Text);
                cmd.Parameters.AddWithValue("@tgl", DateTime.Now);
                cmd.Parameters.AddWithValue("@total", Convert.ToInt32(TotalHarga.Replace(".", "")));
                cmd.Parameters.AddWithValue("@potongan", Convert.ToInt32(nudPotongan.Value));
                cmd.Parameters.AddWithValue("@grandTotal", Convert.ToInt32(GrandTotal.Replace(".", "")));
                cmd.Parameters.AddWithValue("@dibayarkan", Dibayarkan);
                cmd.Parameters.AddWithValue("@kembalian", Kembalian);
                cmd.ExecuteNonQuery();

                ////MessageBox.Show(ds.Tables["CheckoutItem"].Rows.Count.ToString());
                //simpan ke tabel Penjualan_Detail + Kurangi qty di tabel barang
                for(int i=0;i<ds.Tables["CheckoutItem"].Rows.Count;i++)
                {
                    //cmd = new SqlCommand("insert into Penjualan_Detail Values (@id,@idBrg,@qty,@subTotal,@hargaJual,@hargaBeli)", con);
                    //cmd.Parameters.AddWithValue("@id", txtInvoiceNum.Text);
                    //cmd.Parameters.AddWithValue("@idBrg", dgvCheckoutItem.Rows[i].Cells[0].Value);
                    //cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[2].Value.ToString()));
                    //cmd.Parameters.AddWithValue("@subTotal", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[5].Value.ToString()));
                    //cmd.Parameters.AddWithValue("@hargaJual", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[4].Value.ToString()));
                    //cmd.Parameters.AddWithValue("@hargaBeli", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[3].Value.ToString()));
                    //cmd.ExecuteNonQuery();


                    if (ds.Tables["Stocklist"] != null) ds.Tables["Stocklist"].Clear();
                    //ad = new SqlDataAdapter("select t1.stock,t1.id_pembelian from Stock t1 inner join Pembelian t2 on t1.id_pembelian=t2.id_pembelian where id_barang=@id and stock>0 Order by t2.tgl_pembelian asc", con);
                    ad = new SqlDataAdapter("select t1.id_barang, t1.stock,t1.id_pembelian, t3.[harga/pcs] as hargaBeli from Stock t1 inner join Pembelian t2 on t1.id_pembelian=t2.id_pembelian inner join Pembelian_Detail t3 on t2.id_pembelian=t3.id_pembelian where t1.id_barang=@id and stock >0 Order by t2.tgl_pembelian asc", con);
                    ad.SelectCommand.Parameters.AddWithValue("@id", dgvCheckoutItem.Rows[i].Cells[0].Value.ToString());
                    ad.Fill(ds, "Stocklist");
                        int qtyCO = Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[2].Value.ToString());
                        int qtyDB = Convert.ToInt32(ds.Tables["Stocklist"].Rows[0]["stock"]);
                        if(qtyDB<qtyCO)
                        {
                            int x = 0;
                            int stockDibutuhkan = qtyCO;
                            while(stockDibutuhkan> 0)
                            {
                                int tempStockDibutuhkan = stockDibutuhkan;
                                stockDibutuhkan = stockDibutuhkan-Convert.ToInt32(ds.Tables["Stocklist"].Rows[x]["stock"]);
                                if(stockDibutuhkan>0)
                                {
                                    //simpan ke penjualan detail
                                    cmd = new SqlCommand("insert into Penjualan_Detail Values (@id,@idBrg,@qty,@subTotal,@hargaJual,@hargaBeli)", con);
                                    cmd.Parameters.AddWithValue("@id", txtInvoiceNum.Text);
                                    cmd.Parameters.AddWithValue("@idBrg", dgvCheckoutItem.Rows[i].Cells[0].Value);
                                    cmd.Parameters.AddWithValue("@qty", qtyDB);
                                    cmd.Parameters.AddWithValue("@subTotal", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[5].Value.ToString()));
                                    cmd.Parameters.AddWithValue("@hargaJual", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[4].Value.ToString()));
                                    cmd.Parameters.AddWithValue("@hargaBeli", Convert.ToInt32(ds.Tables["Stocklist"].Rows[x]["hargaBeli"]));
                                    cmd.ExecuteNonQuery();
                                    //set stock
                                    ds.Tables["Stocklist"].Rows[x]["stock"] = 0;
                               
                                }
                                else
                                {
                                    //simpan ke penjualan detail
                                    cmd = new SqlCommand("insert into Penjualan_Detail Values (@id,@idBrg,@qty,@subTotal,@hargaJual,@hargaBeli)", con);
                                    cmd.Parameters.AddWithValue("@id", txtInvoiceNum.Text);
                                    cmd.Parameters.AddWithValue("@idBrg", dgvCheckoutItem.Rows[i].Cells[0].Value);
                                    cmd.Parameters.AddWithValue("@qty", tempStockDibutuhkan);
                                    cmd.Parameters.AddWithValue("@subTotal", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[5].Value.ToString()));
                                    cmd.Parameters.AddWithValue("@hargaJual", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[4].Value.ToString()));
                                    cmd.Parameters.AddWithValue("@hargaBeli", Convert.ToInt32(ds.Tables["Stocklist"].Rows[x]["hargaBeli"]));
                                    cmd.ExecuteNonQuery();
                                    //set stock
                                    ds.Tables["Stocklist"].Rows[x]["stock"] = Convert.ToInt32(ds.Tables["Stocklist"].Rows[x]["stock"]) - tempStockDibutuhkan;
                                
                            }

                           

                            //kurangi qty barang
                                cmd = new SqlCommand("update Stock set stock =@qty where id_barang=@idBrg and id_pembelian=@idPemb", con);
                                cmd.Parameters.AddWithValue("@idBrg", dgvCheckoutItem.Rows[i].Cells[0].Value.ToString());
                                cmd.Parameters.AddWithValue("@idPemb", ds.Tables["Stocklist"].Rows[x]["id_pembelian"].ToString());
                                cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(ds.Tables["Stocklist"].Rows[x]["stock"]));
                                cmd.ExecuteNonQuery();
                                x++;
                            }
                        }
                        else
                        {
                            ds.Tables["Stocklist"].Rows[0]["stock"] = qtyDB - qtyCO;
                        cmd = new SqlCommand("insert into Penjualan_Detail Values (@id,@idBrg,@qty,@subTotal,@hargaJual,@hargaBeli)", con);
                        cmd.Parameters.AddWithValue("@id", txtInvoiceNum.Text);
                        cmd.Parameters.AddWithValue("@idBrg", dgvCheckoutItem.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[2].Value.ToString()));
                        cmd.Parameters.AddWithValue("@subTotal", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[5].Value.ToString()));
                        cmd.Parameters.AddWithValue("@hargaJual", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[4].Value.ToString()));
                        cmd.Parameters.AddWithValue("@hargaBeli", Convert.ToInt32(dgvCheckoutItem.Rows[i].Cells[3].Value.ToString()));
                        cmd.ExecuteNonQuery();
                        //kurangi qty barang
                        cmd = new SqlCommand("update Stock set stock =@qty where id_barang=@idBrg and id_pembelian=@idPemb", con);
                            cmd.Parameters.AddWithValue("@idBrg", dgvCheckoutItem.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@idPemb", ds.Tables["Stocklist"].Rows[0]["id_pembelian"].ToString());
                            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(ds.Tables["Stocklist"].Rows[0]["stock"]));
                            cmd.ExecuteNonQuery();
                        

                    }

                }

                ds.Tables["CheckoutItem"].Clear();
                getInvoiceId();
                txtBarcode.Focus();
                txtTotalBarang.Text = 0.ToString();
                txtTotalHarga.Text = "Rp0";
                txtTotal.Text = "Rp0";
                nudPotongan.Value = 0;
                Dibayarkan = 0;
                Kembalian = 0;
            }

        }

        private void NudQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtBarcode.Focus();
        }

        private void HitungTotal()
        {
            object sumHarga;
            if(ds.Tables["CheckoutItem"].Rows.Count!=0)
            {
                sumHarga = ds.Tables["CheckoutItem"].Compute("Sum(SubTotal)", string.Empty);
                txtTotalHarga.Text = String.Format("{0:c0}", Convert.ToInt32(sumHarga.ToString()));
                txtTotal.Text = String.Format("{0:c0}", Convert.ToInt32(sumHarga) - (int)nudPotongan.Value);
            }
            else
            {
                txtTotalHarga.Text = "Rp0";
                txtTotal.Text = "Rp0";
            }
           
        }

        private void TxtTotalHarga_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void NudPotongan_ValueChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            FrmHistory frmHistory = new FrmHistory();
            frmHistory.ShowDialog();
        }
    }
}
