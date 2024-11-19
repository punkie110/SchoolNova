using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les3Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void bereken()
        {
            pbValue.Maximum = 100;
            int aantal = int.Parse(txtAantal.Text);
            int totaal = int.Parse(txtTotaal.Text);
            //een hele rare error als ik het niet eerst convert naar double, het lijkt erop dat ik de enige ben die hier last van heeft
            double value = ((double)aantal / totaal) * 100;
            int result = (int)value;
            pbValue.Value = result;

        }
        private void btnBereken_Click(object sender, EventArgs e)
        {
            if (btnBereken.Enabled)
            {
                if (int.Parse(txtAantal.Text) > 0 && int.Parse(txtTotaal.Text) > 0)
                {
                     bereken();
                   
                }
                else  
               {
                    MessageBox.Show("Voer een geldige waarde in");
                }
            }
        }
    }
}
