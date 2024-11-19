using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les4Opdracht2
{
    public partial class Form1 : Form
    {
        private int _sec = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbAftellen.Value = _sec;

            // dit is onzin, nu laat hij meerdere messageboxes zien. Maar ik moest het overnemen dus hier is het.
            if (_sec == 0)
            {
                MessageBox.Show("BOEM!");
                timer1.Stop();
            }
            else
            {
                _sec--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
