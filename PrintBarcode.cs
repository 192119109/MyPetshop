using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace PetShop
{
    public partial class PrintBarcode : Form
    {
        string barcodeOut;
        Image img;
        public PrintBarcode(string barcodeIn)
        {
            InitializeComponent();
            barcodeOut = barcodeIn;
        }

        private void PrintBarcode_Load(object sender, EventArgs e)
        {
            txtBarcode.Text = barcodeOut.ToString();

            string Barcode, Check12Digits;
            string Digit12Bar = txtBarcode.Text.Substring(0,12);

            if (txtBarcode.Text != "")
            {
                Check12Digits = Digit12Bar.PadRight(12, '0');
                Barcode = EAN13Barcode.EAN13(Check12Digits);
                lblResult.Text = Barcode;
                //BarcodeLib.Barcode brCode = new BarcodeLib.Barcode();
                //img = brCode.Encode(BarcodeLib.TYPE.EAN13, barcodeOut, Color.Black, Color.White, 100, 30);
                //pbBarcode.Image = img;
            }

           }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            this.appData1.Clear();
                    this.appData1.Barcode.AddBarcodeRow(lblResult.Text);

            using (frmReportBarcode frm = new frmReportBarcode(this.appData1.Barcode))
            {
                frm.ShowDialog();
            }
        }
    }
}
