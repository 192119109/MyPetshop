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

namespace PetShop
{
    public partial class FrmBiayaTambahan : Form
    {
        public FrmBiayaTambahan()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        SqlDataAdapter da;
        private void FrmBiayaTambahan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void FrmBiayaTambahan_Load(object sender, EventArgs e)
        {
            
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
            else if(txtBiaya.Text == "")
            {
                MessageBox.Show("Isi Form dengan benar");
            }
            else
            {
                Global.con.Open();
                da = new SqlDataAdapter ("select * from BiayaLain", Global.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int a = Convert.ToInt32(ds.Tables[0].Rows.Count.ToString()) + 1;
             
                //MessageBox.Show(a);
                
                Global.cmd = new SqlCommand("insert into BiayaLain values('" + a + "','" + cmbBiayaLain.Text + "','" + cmbBln.Text  + "','" + txtKet.Text + "','" + txtBiaya.Text + "')", Global.con);
                Global.cmd.ExecuteNonQuery();
                Global.con.Close();

                MessageBox.Show("Berhasil");
                cmbBiayaLain.Text = null;
                cmbBln.Text = null;
                txtKet.Clear();
                txtBiaya.Clear();
            }
        }
    }
}
