using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio
{
    public partial class Form1 : Form
    {
        string[] text = {
            "Radio ZET                      ",
            "RFM FM Najlepsza Muzyka        ",
            "Radio Maryja                   ",
            "Radio Bielsko Siła Muzyki      "
        };

        int stacja = 0;
        int licznik = 0;
        int power = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            int licznik = VolumeBar.Value * 10;
            lblVolume.Text = licznik.ToString();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (power == 1)
            {
                lblDate.Text = DateTime.Now.ToString();
                lblDisplay.Text = text[stacja].Substring(0, licznik++ % text[stacja].Length);
            }

        }

        private void btnZET_Click(object sender, EventArgs e)
        {
            stacja = 0;
            licznik = 0;
        }

        private void btnMARYJA_Click(object sender, EventArgs e)
        {
            stacja = 2;
            licznik = 0;
        }

        private void btnVOX_Click(object sender, EventArgs e)
        {
            stacja = 3;
            licznik = 0;
        }

        private void btnRMF_Click(object sender, EventArgs e)
        {
            stacja = 1;
            licznik = 0;
        }

        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            power = 1;
            VolumeBar.Enabled = true;
            btnMARYJA.Enabled = true;
            btnVOX.Enabled = true;
            btnZET.Enabled = true;
            btnRMF.Enabled = true;
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            power = 0;
            VolumeBar.Enabled = false;
            btnMARYJA.Enabled = false;
            btnVOX.Enabled = false;
            btnZET.Enabled = false;
            btnRMF.Enabled = false;
        }

    }
}
