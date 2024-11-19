using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace justin_Munk_While_Lus_4
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void btnstatistiek1tot10_Click(object sender, EventArgs e)
        {
            int i = 0;
            int totaal = 0;
            double herhalingen = 0;
            while (i < 10)
            {
                lbx0tot9.Items.Add(i);
                totaal += i;
                herhalingen++;
                i++;
            }
            txtTotaal1.Text = totaal.ToString();
            txtGemiddelde1.Text= (totaal / herhalingen).ToString();
           
        }

        private void btnstatistiek90tot100_Click(object sender, EventArgs e)
        {
            int i = 90;
            int totaal = 0;
            int herhalingen = 0;
            while (i <= 100)
            {
                lbx90tot100.Items.Add(i);
                totaal += i;
                herhalingen++;
                i++;
            }
            txtTotaal2.Text = totaal.ToString();
            txtGemiddelde2.Text = (totaal / herhalingen).ToString();
        }

        private void btnstatistiek100tot90_Click(object sender, EventArgs e)
        {
            int i = 100;
            int totaal = 0;
            int herhalingen = 0;
            while (i >= 90) 
            {
            lbx100tot90.Items.Add(i);
                totaal += i;
                herhalingen++;
                i--;
            }
            txtTotaal3.Text = totaal.ToString();
            txtGemiddelde3.Text = (totaal / herhalingen).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
