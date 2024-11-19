using JustinMunkEindopdrachtBommenGranaten.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkEindopdrachtBommenGranaten
{
    public partial class Form1 : Form
    {
        PictureBox[] dobbelstenen = new PictureBox[8];
        PictureBox[] uitleg = new PictureBox[6];
        PictureBox[] tutorial = new PictureBox[2];
        int totalePunten = 0;
        int pogingen = 0;
        public Form1()
        {
            
            InitializeComponent();
            pnlTutorial.Hide();
            dobbelstenen[0] = pbxDobbel1;
            dobbelstenen[1] = pbxDobbel2;
            dobbelstenen[2] = pbxDobbel3;
            dobbelstenen[3] = pbxDobbel4;
            dobbelstenen[4] = pbxDobbel5;
            dobbelstenen[5] = pbxDobbel6;
            dobbelstenen[6] = pbxDobbel7;
            dobbelstenen[7] = pbxDobbel8;
            uitleg[0] = pbxUitleg1;
            uitleg[1] = pbxUitleg2;
            uitleg[2] = pbxUitleg3;
            uitleg[3] = pbxUitleg4;
            uitleg[4] = pbxUitleg5;
            uitleg[5] = pbxUitleg6;
            tutorial[0] = pbxTutorial;
            tutorial[1] = pbxTutorial2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                dobbelstenen[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for(int i = 0; i < 6;i++)
            {
                uitleg[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for (int i = 0; i < 2; i++)
            {
                tutorial[i].SizeMode= PictureBoxSizeMode.StretchImage;
            }
           pbxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnGooi_Click(object sender, EventArgs e)
        {
            pogingen++;
            int countAap = 0;
            int countCoin = 0;
            int countSabers = 0;
            int countCockatoo = 0;
            int countDiamant = 0;
            int countSchedel = 0;
            Random dobbelen = new Random();
            int punten = 0;
            
            for (int i = 0; i < 8; i++)
            {
              int dobbel = dobbelen.Next(1, 7);
                
                switch (dobbel)
                {
                    case 1:
                        dobbelstenen[i].Image = Resources.aap;
                        countAap++;
                        break;
                    case 2:
                        dobbelstenen[i].Image = Resources.Coin;
                        punten += 100;
                        countCoin++;
                        break;
                    case 3:
                        dobbelstenen[i].Image = Resources.lightsabers;
                        countSabers++;
                        break;
                    case 4:
                        dobbelstenen[i].Image = Resources.cockatoo;
                        countCockatoo++;
                        break;
                    case 5:
                        dobbelstenen[i].Image= Resources.diamantWitte4;
                        countDiamant++;
                        punten += 100;
                        break;
                    case 6:
                        dobbelstenen[i].Image = Resources.schedel;
                        countSchedel++;
                        break;
                        }
               
            }
            if (countAap == 3 || countSabers == 3 || countCockatoo == 3)
            {
                punten += 100;
            }
            else if (countAap == 4 || countSabers == 4 || countCockatoo == 4)
            {
                    punten += 200;
            }
            else if (countAap == 5 || countSabers == 5 || countCockatoo == 5)
            {
                punten += 500;
            }
            else if (countAap == 6 || countSabers == 6 || countCockatoo == 6)
            {
                punten += 1000;
            }
            else if (countAap == 7 || countSabers == 7 || countCockatoo == 7)
            {
                punten += 2000;
            }
            else if (countAap == 8 || countSabers == 8 || countCockatoo == 8)
            {
                punten += 4000;
            }
            if(countSchedel == 0)
            {
                punten += 500;
            }
            if (countSchedel == 3)
            {
                punten = 0;
            }
            totalePunten += punten;
            lblScoreGetal.Text = totalePunten.ToString();
            lblScoreErbij.Text = "+" + punten;
            if (totalePunten >= 6000)
            {
                MessageBox.Show("Gefeliciteerd! Uw totale pogingen zijn: " + pogingen.ToString());
                Application.Restart();
            }
        }

        private void pbxTutorial_Click(object sender, EventArgs e)
        {
            pnlTutorial.Show();
        }
        private void pbxTutorial2_Click(object sender, EventArgs e)
        {
            pnlTutorial.Hide();
        }

    }
}
