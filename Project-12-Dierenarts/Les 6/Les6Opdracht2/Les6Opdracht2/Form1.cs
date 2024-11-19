using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Les6Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void VoegToe()
        {
            {
                string naam = txtNaam.Text;
                int ID = int.Parse(txtCategorie.Text);
                int bereidingstijd = int.Parse(txtBereidingstijd.Text);
                int aantal = int.Parse(txtHoeveel.Text);
                string ingredienten = txtIngredienten.Text;

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\Recepten.accdb ";
                con.Open();
                string sql1 = "INSERT INTO Recept ([naam recept], [Categorie-id], [bereidingstijd], [Hoeveel personen], [ingrediënten]) VALUES (@naam, @ID, @bereidingstijd, @aantal, @ingredienten)";
                OleDbCommand dbcom = new OleDbCommand(sql1, con);
                dbcom.Parameters.AddWithValue("@naam", naam);
                dbcom.Parameters.AddWithValue("@ID", ID);
                dbcom.Parameters.AddWithValue("@bereidingstijd", bereidingstijd);
                dbcom.Parameters.AddWithValue("@aantal", aantal);
                dbcom.Parameters.AddWithValue("@ingredienten", ingredienten);
                dbcom.ExecuteNonQuery();
                dbcom.Dispose();
                con.Close();
                MessageBox.Show("het recept is succesvol toegevoegd!");
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            VoegToe();
        }
    }
}
