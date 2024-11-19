using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les1Opdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVoerUit_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(txtAantal.Text);
            int vijftigCent = 0;
            int twintigCent = 0;
            int tienCent = 0;
            int vijfCent = 0;
            int eenCent = 0;
            while (aantal >= 50)
            {
                aantal -= 50;
                vijftigCent++;
            }
            while (aantal >= 20)
            {
                aantal -= 20;
                twintigCent++;
            }
            while (aantal >= 10)
            {
                aantal -= 10;
                tienCent++;
            }
            while (aantal >= 5)
            {
                aantal -= 5;
                vijfCent++;
            }
            while (aantal >= 1)
            {
                aantal--;
                eenCent++;
            }
           txt50cent.Text = vijftigCent.ToString();
            txt20cent.Text = twintigCent.ToString();
            txt10cent.Text = tienCent.ToString();
            txt5cent.Text = vijfCent.ToString();
            txt1cent.Text = eenCent.ToString();
        }
    }
}
