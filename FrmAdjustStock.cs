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
    public partial class FrmAdjustStock : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        string idBRG = "";
        string idPembelian = "";
        string idPengurangan = "";
        int selectedRow;
        public FrmAdjustStock()
        {
            InitializeComponent();
        }


        private void FrmAdjustStock_Load(object sender, EventArgs e)
        {
            ToolTip tooltip1 = new ToolTip();

            //set delay for tooltip
            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 1000;
            tooltip1.ReshowDelay = 500;

            //force the tooltip text to be displayed  whether or not the form is active
            tooltip1.ShowAlways = true;

            //set up the tooltip text for the label 
            tooltip1.SetToolTip(lblAdjust, "Qty Adjust adalah jumlah stok yang ingin dikurangi dari stok barang awal");
            tooltip1.SetToolTip(nudAjdust, "Qty Adjust adalah jumlah stok yang ingin dikurangi dari stok barang awal");

            //Tampil data barang
            ds = new DataSet();
            Tampil_DataBarang();
            SetDataGridViewBarang();

            //Set numeric Up down
            nudAjdust.Enabled = false;
            nudAjdust.Minimum = 0;

            //set placeholder
            txtCariBarang.Text = "Cari Barang";
            txtCariPembelian.Text = "Cari Pembelian";
            txtCariBarang.ForeColor = Color.Gray;
            txtCariPembelian.ForeColor = Color.Gray;
        }

        private void Tampil_DataBarang()
        {
            BuatKoneksi();
            
            if (ds.Tables["Barang"] != null) ds.Tables["Barang"].Clear();
            ad = new SqlDataAdapter("select t1.id_barang , t2.nama_barang, sum(t1.stock) as Qty from Stock t1 inner join Barang t2 on t1.id_barang=t2.id_barang group by t1.id_barang,t2.nama_barang having sum(t1.stock)>0", con);
            ad.Fill(ds, "Barang");
            con.Close();
        }

        private void Tampil_Pembelian()
        {
            BuatKoneksi();
            if (ds.Tables["Pembelian"] != null) ds.Tables["Pembelian"].Clear();
            ad = new SqlDataAdapter("select t1.id_pembelian, t4.nama as 'Nama Supplier', t1.stock, t3.[harga/pcs], t3.Catatan from Stock t1 inner join Pembelian t2 on t1.id_pembelian = t2.id_pembelian inner join Suppliers t4 on t2.id_supplier = t4.id_supplier inner join Pembelian_Detail t3 on t2.id_pembelian = t3.id_pembelian where t1.id_barang = @idBrg and t1.stock>0", con);
            ad.SelectCommand.Parameters.AddWithValue("@idBrg", idBRG);
            ad.Fill(ds, "Pembelian");
            con.Close();
        }

        private void SetDataGridViewBarang()
        {
            dgvBarang.DataSource = ds.Tables["Barang"];
            dgvBarang.ReadOnly = true;
            dgvBarang.AllowUserToAddRows = false;
            dgvBarang.Columns[0].HeaderText = "ID Barang";
            dgvBarang.Columns[1].HeaderText = "Nama Barang";
            dgvBarang.Columns[2].HeaderText = "Qty/Pcs";

            
        }
        
        private void SetDataGridViewPembelian()
        {
            if (ds.Tables["Pembelian"] != null)
            {
                dgvPembelian.DataSource = ds.Tables["Pembelian"];
                dgvPembelian.ReadOnly = true;
                dgvPembelian.AllowUserToAddRows = false;
                dgvPembelian.Columns[0].HeaderText = "ID Pembelian";
                dgvPembelian.Columns[1].HeaderText = "Nama Supplier";
                dgvPembelian.Columns[2].HeaderText = "Qty";
                dgvPembelian.Columns[3].HeaderText = "Harga/Pcs";
                dgvPembelian.Columns[4].HeaderText = "Catatan";
                dgvPembelian.Columns[3].DefaultCellStyle.Format = "N0"; 
            }
        }

        private void DgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBarang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBarang.CurrentRow.Selected = true;
                    idBRG = dgvBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //Tampilkan Pembelian
                    Tampil_Pembelian();
                    SetDataGridViewPembelian();
                    dgvPembelian.ClearSelection();
                    ClearInfo();
                }
            }
            catch
            {

            }
        }

        

        private void DgvPembelian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPembelian.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvPembelian.CurrentRow.Selected = true;

                    //Tampil Info Stock
                    lblStockAwal.Text = dgvPembelian.Rows[e.RowIndex].Cells[2].Value.ToString();
                    lblQtyAkhir.Text = (Convert.ToInt32(lblStockAwal.Text) - nudAjdust.Value).ToString();
                    nudAjdust.Maximum = Convert.ToInt32(lblStockAwal.Text);
                    nudAjdust.Enabled = true;
                    idPembelian = dgvPembelian.Rows[e.RowIndex].Cells[0].Value.ToString();
                    selectedRow = e.RowIndex;
                }
            }
            catch
            {

            }
        }

        private void NudAjdust_ValueChanged(object sender, EventArgs e)
        {
            lblQtyAkhir.Text = (Convert.ToInt32(lblStockAwal.Text) - nudAjdust.Value).ToString();
        }

        private void ClearInfo()
        {
           

            lblQtyAkhir.Text = "0";
            lblStockAwal.Text = "0";
            txtDeskripsi.Text = "";
            nudAjdust.Value = 0;
            nudAjdust.Enabled = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            dgvBarang.ClearSelection();
            dgvPembelian.ClearSelection();
            ClearInfo();
        }

        private void TxtCariBarang_Enter(object sender, EventArgs e)
        {
            if(txtCariBarang.Text=="Cari Barang")
            {
                txtCariBarang.Text = "";
                txtCariBarang.ForeColor = Color.Black;
            }
        }

        private void TxtCariBarang_Leave(object sender, EventArgs e)
        {
            if (txtCariBarang.Text == "")
            {
                txtCariBarang.Text = "Cari Barang";
                txtCariBarang.ForeColor = Color.Gray;
            }
        }

        private void TxtCariPembelian_Enter(object sender, EventArgs e)
        {
            if (txtCariPembelian.Text == "Cari Pembelian")
            {
                txtCariPembelian.Text = "";
                txtCariPembelian.ForeColor = Color.Black;
            }
        }

        private void TxtCariPembelian_Leave(object sender, EventArgs e)
        {
            if (txtCariPembelian.Text == "")
            {
                txtCariPembelian.Text = "Cari Pembelian";
                txtCariPembelian.ForeColor = Color.Gray;
            }
        }

        private void TxtCariBarang_TextChanged(object sender, EventArgs e)
        {
            if(txtCariBarang.Text!="Cari Barang")
            {
                ds.Tables["Barang"].DefaultView.RowFilter = "nama_barang LIKE '%" + txtCariBarang.Text + "%' OR id_barang Like '%" + txtCariBarang.Text + "%'";
            }   
        }

        private void TxtCariPembelian_TextChanged(object sender, EventArgs e)
        {
            if (txtCariPembelian.Text != "Cari Pembelian")
            {
                ds.Tables["Pembelian"].DefaultView.RowFilter = "[Nama Supplier] LIKE '%" + txtCariPembelian.Text + "%' OR id_pembelian Like '%" + txtCariPembelian.Text + "%'";
            }
        }

        private void GetIdAdj()
        {
            BuatKoneksi();
            cmd = new SqlCommand("SELECT TOP 1 id_pengurangan FROM Pengurangan_Stock ORDER BY tglPengurangan DESC", con);
            var maxId = cmd.ExecuteScalar() as string;

            if (maxId == null || Convert.ToInt32(DateTime.Now.ToString("MM")) != int.Parse(maxId.Substring(12, 2)))
            {
                idPengurangan = "PG000001/" + DateTime.Now.Date.ToString("dd/MM/yyyy");
                
            }
            else
            {
                int intval = int.Parse(maxId.Substring(2, 6));
                intval++;
                idPengurangan = String.Format("PG{0:000000}", intval) + "/" + DateTime.Now.ToString("dd/MM/yyyy");
            }
            con.Close();
        }

        private void BtnAdjust_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin mengurangi stock barang ?", this.Text, MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                //Get id pengurangan
                GetIdAdj();

                BuatKoneksi();
                //Catat di table pengurangan stock
                cmd = new SqlCommand("insert into Pengurangan_Stock values (@idPengurangan,@idBarang,@idPembelian,@tgl,@qtyAwal,@qtyAkhir,@jlhPengurangan,@ket)", con);
                cmd.Parameters.AddWithValue("@idPengurangan",idPengurangan);
                cmd.Parameters.AddWithValue("@idBarang", idBRG);
                cmd.Parameters.AddWithValue("@idPembelian", idPembelian);
                cmd.Parameters.AddWithValue("@tgl", DateTime.Now);
                cmd.Parameters.AddWithValue("@qtyAwal", Convert.ToInt32(lblStockAwal.Text));
                cmd.Parameters.AddWithValue("@qtyAkhir", Convert.ToInt32(lblQtyAkhir.Text));
                cmd.Parameters.AddWithValue("@jlhPengurangan", nudAjdust.Value);
                cmd.Parameters.AddWithValue("@ket", txtDeskripsi.Text);
                cmd.ExecuteNonQuery();
                //Kurangi stock
                cmd = new SqlCommand("Update Stock set stock=@qty where id_barang = @idBrg and id_pembelian=@idPembelian", con);
                cmd.Parameters.AddWithValue("@idBrg",idBRG);
                cmd.Parameters.AddWithValue("@idPembelian", idPembelian);
                cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(lblQtyAkhir.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil mengurangi stock");
                Tampil_Pembelian();
                dgvPembelian.ClearSelection();
                dgvPembelian.Rows[selectedRow].Selected = true;
                nudAjdust.Value = 0;
                //tampil info
                lblStockAwal.Text = dgvPembelian.Rows[selectedRow].Cells[2].Value.ToString();
                lblQtyAkhir.Text = (Convert.ToInt32(lblStockAwal.Text) - nudAjdust.Value).ToString();
                nudAjdust.Maximum = Convert.ToInt32(lblStockAwal.Text);
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            FrmHistoryPengurangan historyPengurangan = new FrmHistoryPengurangan();
            historyPengurangan.ShowDialog();
        }
    }
}
