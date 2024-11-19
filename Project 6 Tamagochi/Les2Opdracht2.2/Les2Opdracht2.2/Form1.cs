using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les2Opdracht2._2
{
    public partial class Form1 : Form
    {
       private double loon = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void geefLoon(double bruto, int artikelen)
        {
            if (artikelen < 10)
            {
                bruto *= 1.02;
            }
            else if (artikelen >= 10 && artikelen < 50)
            {
                bruto *= 1.05;
            }
            else
            {
                bruto *= 1.1;
            }
            loon += bruto;
            txtLoon.Text = loon.ToString();
        }
        private void btnBereken_Click(object sender, EventArgs e)
        {
            geefLoon(double.Parse(txtBrutoLoon.Text), int.Parse(txtVerkochteArtikelen.Text));
        }

        private void txtLoon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrutoLoon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVerkochteArtikelen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLoon_Click(object sender, EventArgs e)
        {

        }

        private void lblArtikelen_Click(object sender, EventArgs e)
        {

        }

        private void lblBrutoLoon_Click(object sender, EventArgs e)
        {

        }
    }
}
