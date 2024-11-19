using System;
using System.Windows.Forms;

namespace Tamagotchi_eindproject_Bramagotchii
{
    public partial class Form1 : Form
    {
        private int eten = 100;
        private int drinken = 100;
        private int gezondheid = 100;
        private int afbeelding = 1;
        private int punten;
        public Form1()
        {
            InitializeComponent();
            pbGezondheid.Value = gezondheid;
            pbEten.Value = eten;
            pbDrinken.Value = drinken;
        }

        private void btnEten_Click(object sender, EventArgs e)
        {
          
            eten += 5;
                tmrCountdown.Start();
            pnlTuto1.Hide();
            pnlTuto2.Hide();
            
          
        }

        private void btnDrinken_Click(object sender, EventArgs e)
        {
         
            tmrCountdown.Start();
            pnlTuto1.Hide();
            pnlTuto2.Hide();
            drinken += 5;
                
          
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            punten++;
            lblPoints.Text = punten.ToString();
            if (eten > 100)
            {
                eten = 100;
            }
            else if (drinken > 100)
            {
                drinken = 100;
            }
            if (eten >= 0)
            {
                pbEten.Value = eten;
               
                eten--;
               
            }
            if(drinken >= 0)
            {
                pbDrinken.Value = drinken;
                drinken--;
            }
          if (eten <= 0 && drinken <= 0)
            {
                gezondheid--;
                pbGezondheid.Value = gezondheid;
            }
     
            switch (afbeelding)
            {
                case 1:
                    pbxBram.Image = Properties.Resources.BramEureka;
                    pbxBram.Refresh();
                    break;
                case 2:
                    pbxBram.Image = Properties.Resources.BramJolly;
                    pbxBram.Refresh();
                    break;
                case 3:
                    pbxBram.Image = Properties.Resources.BramRizz;
                    pbxBram.Refresh();
                    break;

                case 4:
                    pbxBram.Image = Properties.Resources.BramNormal;
                    pbxBram.Refresh();
                    break;
                case 5:
                    pbxBram.Image = Properties.Resources.BramAngy;
                    pbxBram.Refresh();
                    break;
                case 6:
                    pbxBram.Image = Properties.Resources.bramsteen1;
                    pbxBram.Refresh();
                    break;
            }
            if(gezondheid < 80 && gezondheid > 60)
            {
                afbeelding = 2;
            }
            else if(gezondheid <= 60 && gezondheid > 40)
            {
                afbeelding = 3;
            }
            else if(gezondheid <= 40 && gezondheid > 20)
            {
                afbeelding = 4;
            }
            else if (gezondheid <= 20 && gezondheid > 1)
            {
                afbeelding = 5;
            }
            else if(gezondheid == 1)
            {
                    afbeelding = 6;
                
            }

            else if(gezondheid == 0)
            {
                tmrCountdown.Stop();
                MessageBox.Show("Womp Womp, Bramagotchi is dood. Je totale punten: " + punten);
                Application.Restart();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlBegin.Hide();
        }
    }
}
