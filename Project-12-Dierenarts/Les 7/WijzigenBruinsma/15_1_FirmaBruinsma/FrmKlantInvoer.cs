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
    public partial class FrmKlantInvoer : Form
    {
        public FrmKlantInvoer()
        {
            InitializeComponent();
        }
     
        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            string voorletters = txtVoorletters.Text;
            string voorvoegsel = txtVoorvoegsel.Text;
            string achternaam = txtAchternaam.Text;
            string straat = txtStraat.Text;
            int huisnummer = int.Parse(txtHuisnummer.Text);
            string tHuisnummer = txtTHuisnummer.Text;
            string postcode = txtPostcode.Text;
            string woonplaats = txtWoonplaats.Text;
            string telefoon = txtTelefoon.Text;

            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();


            //string sql1 = "INSERT INTO Klanten (Voorletters,Tussenvoegsel,Achternaam,Straat,Huisnummer,[Toevoeging_huisnummer],Postcode,Woonplaats,Telefoon) VALUES ('" + voorletters + "','" + voorvoegsel + "','" + achternaam + "','" + straat + "','" + huisnummer + "','" + tHuisnummer+ "','" + postcode + "','" + woonplaats + "','" + telefoon + "')";
             string sql1 = "INSERT INTO Klanten (Voorletters,Tussenvoegsel,Achternaam,Straat,Huisnummer,[Toevoeging_huisnummer],Postcode,Woonplaats,Telefoon) VALUES (@Voorletters, @Tussenvoegsel, @Achternaam,@Straat, @Huisnummer, @tHuisnummer, @Postcode, @Woonplaats, @Telefoon )";
            OleDbCommand dbcom2 = new OleDbCommand(sql1, Globaal.Connection);

            dbcom2.Parameters.AddWithValue("@Voorletters", voorletters);
            dbcom2.Parameters.AddWithValue("@Tussenvoegsel", voorvoegsel);
            dbcom2.Parameters.AddWithValue("@Achternaam", achternaam);
            dbcom2.Parameters.AddWithValue("@Straat", straat);
            dbcom2.Parameters.AddWithValue("@Huisnummer", huisnummer);
            dbcom2.Parameters.AddWithValue("@tHuisnummer", tHuisnummer);
            dbcom2.Parameters.AddWithValue("@Postcode", postcode);
            dbcom2.Parameters.AddWithValue("@Woonplaats", woonplaats);
            dbcom2.Parameters.AddWithValue("@Telefoon", telefoon);
            dbcom2.ExecuteNonQuery();
            
            dbcom2.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Ingevoerd");
            this.Close();
            Form1.ActiveForm.Show();
          
             
            
         
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefoon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWoonplaats_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTHuisnummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHuisnummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStraat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAchternaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVoorvoegsel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVoorletters_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmKlantInvoer_Load(object sender, EventArgs e)
        {

        }
    }
}
