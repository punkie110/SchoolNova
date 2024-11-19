using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkOpdrachtGeldautomaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNeemGeldOp_Click(object sender, EventArgs e)
        {
            double opneemBedrag = double.Parse(txtGeldOpnemen.Text);
            double saldo = double.Parse(txtHuidigSaldo.Text);
            try
            {
                if(opneemBedrag <= saldo)
                {
                    saldo -= opneemBedrag;
                    txtHuidigSaldo.Text = saldo.ToString();
                }
                else
                {
                    MessageBox.Show("Saldo is te laag!");
                }
            }
            catch
            {
                MessageBox.Show("voer een geldige waarde in.");
            }
        }
    }
}
