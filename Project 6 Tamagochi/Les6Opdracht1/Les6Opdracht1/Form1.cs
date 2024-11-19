using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les6Opdracht1
{
    public partial class Form1 : Form
    {
        private int _score = 10;
        public Form1()
        {
            InitializeComponent();

        }
        private void BerekenProgressie()
        {
            try
            {
                _score = int.Parse(txtScore.Text);
                pbScore.Value = _score;
            }
            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }
        private void btnBereken_Click(object sender, EventArgs e)
        {
            BerekenProgressie();
        }

        private void timerForLus_Tick_1(object sender, EventArgs e)
        {
            try
            {
                pbScore.Value = _score;
                if (_score == 0)
                {
                    MessageBox.Show("BOEM!");
                    timerForLus.Stop();
                }
                else
                {
                    _score--;
                }
            }
            catch (System.DivideByZeroException boodschap)
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

