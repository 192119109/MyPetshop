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
using static PetShop.Crypto;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class ChangePasswordBySecretKeylogger : Form
    {
        string username = "";
        public ChangePasswordBySecretKeylogger(string userName)
        {
            InitializeComponent();
            username = userName;
        }

        private void UpdatePassword()
        {
            BuatKoneksi();
            cmd = new SqlCommand("update Pengguna set pass=@password where username=@username", con);
            cmd.Parameters.AddWithValue("@password", EncryptPassword(txtNewPass.Text));
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Diubah");
        }

        private void BtnUbahPassword_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text=="")
            {
                MessageBox.Show("Silahkan isi password terlebih dahulu");
            }
            else
            {
                UpdatePassword();
                Form autentikasi = new Autentikasi();
                autentikasi.Show();
                this.Close();
            }
        }
    }
}
