using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 20;
            if (panel2.Width >= 700)
            {
                timer1.Stop();
                Autentikasi Auth = new Autentikasi();
                Auth.FormClosed += new FormClosedEventHandler(f_FormClosed);
                Auth.Show();
                this.Hide();
            }
        }
        
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }
    }
}
