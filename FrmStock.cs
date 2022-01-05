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

namespace PetShop
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
        }
    }
}
