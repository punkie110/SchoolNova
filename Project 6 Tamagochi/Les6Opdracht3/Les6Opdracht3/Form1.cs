using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les6Opdracht3
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
            double value = ((double)aantal / totaal) * 100;
            int result = (int)value;
            pbValue.Value = result;

        }
        private void btnBereken_Click_1(object sender, EventArgs e)
        {
            try
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
            catch (System.DivideByZeroException boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
            catch (System.IndexOutOfRangeException boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
            catch (System.ArgumentException boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }
    }
}
