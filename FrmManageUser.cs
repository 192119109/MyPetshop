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
using System.Data.SqlClient;

namespace PetShop
{
    public partial class FrmManageUser : Form
    {
        public FrmManageUser()
        {
            InitializeComponent();
        }
        int selectedRow;
        private void FrmManageUser_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            BuatKoneksi();
            cmd = new SqlCommand("select username, pass, status from pengguna where status like 'admin'", con);
            reader = cmd.ExecuteReader();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "Username";
            dataGridView1.Columns[1].HeaderText = "Password";
            dataGridView1.Columns[2].HeaderText = "Status";
            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["username"], reader["pass"], reader["status"]);
            }
            reader.Close();


            lblBox.Hide();
            label1.Hide();
            label2.Hide();
            txtUser.Hide();
            txtPassword.Hide();
            btnAdd.Hide();
            btnCancel.Hide();

            dataGridView1.ReadOnly = true;
        }

        private void FrmManageUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void btnTambahUser_Click(object sender, EventArgs e)
        {
            lblBox.Show();
            label1.Show();
            label2.Show();
            txtUser.Show();
            txtPassword.Show();
            btnAdd.Show();
            btnCancel.Show();
            btnHapusUser.Hide();
            btnTambahUser.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                MessageBox.Show("Masukkan Username dengan Benar");
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Masukkan Password dengan Benar");
            }
            else
            {
                cmd = new SqlCommand("select username from pengguna where username = @username", con);
                
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Username sudah ada");
                    txtUser.Clear();
                    reader.Close();


                }
                else
                {
                    reader.Close();
                    cmd = new SqlCommand("insert into pengguna values(@username,@password,'admin')", con);
                    cmd.Parameters.AddWithValue("@username", txtUser.Text);
                    cmd.Parameters.AddWithValue("@password", Crypto.EncryptPassword(txtPassword.Text));

                    cmd.ExecuteNonQuery();
                    

                    cmd = new SqlCommand("select username, pass, status from pengguna where status like 'admin'", con);
                    reader = cmd.ExecuteReader();
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.Columns[0].HeaderText = "Username";
                    dataGridView1.Columns[1].HeaderText = "Password";
                    dataGridView1.Columns[2].HeaderText = "Status";
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["username"], reader["pass"], reader["status"]);
                    }
                    reader.Close();

                    lblBox.Hide();
                    label1.Hide();
                    label2.Hide();
                    txtUser.Hide();
                    txtPassword.Hide();
                    btnAdd.Hide();
                    btnCancel.Hide();
                    btnTambahUser.Show();
                    btnHapusUser.Show();
                    txtUser.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblBox.Hide();
            label1.Hide();
            label2.Hide();
            txtUser.Hide();
            txtPassword.Hide();
            btnAdd.Hide();
            btnCancel.Hide();
            btnTambahUser.Show();
            btnHapusUser.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    selectedRow = e.RowIndex;
                    
                }
                else
                {
                    btnHapusUser.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void btnHapusUser_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows != null)
            {
                string msg = "Apakah anda yakin ingin menghapus data ini ?";
                string title = "Hapus Data Admin";
                MessageBoxButtons btn = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, btn);
                if(result == DialogResult.No)
                {
                    
                }
                else
                {
                    cmd = new SqlCommand("delete from pengguna where username = @username", con);
                    cmd.Parameters.AddWithValue("@username", dataGridView1.Rows[selectedRow].Cells[0].Value);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("select username, pass, status from pengguna where status like 'admin'", con);
                    reader = cmd.ExecuteReader();
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.Columns[0].HeaderText = "Username";
                    dataGridView1.Columns[1].HeaderText = "Password";
                    dataGridView1.Columns[2].HeaderText = "Status";
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["username"], reader["pass"], reader["status"]);
                    }
                    reader.Close();
                }
                
            }
        }
    }
}
