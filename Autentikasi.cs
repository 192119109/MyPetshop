using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using static PetShop.Crypto;
using static PetShop.Global;

namespace PetShop
{
    public partial class Autentikasi : Form
    {
        public Autentikasi()
        {
            //Thread thread = new Thread(new ThreadStart(StartForm));
            //thread.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
            //thread.Abort();
        }
        //public void StartForm()
        //{
        //    Application.Run(new Splash());
        //}

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                cmd = new SqlCommand("select pass from Pengguna where username = @username", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    if (txtPassword.Text == DecryptPassword(reader["pass"].ToString()))
                    {
                        Form MainMenu = new FrmMenu();

                        MainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password salah");
                    }
                }
                else
                {
                    MessageBox.Show("Username atau Password salah");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reader.Close();
            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == null || txtPassword.Text == null || txtUsername.Text=="" || txtPassword.Text=="")
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }

        private void LblLupaPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form LupaPassword = new SecretKeyLogger(this);
            LupaPassword.ShowDialog();
        }

        private void CbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == true)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void Autentikasi_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            Global.BuatKoneksi();
        }
    }
}
