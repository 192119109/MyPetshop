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
    public partial class FrmMoreDetail : Form
    {
        public FrmMoreDetail()
        {
            InitializeComponent();
        }

        private void BtnPenguranganStock_Click(object sender, EventArgs e)
        {
            FrmAdjustStock adjStock = new FrmAdjustStock();
            adjStock.Show();
        }
    }
}
