using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace PetShop
{
    public partial class SampleBarcode : Form
    {
        string barcode;
        public SampleBarcode(string barcodeIn)
        {
            InitializeComponent();
            barcode = barcodeIn;
        }


        private void SampleBarcode_Load(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            pbBarcode.Image = writer.Write(barcode);
        }
    }
}
