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
    public partial class FrmAkun : Form
    {
        public FrmAkun()
        {
            InitializeComponent();
        }

        private void FrmAkun_Load(object sender, EventArgs e)
        {
            txtNewPass.PasswordChar = '*';
            txtOldPass.PasswordChar = '*';
        }

        private void TxtOldPass_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPass.Text != "")
            {
                txtSecretKey.Enabled = false;
            }
            else
            {
                txtSecretKey.Enabled = true;
            }
        }

        private void TxtSecretKey_TextChanged(object sender, EventArgs e)
        {
            if (txtSecretKey.Text != "")
            {
                txtOldPass.Enabled = false;
            }
            else
            {
                txtOldPass.Enabled = true;
            }
        }

        private void FrmAkun_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void PbBack_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Close();
        }
    }
}
