using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkWhileLus3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStatistiek1Tot10_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i < 10)
            {
                lbxEenTotTien.Items.Add(i);
                i++;
            }

        }

        private void btnStatistiek90Tot100_Click(object sender, EventArgs e)
        {
            int i = 90;
            while(i <= 100)
            {
                lbxNegentigTotHonderd.Items.Add(i);
                i++;
            }
        }

        private void btnStatistiek100Tot90_Click(object sender, EventArgs e)
        {
            int i = 100;
            while(i >= 90)
            {
                lbxHonderdTotNegentig.Items.Add(i);
                i--;
            }
        }
    }
}
