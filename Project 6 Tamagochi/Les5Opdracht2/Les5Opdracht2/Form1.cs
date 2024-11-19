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

namespace Les5Opdracht2
{
    public partial class Form1 : Form
    {
        private int _sec = 6;
        private int afbeelding = 1;
        public Form1()
        {
            InitializeComponent();
            pbDobbel.Value = 6;
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbDobbel.Value = _sec;
        
            if (_sec == 0)
            {

            }
            else
            {
                _sec--;
                afbeelding++;
            }
            switch (afbeelding)
            {
                case 1: pbxDobbel.Image = Properties.Resources.Dobbelsteen_6;
                    pbxDobbel.Refresh();
                    break;
                case 2: pbxDobbel.Image = Properties.Resources.Dobbelsteen_5;
                    pbxDobbel.Refresh();
                    break;
                case 3: pbxDobbel.Image = Properties.Resources.Dobbelsteen_4;
                    pbxDobbel.Refresh();
                    break;

                case 4: pbxDobbel.Image =   Properties.Resources.dobbelsteen_3;
                    pbxDobbel.Refresh();
                    break;
                case 5: pbxDobbel.Image = Properties.Resources.Dobbelsteen_2;
                    pbxDobbel.Refresh();
                    break;
                case 6: pbxDobbel.Image = Properties.Resources.Dobbelsteen_1; 
                    pbxDobbel.Refresh();
                    break;
            }
        }
    }
}
