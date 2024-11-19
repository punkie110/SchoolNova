using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkOperatorenBooleans4
{
    public partial class Form1 : Form
    {
        Random dobbelsteen = new Random();
        int dobbelsteenNummer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForLus_Click(object sender, EventArgs e)
        {
        int uitkomst = 0;

            for (int i = 0; i <= 6; i++)
            {
                dobbelsteenNummer = dobbelsteen.Next(1, 7);
                uitkomst += dobbelsteenNummer;
            }
            txtAantal.Text = uitkomst.ToString();
        }

        private void btnWhileLus_Click(object sender, EventArgs e)
        {
            int uitkomst = 0;
            int dobbelstenenCount = 0;
            while(dobbelstenenCount < 6)
            {
                dobbelsteenNummer = dobbelsteen.Next(1, 7);
                uitkomst += dobbelsteenNummer;
                dobbelstenenCount++;
            }
            txtAantal.Text= uitkomst.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           txtAantal.Clear();
        }
    }
}
