using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les2Opdracht2
{
    public partial class Form1 : Form
    {
        double loon = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            loon = 0;
            double bruto = double.Parse(txtBrutoLoon.Text);
            int artikelen = int.Parse(txtVerkochteArtikelen.Text);
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
    }
}
