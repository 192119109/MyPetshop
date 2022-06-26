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
using static PetShop.Crypto;


namespace PetShop
{
    public partial class SecretKeyLogger : Form
    {
        Form authForm;

        public SecretKeyLogger(Form parentForm)
        {
            InitializeComponent();
            authForm = parentForm;
        }

        private void SecretKeyLogger_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            BuatKoneksi();
            if(txtUsername.Text!=""||txtUsername.Text!=null)
            {
                cmd = new SqlCommand("select * from Pengguna where username=@username", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                reader = cmd.ExecuteReader();

                //Validasi Username
                if (reader.Read())
                {
                    reader.Close();
                    try
                    {
                        cmd = new SqlCommand("select keylogger from SecretKeylogger where keylogger = @key", con);
                        cmd.Parameters.AddWithValue("@key", EncryptPassword(txtSecretKey.Text));
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            reader.Close();
                            authForm.Hide();
                            Form lupaPassword = new ChangePasswordBySecretKeylogger(txtUsername.Text);
                            lupaPassword.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Secret Key salah ");
                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Username Tidak Ditemukan");
                }
            }
            else
            {
                MessageBox.Show("Username Tidak Boleh Kosong");
            }
        }
    }
}
