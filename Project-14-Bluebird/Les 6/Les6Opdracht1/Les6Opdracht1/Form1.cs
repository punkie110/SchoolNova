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

namespace Les6Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int StudentId;
        private void btnReservering_Click(object sender, EventArgs e)
        {
            lbxOverzicht.DisplayMember = "Totaal";
            lbxOverzicht.DataSource = Kluis.getOccupied();
            txtTotaal.Text = lbxOverzicht.Items.Count.ToString();
        }

        private void btnGeenReservering_Click(object sender, EventArgs e)
        {

        }

        private void txtTotaal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotaal_Click(object sender, EventArgs e)
        {

        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxOverzicht.SelectedIndex != -1)
            {
                txtStudentNr.Text = ((Kluis)lbxOverzicht.SelectedItem).StudentId.ToString();
                txtVoornaam.Text = ((Kluis)lbxOverzicht.SelectedItem).Voornaam.ToString();
                txtAchternaam.Text = ((Kluis)lbxOverzicht.SelectedItem).Achternaam.ToString();
                //cbxKlas.Text = ((Kluis)lbxOverzicht.SelectedItem)..ToString();
              //  cbxKluisNr.SelectedValue = ((Kluis)lbxOverzicht.SelectedItem).KluisNr.ToString();

                int index = 0;
                int klasIndex = 0;
                foreach (Klas klas in cbxKlas.Items)
                {
                    if (klas.Klascode == "")
                    {
                        klasIndex = index;
                    }

                    index++;
                }

                cbxKlas.SelectedIndex = klasIndex;


                index = 0;
                int kluisIndex = 0;
                foreach (Kluis KluisNr in cbxKluisNr.Items)
                {
                    if (KluisNr.KluisNr == ((Kluis)cbxKluisNr.SelectedItem).KluisNr)
                    {
                        kluisIndex = index;
                    }

                    index++;
                }

                cbxKluisNr.SelectedIndex = kluisIndex;
            }
        }

        private void btnInvoer_Click(object sender, EventArgs e)
        {
            Invoer frm = new Invoer();
            this.Hide();
            frm.Show();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {

        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxKlas.Items.Clear();
            cbxKlas.DataSource = Klas.getAll();
            cbxKlas.DisplayMember = "Klascode";
            cbxKluisNr.Items.Clear();
            cbxKluisNr.DataSource = Kluis.getAll();
            cbxKluisNr.DisplayMember = "Kluisnr";
        }
    }
}
