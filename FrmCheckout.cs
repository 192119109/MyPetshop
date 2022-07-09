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
    public partial class FrmCheckout : Form
    {
        string totalHarga;
        bool checkOutVerified= false;
        bool btnCetakHit = false;
        string invID = "";
        public FrmCheckout(string total,string Inv)
        {
            InitializeComponent();
            totalHarga = total.Replace("Rp", "");
            invID = Inv;
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {
            lblTotal.Text = totalHarga;
            nudDibayarkan.Minimum = 0;
            nudDibayarkan.ThousandsSeparator = true;
            nudDibayarkan.Value = 0;
            nudDibayarkan.Increment = 1000;
            nudDibayarkan.Maximum = 90000000;
            txtKembalian.Text = "0";
            nudDibayarkan.Focus();
        }

        private void NudDibayarkan_ValueChanged(object sender, EventArgs e)
        {
            int kembalian;
            int total = int.Parse(totalHarga.Replace(".", ""));

            kembalian = Convert.ToInt32(nudDibayarkan.Value) - total;
            txtKembalian.Text = String.Format("{0:n0}", kembalian);
        }

        private void checkOutProses()
        {
            if (nudDibayarkan.Value >= int.Parse(totalHarga.Replace(".", "")))
            {

                MessageBox.Show("Pembayaran Berhasil");
                Dibayarkan = Convert.ToInt32(nudDibayarkan.Value);
                Kembalian = Convert.ToInt32(txtKembalian.Text.Replace(".", ""));
                checkOutVerified = true;
                if(btnCetakHit)
                {
                    receiptInv = invID;
                }
                else
                {
                    receiptInv = null;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Uang yang dibayarkan tidak mencukupi");
            }
        }

        private void BtnBayar_Click(object sender, EventArgs e)
        {
            checkOutProses();
        }

        private void FrmCheckout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.checkoutBerhasil = checkOutVerified;
        }

        private void BtnBayarCetak_Click(object sender, EventArgs e)
        {
            btnCetakHit = true;
            checkOutProses();

        }
    }
}
