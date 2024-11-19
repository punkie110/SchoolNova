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


        public Form1()
        {
            InitializeComponent();

           
        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            string woord = lbxOverzicht.SelectedItem.ToString();
            string[] woordenArray = woord.Split(' ');
            int klantid = int.Parse(woordenArray[0]);
            LadenKlantDetails(klantid);

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
            
                OleDbDataReader dbread = null;
                OleDbConnection con = new OleDbConnection();
                Globaal.Connection.Open();
                string sql = "SELECT * FROM recept WHERE Recept_id = @receptid";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                OleDbParameter param1 = new OleDbParameter();
                param1.ParameterName = "@receptid";
                param1.Value = klantid;
                dbcom.Parameters.Add(param1);
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
                OleDbDataReader dbread = null;
                OleDbConnection con = new OleDbConnection();
                Globaal.Connection.Open();
                string sql = "SELECT * FROM Recept";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                dbread = dbcom.ExecuteReader();
                while (dbread.Read())
                {
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
            //string sql = "UPDATE Klanten SET klantvoorletters  = @klantvoorletters , klantachternaam  = @klantachternaam, klantadres = @klantadres,klantwoonplaats = @klantwoonplaats WHERE Klantachternaam = @klantachternaam  ";
            //string sql = "UPDATE Klanten SET Voorletters ='" + txtVoorletters.Text + "', Tussenvoegsel =' " + txtVoorvoegsel.Text + "' , Achternaam ='" + txtAchternaam.Text + " ', Straat ='" + txtStraat.Text + "', Huisnummer ='" + txtHuisnummer.Text + " ',Postcode ='" + txtPostcode.Text + " ',Woonplaats ='" + txtWoonplaats.Text + " ',Telefoon ='" + txtTelefoon.Text + "' where Achternaam ='" + txtAchternaam.Text+"'";
        }

        public void WijzigKlantgegevens(int klantid)
        {
            Globaal.Connection.Open();
            OleDbConnection con = new OleDbConnection();
            string sql = "UPDATE Recept SET Voorletters = @Voorletters, " +
                "Tussenvoegsel = @Tussenvoegsel, Achternaam = @Achternaam, " +
                "Straat = @Straat, Huisnummer = @Huisnummer, Postcode = @Postcode, " +
                "Woonplaats = @Woonplaats, Telefoon = @Telefoon WHERE klantid = " +
                "@klantid";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@Voorletters", txtVoorletters.Text);
            dbcom.Parameters.AddWithValue("@Tussenvoegsel", txtVoorvoegsel.Text);
            dbcom.Parameters.AddWithValue("@Achternaam", txtAchternaam.Text);
            dbcom.Parameters.AddWithValue("@Straat", txtStraat.Text);
            dbcom.Parameters.AddWithValue("@Huisnummer", txtHuisnummer.Text);
            dbcom.Parameters.AddWithValue("@tHuisnummer", txtTHuisnummer.Text);
            dbcom.Parameters.AddWithValue("@Postcode", txtPostcode.Text);
            dbcom.Parameters.AddWithValue("@Woonplaats", txtWoonplaats.Text);
            dbcom.Parameters.AddWithValue("@Telefoon", txtWoonplaats.Text);
            dbcom.Parameters.AddWithValue("@klantid", klantid);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Gewijzigd");
        }

        private void btnwijzig_Click(object sender, EventArgs e)
        {
            

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            string woord = lbxOverzicht.SelectedItem.ToString();
            string[] woordenArray = woord.Split(' ');
            int klantid = int.Parse(woordenArray[0]);
            VerwijderKlantgegevens(klantid);
        }
        public void VerwijderKlantgegevens(int klantid)
        {
            Globaal.Connection.Open();
            OleDbConnection con = new OleDbConnection();
            string sql = "DELETE FROM Klanten WHERE klantid = @klantid";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@klantid", klantid);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Verwijderd");
        }
    }
}
