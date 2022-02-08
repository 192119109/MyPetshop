using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FrmPembelian : Form
    {
        public FrmPembelian()
        {
            InitializeComponent();
        }

        private void FrmPembelian_Load(object sender, EventArgs e)
        {

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FrmAddPembelian frmTambahPembelian = new FrmAddPembelian();
            frmTambahPembelian.ShowDialog();
        }

        private void FrmPembelian_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmStock frmStock = new FrmStock();
            frmStock.Show();
        }
    }
}
