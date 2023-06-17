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
using System.Net;
using System.Net.Mail;


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

        private string sendKeyViaEmail(string key, string name)
        {
            string message = "";
            if(!string.IsNullOrEmpty(key)&&!string.IsNullOrEmpty(name))
            {
                if(IsConnectedToInternet())
                {
                    if (sendMail("davidrussel7771@gmail.com", "David Steven", $"Kode Autentikasi Anda = {key}", "Kode Autentikasi MyPetshop"))
                    {
                        message = "Berhasil Mengirimkan Kode Autentikasi";
                    }
                    else
                    {
                        message = "Gagal Mengirimkan Kode Autentikasi";
                    }
                }
                else
                {
                    message = "Kamu belum terhubung ke internet, pastikan kamu terhubung dengan internet";
                }
            }

            return message;
        }

        private void SecretKeyLogger_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }



        private void BtnOK_Click(object sender, EventArgs e)
        {
            openConnection(true);

            if(txtUsername.Text!=""||txtUsername.Text!=null)
            {
                cmd = new SqlCommand("select * from Pengguna where username=@username", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                reader = cmd.ExecuteReader();

                //Validasi Username
                if (reader.Read())
                {
                    string key = reader["key"].ToString();
                    reader.Close();
                    try
                    {
                        if(txtUsername.Text.Trim().ToUpper()=="ADMIN")
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
                        else
                        {
                            if(string.IsNullOrEmpty(key))
                            {
                                DialogResult dialogResult = MessageBox.Show("Key belum ada, request key sekarang", "Perhatian", MessageBoxButtons.YesNo);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    string keyy = Guid.NewGuid().ToString();
                                    cmd = new SqlCommand($"update pengguna set [key] = @key where username = @username", con);
                                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                                    cmd.Parameters.AddWithValue("@key", keyy);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show(sendKeyViaEmail(keyy, txtUsername.Text));
                                }
                            }
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
            openConnection(false);
        }
    }
}
