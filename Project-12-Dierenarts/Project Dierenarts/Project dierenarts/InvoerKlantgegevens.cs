using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_dierenarts
{
    public partial class InvoerKlantgegevens : Form
    {
        public InvoerKlantgegevens()
        {
            InitializeComponent();
        }

        private void btnVoerIn_Click(object sender, EventArgs e)
        {
            //maakt variabelen aan en geeft ze de waarde mee die in de textboxes staan. 
            string voorletters = txtVoorletters.Text;
            string achternaam = txtAchternaam.Text;
            string adres = txtAdres.Text;
            string woonplaats = txtWoonplaats.Text;
            //maakt een nieuwe database connectie.
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();
            //de insert into query die waardes toevoegd aan de database.
            string sql1 = "INSERT INTO Klanten (klantvoorletters,klantachternaam," +
                "klantadres, klantwoonplaats) VALUES (@Voorletters, " +
                "@Achternaam,@Adres, @Woonplaats)";
            OleDbCommand dbcom2 = new OleDbCommand(sql1, Globaal.Connection);
            //er zijn hier parameters gemaakt voor extra beveiliging
            //door de AddWithValue command geef je de parameters de waarde mee.
            dbcom2.Parameters.AddWithValue("@Voorletters", voorletters);
            dbcom2.Parameters.AddWithValue("@Achternaam", achternaam);
            dbcom2.Parameters.AddWithValue("@Adres", adres);
            dbcom2.Parameters.AddWithValue("@Woonplaats", woonplaats);
            dbcom2.ExecuteNonQuery();
            dbcom2.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Ingevoerd");
            TonenKlantgegevens frm = new TonenKlantgegevens();
            this.Close();
            frm.Show();

        }
    }
}
