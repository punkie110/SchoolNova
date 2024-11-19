using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Bluebird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Maakt het scherm fullscreen.
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        //declareerd twee variabelen. 
        string naam;
        int klasse;
        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            //sluit het programma af.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //een datasource en displaymember die de stoelnaam laat zien in de combobox.
            cbxStoelNummer.Items.Clear();
            cbxStoelNummer.DataSource = Stoel.GetAll();
            cbxStoelNummer.DisplayMember = "StoelNaam";
        }

        private void rdbFirst_CheckedChanged(object sender, EventArgs e)
        {
            //op basis van de radiobutton die is geselecteerd, haalt hij specifieke waardes op uit de database.
            klasse = 0;
            lbxClass.DisplayMember = "Totaal";
            lbxClass.DataSource = StoelMetPassagier.GetByKlasse(klasse);
        }

        private void rdbBusiness_CheckedChanged(object sender, EventArgs e)
        {
            klasse = 1;
            lbxClass.DisplayMember = "Totaal";
            lbxClass.DataSource = StoelMetPassagier.GetByKlasse(klasse);
        }

        private void rdbEconomy_CheckedChanged(object sender, EventArgs e)
        {
            klasse = 2;
            lbxClass.DisplayMember = "Totaal";
            lbxClass.DataSource = StoelMetPassagier.GetByKlasse(klasse);
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //controleerd eerst of de textbox leeg is.
            if(txtNaam.Text != null)
            {
                //Hier word een integer aangemaakt die de waardes van het geselcteerde stoelnummer uit de combobox meegeeft.
                int Index = ((Stoel)cbxStoelNummer.SelectedItem).StoelNr;

                //kijkt hier of er al een reservering is voor die stoel door middel van de check functie.
                bool count = Reservering.check(Index);
                if (count)
                {
                    //maakt een nieuwe passagier aan en de naam haalt hij op uit de textbox. 
                    Passagier passagier = new Passagier { Naam = txtNaam.Text };

                    //hier voegt hij de nieuwe passagier met de naam toe aan de database.
                    passagier.Insert();


                    //maakt een nieuwe reservering aan. 
                    Reservering reservering = new Reservering();
                    //hier stelt hij de passagierid van reservering gelijk aan de id van de laatst toegevoegde passagier. 
                    reservering.Passagierid = Passagier.getLast();
                    //hier stelt hij de stoelid van de passagier gelijk aan index (zie hierboven).
                    reservering.Stoelid = Index;
                    //Hier voegt hij de reservering toe aan de database.
                    reservering.Insert();
                    MessageBox.Show("Ingevoerd!");
                }
                else
                {
                    MessageBox.Show("Deze stoel is al gereserveerd.");
                }
                lbxClass.DisplayMember = "Totaal";
                lbxClass.DataSource = StoelMetPassagier.GetByKlasse(klasse);
            }
        }

        private void rdbAlle_CheckedChanged(object sender, EventArgs e)
        {
            lbxClass.DisplayMember = "Totaal";
            lbxClass.DataSource = StoelMetPassagier.GetAll();
        }

        private void lbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //als de geselcteerde index van de listbox is veranderd, controleerd hij hier of er wel iets is geselecteerd.
            if(lbxClass.SelectedIndex != -1)
            {
                //hij stelt een nieuwe string en integer Index en Passagiernaam hier gelijk aan de geselecteerde item uit de listbox.
                int Index = ((StoelMetPassagier)lbxClass.SelectedItem).StoelNr;
                string passagierNaam = ((StoelMetPassagier)lbxClass.SelectedItem).PassagierNaam;

                //roept hier de getbyid op zodat hij de volledige gegevens kan uitlezen op basis van het geselecteerde stoelnummer. 
                 StoelMetPassagier stoelMetPassagier = StoelMetPassagier.GetById(Index);
                
                //stelt de textbox gelijk met de passagiernaam uit de database.
                txtNaam.Text = passagierNaam;


                //een foreach loop omdat selecteditem niet werkt. Controleert welke item uit de listbox is geselecteerd en stopt hem dan in de combobox.
                int foundIndex = 0;
                int currentIndex = 0;
                foreach(Stoel stoel in cbxStoelNummer.Items)
                {
                    if (stoel.StoelNr == Index)
                    {
                        foundIndex = currentIndex;
                    }

                    currentIndex++;
                }
                cbxStoelNummer.SelectedIndex = foundIndex;
            }
        }

        private void btnVrijgeven_Click(object sender, EventArgs e)
        {
            //Leest hier de gegevens uit de listbox en roept dan de verwijder functies aan.
            string PassagierNaam = ((StoelMetPassagier)lbxClass.SelectedItem).PassagierNaam;
            int passagierId = ((StoelMetPassagier)lbxClass.SelectedItem).PassagierNummer;
            if(cbxStoelNummer.SelectedIndex != -1 && PassagierNaam != null)
            {
                Reservering.delete(passagierId);
                Passagier.delete(passagierId);
                MessageBox.Show("Verwijderd!");
                lbxClass.DisplayMember = "Totaal";
                lbxClass.DataSource = StoelMetPassagier.GetByKlasse(klasse);
            }
        }
    }
}

