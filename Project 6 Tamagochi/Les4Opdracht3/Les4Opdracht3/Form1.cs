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

namespace Les4Opdracht3
{
    public partial class Form1 : Form
    {
        private int _sec = 10;
        private int aantal = 1;
        public Form1()
        {
          
            InitializeComponent();
            pbReeks1.Value = 10;
            pbReeks2.Value = 10;
            pbReeks3.Value = 10;
            pbReeks4.Value = 10;
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            timer1.Start();
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            if (_sec == 0)
            {
                aantal++;
                _sec = 10;
            }
            else
            {
                _sec--;
            }
            switch (aantal)
            {
                case 1:
                    pbReeks1.Value = _sec;
                    break;
                case 2:
                    pbReeks2.Value = _sec;
                    break;
                case 3:
                    pbReeks3.Value = _sec;
                    break;
                case 4:
                    pbReeks4.Value = _sec;
                    break;
            }
        }
    }
}
