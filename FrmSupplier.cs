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
    public partial class FrmSupplier : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        DataRow[] arRecord;
        SqlCommandBuilder clb;

        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu mainMenu = new FrmMenu();
            mainMenu.Show();
        }

        private void BtnNewStock_Click(object sender, EventArgs e)
        {
            FrmAddSup frmInputSupplier = new FrmAddSup();
            frmInputSupplier.ShowDialog();
            RefreshData();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            BuatKoneksi();
            ds = new DataSet();
            RefreshData();
            cbSearchBy.SelectedIndex = 0;
            dgvSupplier.AllowUserToAddRows = false;
            dgvSupplier.ReadOnly = true;
            dgvSupplier.ClearSelection();
        }

        private void tampil()
        {
            dgvSupplier.DataSource = ds.Tables["Suppliers"];
            lblJlhSup.Text = (dgvSupplier.Rows.Count-1).ToString();
        }

        private void RefreshData()
        {
            if (ds.Tables["Suppliers"] != null) ds.Tables["Suppliers"].Clear();
            ad = new SqlDataAdapter("select * from Suppliers", con);
            ad.Fill(ds, "Suppliers");
            tampil();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(cbSearchBy.SelectedIndex == 4)
            {
                ds.Tables["Suppliers"].DefaultView.RowFilter = "kota LIKE '%" + txtSearch.Text + "%'";
            }
            else if(cbSearchBy.SelectedIndex == 3)
            {
                ds.Tables["Suppliers"].DefaultView.RowFilter = "provinsi LIKE '%" + txtSearch.Text + "%'";
            }
            else if (cbSearchBy.SelectedIndex == 2)
            {
                ds.Tables["Suppliers"].DefaultView.RowFilter = "alamat LIKE '%" + txtSearch.Text + "%'";
            }
            else if (cbSearchBy.SelectedIndex == 1)
            {
                ds.Tables["Suppliers"].DefaultView.RowFilter = "nama LIKE '%" + txtSearch.Text + "%'";
            }
            else if(cbSearchBy.SelectedIndex == 0)
            {
                ds.Tables["Suppliers"].DefaultView.RowFilter = "id_supplier LIKE '%" + txtSearch.Text + "%'";
            }
        }

        private void DgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSupplier.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvSupplier.CurrentRow.Selected = true;
                    txtIdSupplier.Text = dgvSupplier.Rows[e.RowIndex].Cells["id_supplier"].Value.ToString();

                }
            }
            catch
            {

            }
        }

        private void TxtIdSupplier_TextChanged(object sender, EventArgs e)
        {
            bool tersedia;

            arRecord = ds.Tables["Suppliers"].Select("id_supplier = '" + txtIdSupplier.Text + "'");
            if (arRecord.Length != 0)
            {
                tersedia = true;
            }
            else
            {
                tersedia = false;
            }
            if (string.IsNullOrEmpty(txtIdSupplier.Text) || !tersedia)
            {
                btnUpdate.Enabled = false;
                txtNama.Enabled = false;
                txtProvinsi.Enabled = false;
                txtKota.Enabled = false;
                txtEmail.Enabled = false;
                txtAlamat.Enabled = false;
                txtTelp.Enabled = false;
                txtDeskripsi.Enabled = false;
                Bersihkan();
            }
            else
            {
                arRecord = ds.Tables["Suppliers"].Select("id_supplier='" + txtIdSupplier.Text + "'");
                if (arRecord.Length != 0)
                {
                    txtNama.Text = arRecord[0]["nama"].ToString();
                    txtProvinsi.Text = arRecord[0]["provinsi"].ToString();
                    txtKota.Text = arRecord[0]["kota"].ToString();
                    txtAlamat.Text = arRecord[0]["alamat"].ToString();
                    txtEmail.Text = arRecord[0]["email"].ToString();
                    txtTelp.Text = arRecord[0]["telp"].ToString();
                    txtDeskripsi.Text = arRecord[0]["deskripsi"].ToString();
                }
                btnUpdate.Enabled = true;
                txtNama.Enabled = true;
                txtKota.Enabled = true;
                txtAlamat.Enabled = true;
                txtProvinsi.Enabled = true;
                txtTelp.Enabled = true;
                txtEmail.Enabled = true;
                txtDeskripsi.Enabled = true;
                
            }
        }

        private void Bersihkan()
        {
            dgvSupplier.ClearSelection();
            txtIdSupplier.Clear();
            txtNama.Clear();
            txtKota.Clear();
            txtProvinsi.Clear();
            txtDeskripsi.Clear();
            txtEmail.Clear();
            txtAlamat.Clear();
            txtTelp.Clear();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Bersihkan();
            RefreshData();
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin mengubah item ?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                arRecord = ds.Tables["Suppliers"].Select("id_supplier = '" + txtIdSupplier.Text + "'");
                if (arRecord.Length != 0)
                {
                    arRecord[0]["nama"] = txtNama.Text;
                    arRecord[0]["alamat"] = txtAlamat.Text;
                    arRecord[0]["provinsi"] = txtProvinsi.Text; 
                    arRecord[0]["kota"] = txtKota.Text;
                    arRecord[0]["telp"] = txtTelp.Text;
                    arRecord[0]["email"] = txtEmail.Text;
                    arRecord[0]["deskripsi"] = txtDeskripsi.Text;
                    clb = new SqlCommandBuilder(ad);
                    ad = clb.DataAdapter;
                    ad.Update(ds, "Suppliers");
                    MessageBox.Show("Data berhasil diubah");
                }
            }
        }
    }
}
