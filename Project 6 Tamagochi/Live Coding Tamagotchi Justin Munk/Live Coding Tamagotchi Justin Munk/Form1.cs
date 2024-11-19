using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Coding_Tamagotchi_Justin_Munk
{
    public partial class Form1 : Form
    {
        //Testcode A
        //twee variabelen die hier gedeclareerd worden om te weten hoeveel tv aansluitingen er zijn
        //en om de prijs per maand in op te slaan
        int tvAansluitingen;
        double prijsPermaand;
        public Form1()
        {
            InitializeComponent();
        }
        //een functie die de prijs berekent, met als parameter tv aansluitingen.
        private void BerekenPrijs(int tvAansluitingen)
        {
            //prijs per maand wordt hier gereset zodat
            //je het een tweede keer kan berekenen.
            prijsPermaand = 0;
            //kijkt welke radiobutton is aangevinkt.
            if(rdbInternetCompleet.Checked)
            {
                prijsPermaand += 59.95;
            }
            else if(rdbInternetMax.Checked)
            {
                prijsPermaand += 67.50;
            }
            //kijkt of er een checkbox is aangevinkt.
            if(chkMoviesSeries.Checked)
            {
                prijsPermaand += 11.95;
            }
            if(chkSafeOnline.Checked)
            {
                prijsPermaand += 6.95;
            }
            //kijkt hoeveel tv-aansluitingen er zijn. 
               prijsPermaand += tvAansluitingen * 2.50;
            txtPrijsPerMaand.Text = prijsPermaand.ToString();  
        }
        //wanneer er op de button geklikt wordt gebruikt hij de functie BerekenPrijs.
        private void btnBereken_Click(object sender, EventArgs e)
        {
            //een try catch blok waarin hij probeert de prijs te berekenen
            //en als dat niet lukt geeft hij een van de errors
            //in een messagebox die bij dat probleem hoort
            try
            {
                BerekenPrijs(int.Parse(txtTvAansluitingen.Text));
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
