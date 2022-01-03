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
    public partial class SecretKeyLogger : Form
    {
        string secretKey = "mypetshop";
        Form authForm;

        public SecretKeyLogger(Form parentForm)
        {
            InitializeComponent();
            authForm = parentForm;
        }

        private void SecretKeyLogger_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (txtSecretKey.Text == secretKey)
            {
                authForm.Hide();
                Form MainMenu = new FrmMenu();
                MainMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kode Rahasia Salah!");
            }
        }
    }
}
