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
    public partial class FrmBantuan : Form
    {
        public FrmBantuan()
        {
            InitializeComponent();
        }

        private void FrmBantuan_Load(object sender, EventArgs e)
        {

            pdfReader.src = "D:/Project PetShop/PetShop/Resources/Help.pdf";
        }
    }
}
