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
    public partial class FrmBiayaTambahan : Form
    {
        string idPembayaran = "";
        DataSet ds;
        SqlDataAdapter ad; 
        public FrmBiayaTambahan()
        {
            InitializeComponent();
        }

        private void FrmBiayaTambahan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void GetIdPembayaran()
        {
            Global.BuatKoneksi();
            Global.cmd = new SqlCommand("SELECT TOP 1 id_biayalain FROM BiayaLain ORDER BY tgl DESC", Global.con);
            var maxId = Global.cmd.ExecuteScalar() as string;

            if (maxId == null || Convert.ToInt32(DateTime.Now.ToString("MM")) != int.Parse(maxId.Substring(12, 2)))
            {
                idPembayaran = "BL000001/" + DateTime.Now.Date.ToString("dd/MM/yyyy");
                txtID.Text = idPembayaran.ToString();
            }
            else
            {
                int intval = int.Parse(maxId.Substring(2, 6));
                intval++;
                idPembayaran = String.Format("BL{0:000000}", intval) + "/" + DateTime.Now.ToString("dd/MM/yyyy");
                txtID.Text = idPembayaran;
            }
            Global.con.Close();
        }

        private void FrmBiayaTambahan_Load(object sender, EventArgs e)
        {
            GetIdPembayaran();
            nudBiaya.Increment = 1000;
            nudBiaya.Maximum = ulong.MaxValue;
            nudBiaya.Minimum = 0;
            cmbBiayaLain.Items.Add("Pembayaran Listrik");
            cmbBiayaLain.Items.Add("Pembayaran Air");
            cmbBiayaLain.Items.Add("Pembayaran Lainnya");
            cmbBiayaLain.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBln.Items.Add("Januari");
            cmbBln.Items.Add("Februari");
            cmbBln.Items.Add("Maret");
            cmbBln.Items.Add("April");
            cmbBln.Items.Add("Mei");
            cmbBln.Items.Add("Juni");
            cmbBln.Items.Add("Juli");
            cmbBln.Items.Add("Agustus");
            cmbBln.Items.Add("September");
            cmbBln.Items.Add("Oktober");
            cmbBln.Items.Add("November");
            cmbBln.Items.Add("Desember");
            cmbBln.DropDownStyle = ComboBoxStyle.DropDownList;

            //Show history
            ds = new DataSet();
            if (ds.Tables["BiayaLain"] != null) ds.Tables["BiayaLain"].Clear();
            ad = new SqlDataAdapter("Select * from BiayaLain order by tgl asc", con);
            ad.Fill(ds, "BiayaLain");
            Tampil();
            dgvHistoryBL.AllowUserToAddRows = false;
            dgvHistoryBL.AllowUserToAddRows = false;
            dgvHistoryBL.ReadOnly = true;
            con.Close();
            dtp1.MaxDate = DateTime.Now.Date;
            dtp2.MaxDate = DateTime.Now.Date;
            dtp2.Value = DateTime.Now.Date;

            //filter date
            dtp1.MinDate = Convert.ToDateTime(ds.Tables["BiayaLain"].Rows[0]["tgl"].ToString());
            dtp1.Value = dtp1.MinDate;

            dtp2.MinDate = dtp1.Value;

        }

        private void Tampil()
        {
            dgvHistoryBL.DataSource = ds.Tables["BiayaLain"];
            dgvHistoryBL.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHistoryBL.Columns[5].DefaultCellStyle.Format = "c";
            lblJlhRecord.Text = ds.Tables["BiayaLain"].Rows.Count.ToString();
        }

        private void RefreshForm()
        {
            GetIdPembayaran();
            cmbBiayaLain.Text = null;
            cmbBln.Text = null;
            txtKet.Clear();
            nudBiaya.Value = nudBiaya.Minimum;
            if (ds.Tables["BiayaLain"] != null) ds.Tables["BiayaLain"].Clear();
            ad = new SqlDataAdapter("Select * from BiayaLain order by tgl asc", con);
            ad.Fill(ds, "BiayaLain");
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbBiayaLain.Text == "")
            {
                MessageBox.Show("Pilih salah satu");
            }
            else if (cmbBln.Text == "")
            {
                MessageBox.Show("Pilih salah Bulan");
            }
            else if(nudBiaya.Value== 0)
            {
                MessageBox.Show("Biaya belum diinput");
            }
            else
            {
                Global.con.Open();
                
                Global.cmd = new SqlCommand("insert into BiayaLain values (@idBL,@title,@bln,@tgl,@ket,@biaya)", Global.con);
                Global.cmd.Parameters.AddWithValue("@idBL", txtID.Text);
                Global.cmd.Parameters.AddWithValue("@title", cmbBiayaLain.Text);
                Global.cmd.Parameters.AddWithValue("@bln", cmbBln.Text);
                Global.cmd.Parameters.AddWithValue("@tgl",DateTime.Now.Date);
                Global.cmd.Parameters.AddWithValue("@ket", txtKet.Text);
                Global.cmd.Parameters.AddWithValue("@biaya", nudBiaya.Value);
                Global.cmd.ExecuteNonQuery();
                Global.con.Close();

                MessageBox.Show("Berhasil");
                RefreshForm();
            }
        }

        private void Dtp1_ValueChanged(object sender, EventArgs e)
        {
            ds.Tables["BiayaLain"].DefaultView.RowFilter = "tgl >='" + dtp1.Value.Date.ToString("d") + "' and tgl <= '" + dtp2.Value.Date.ToString("d") + " 23:59:59" + "'";
            dtp2.MinDate = dtp1.Value;
            lblJlhRecord.Text = dgvHistoryBL.Rows.Count.ToString();
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            rptBiayaLainPreview frmReportBiayaLain = new rptBiayaLainPreview();
            frmReportBiayaLain.ShowDialog();
        }
    }
}
