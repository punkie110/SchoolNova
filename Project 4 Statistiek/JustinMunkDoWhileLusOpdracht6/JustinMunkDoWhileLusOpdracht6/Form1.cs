using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinMunkDoWhileLusOpdracht6
{
    public partial class Form1 : Form
    {
        private int gekozenGetal;
        private Random random;
        private int targetNummer;
        int pogingen = 0;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            targetNummer = random.Next(1, 101);
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           txtGetal.Clear();
           txtPogingen.Clear();
           txtResultaat.Clear();
            pbxResultaat.Image = Properties.Resources.guessthenumber;
            pbxResultaat.Refresh();
            targetNummer = random.Next(1, 101);
            pogingen = 0;
        }

        private void btnResultaat_Click(object sender, EventArgs e)
        {
            gekozenGetal = int.Parse(txtGetal.Text);

            if (gekozenGetal < targetNummer)
            {
                txtResultaat.Text = "Het getal is te laag. Probeer opnieuw.";
                pbxResultaat.Image = Properties.Resources.vewyvewyangy;
                pbxResultaat.Refresh();
                pogingen++;
            }
            else if (gekozenGetal > targetNummer)
            {
                txtResultaat.Text = "Het getal is te hoog. Probeer opnieuw.";
                pbxResultaat.Image = Properties.Resources.thinkmark;
                pbxResultaat.Refresh();
                pogingen++;
            }
            else
            {
                txtResultaat.Text = "Gefeliciteerd! Je hebt het juiste getal geraden: " + targetNummer;
                pbxResultaat.Image = Properties.Resources.homelanderpeace;
                pbxResultaat.Refresh();
            }
            txtPogingen.Text = pogingen.ToString();
        }
    }
}
