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

namespace _15_1_FirmaBruinsma
{
    public partial class Form1 : Form
    {
        int tempID;

        public Form1()
        {
            InitializeComponent();

            textBox1.Multiline = true;
            textBox1.Width = 300;
            textBox1.Height = 500;


        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hier pakt hij de klant en split hij de array zodat het leesbaar in verschillende textboxes kan komen
            string woord = lbxOverzicht.SelectedItem.ToString();
            string[] woordenArray = woord.Split(' ');
            int klantid = int.Parse(woordenArray[0]);
            LadenKlantDetails(klantid);
            tempID = klantid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           LeesGegevens();
        }
      

        private void btnNieuweKlant_Click(object sender, EventArgs e)
        {
            FrmKlantInvoer frm = new FrmKlantInvoer();
            frm.ShowDialog();
        }

        private void LadenKlantDetails(int klantid)
        {
            //maakt een nieuwe database connectie
                OleDbDataReader dbread = null;
                OleDbConnection con = new OleDbConnection();
                Globaal.Connection.Open();
            //een nieuwe query die alle klanten ophaalt
                string sql = "SELECT * FROM klanten WHERE klantid = @klantid";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                OleDbParameter param1 = new OleDbParameter();
            //parameter voor de beveiliging
                param1.ParameterName = "@klantid";
                param1.Value = klantid;
                dbcom.Parameters.Add(param1);
            //zet de waardes van de database gelijk aan de textboxes
                dbread = dbcom.ExecuteReader();
                while (dbread.Read())
                {
                    txtVoorletters.Text = dbread.GetValue(1).ToString();
                    txtVoorvoegsel.Text = dbread.GetValue(2).ToString();
                    txtAchternaam.Text = dbread.GetValue(3).ToString();
                    txtStraat.Text = dbread.GetValue(4).ToString();
                    txtHuisnummer.Text = dbread.GetValue(5).ToString();
                    txtWoonplaats.Text = dbread.GetValue(6).ToString();
                    txtPostcode.Text = dbread.GetValue(7).ToString();
                    txtWoonplaats.Text = dbread.GetValue(8).ToString();
                    txtTelefoon.Text = dbread.GetValue(9).ToString();
                }
                dbread.Close();
                dbcom.Dispose();
                Globaal.Connection.Close();
           
             
        }
        public void LeesGegevens()
        {
            //een nieuwe database connectie
                OleDbDataReader dbread = null;
                OleDbConnection con = new OleDbConnection();
                Globaal.Connection.Open();
            //een query die alle gegevens uit de database pakt
                string sql = "SELECT * FROM klanten";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                dbread = dbcom.ExecuteReader();
                while (dbread.Read())
                {
                //zet die items allemaal in de listbox
                    lbxOverzicht.Items.Add(dbread.GetValue(0).ToString() + " " 
                        + dbread.GetValue(1).ToString() + " " + 
                        dbread.GetValue(2).ToString() + " " + 
                        dbread.GetValue(3).ToString());
                }
                dbread.Close();
                dbcom.Dispose();
                Globaal.Connection.Close();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {

           
          

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LeesGegevens();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtTHuisnummer_TextChanged(object sender, EventArgs e)
        {
   
        }

        public void WijzigKlantgegevens(int klantid)
        {
            //een nieuwe database connectie
            Globaal.Connection.Open();
            OleDbConnection con = new OleDbConnection();
            //een query die de klanten uit de database update
            string sql = "UPDATE Klanten SET Voorletters = @Voorletters, " +
                "Tussenvoegsel = @Tussenvoegsel, Achternaam = @Achternaam, " +
                "Straat = @Straat, Huisnummer = @Huisnummer, [Toevoeging_huisnummer] = @tHuisnummer, Postcode = @Postcode, " +
                "Woonplaats = @Woonplaats, Telefoon = @Telefoon WHERE klantid = " +
                "@klantid";

            textBox1.Text = sql;
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //koppelt de parameters met de textboxes
            dbcom.Parameters.AddWithValue("@Voorletters", txtVoorletters.Text);
            dbcom.Parameters.AddWithValue("@Tussenvoegsel", txtVoorvoegsel.Text);
            dbcom.Parameters.AddWithValue("@Achternaam", txtAchternaam.Text);
            dbcom.Parameters.AddWithValue("@Straat", txtStraat.Text);
            dbcom.Parameters.AddWithValue("@Huisnummer", txtHuisnummer.Text);
            dbcom.Parameters.AddWithValue("@tHuisnummer", txtTHuisnummer.Text);
            dbcom.Parameters.AddWithValue("@Postcode", txtPostcode.Text);
            dbcom.Parameters.AddWithValue("@Woonplaats", txtWoonplaats.Text);
            dbcom.Parameters.AddWithValue("@Telefoon", txtTelefoon.Text);
            dbcom.Parameters.AddWithValue("@klantid", klantid);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close(); 
            MessageBox.Show("Gewijzigd");
        }

        private void btnwijzig_Click(object sender, EventArgs e)
        {
            if (lbxOverzicht.SelectedItem != null)
            {
                string woord = lbxOverzicht.SelectedItem.ToString();
                string[] woordenArray = woord.Split(' ');
                int klantid = int.Parse(woordenArray[0]);

                WijzigKlantgegevens(klantid);
                lbxOverzicht.Items.Clear();
                LeesGegevens();
            }
            else
            {
                MessageBox.Show("Kies eerst");
            }
        }


        private void txtStraat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
