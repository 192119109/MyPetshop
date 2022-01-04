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
            btnUbah.Enabled = false;
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

        private void UpdatePassword()
        {
            cmd = new SqlCommand("update Pengguna set pass=@password where username=@username",con);
            cmd.Parameters.AddWithValue("@password", EncryptPassword(txtNewPass.Text));
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Diubah");
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            BuatKoneksi();

            //cek pengguna
            cmd = new SqlCommand("select * from Pengguna where username=@username",con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                if (txtOldPass.Text == "")
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
                            UpdatePassword();
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
                        reader.Close();
                    }
                }
                else
                {
                    if (reader["pass"].ToString() == EncryptPassword(txtOldPass.Text))
                    {
                        reader.Close();
                        UpdatePassword();
                    }
                    else
                    {
                        MessageBox.Show("Password Lama Belum Benar");
                    }
                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("Pengguna tidak ditemukan");
                reader.Close();
            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text!="")
            {
                btnUbah.Enabled = true;
            }
            else
            {
                btnUbah.Enabled = false;
            }
        }

        private void ChkShowOldPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowOldPass.Checked == true)
                txtOldPass.PasswordChar = '\0';
            else
                txtOldPass.PasswordChar = '*';
        }

        private void ChkShowNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowNewPass.Checked == true)
                txtNewPass.PasswordChar = '\0';
            else
                txtNewPass.PasswordChar = '*';
        }
    }
}
