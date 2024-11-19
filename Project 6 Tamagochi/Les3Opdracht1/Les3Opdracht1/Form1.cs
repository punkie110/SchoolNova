using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les3Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            if(btnBereken.Enabled )
            {
                if (int.Parse(txtAantal.Text) > 0)
                {
                    pbAantal.Value = int.Parse(txtAantal.Text);
                }
                else
                {
                    MessageBox.Show("Voer een geldige waarde in");
                }
            }
        }
    }
}
