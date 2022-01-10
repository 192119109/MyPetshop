using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;

namespace PetShop
{
    public partial class Scanner : Form
    {
        public Scanner()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
    

        private void Scanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cbSource.Items.Add(device.Name);
            }
            cbSource.SelectedIndex = 0;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbSource.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if(result!=null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcode.Text = result.ToString();
                }));
            }
            pbBarcode.Image = bitmap;
        }

        private void Scanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }
    }
}
