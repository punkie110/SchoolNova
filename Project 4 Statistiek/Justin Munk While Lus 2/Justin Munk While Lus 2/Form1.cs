using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Justin_Munk_While_Lus_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10)
            {
                lbxCijfersNulTotNegen.Items.Add(i);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 90;
            while (i < 100)
            {
                lbxCijfersNegentigTotHonderd.Items.Add(i);
                i++;
            }
        }
    }
}
