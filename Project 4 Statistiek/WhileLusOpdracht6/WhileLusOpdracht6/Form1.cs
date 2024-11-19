using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileLusOpdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeefStatistiek_Click(object sender, EventArgs e)
        {
            int van = int.Parse(txtVan.Text);
            int tot = int.Parse(txtTot.Text);
            int totaal = 0;
            int count = 0;
            if (chkTotEnMet.Checked)
            {
                while (van >= tot)
                {
                  lbxCijfers.Items.Add(van);
                    van--;
                    totaal += van;
                    count++;
                }
            }
            else
            {
                while(van > tot)
                {
                    lbxCijfers.Items.Add(van);
                    van--;
                    totaal += van;
                    count++;
                }
            }
            txtTotaal.Text = totaal.ToString();
            txtGemiddelde.Text = (totaal/count).ToString();
        }

        private void btnWis_Click(object sender, EventArgs e)
        {
            txtTotaal.Clear();
            txtGemiddelde.Clear();
            lbxCijfers.Items.Clear();
            txtVan.Clear();
            txtTot.Clear();
        }
    }
}
