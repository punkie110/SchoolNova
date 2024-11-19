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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_dierenarts
{
    public partial class TonenKlantgegevens : Form
    {
        public int klantId;
        public TonenKlantgegevens()
        {
            InitializeComponent();
        }
        public void LeesGegevens()
        {
            lbxOverzicht.DisplayMember = "volledigeNaam";
            lbxOverzicht.DataSource = Klant.GetAll();
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
                txtInfoVoorletters.Text = dbread.GetValue(1).ToString();
                txtInfoAchternaam.Text = dbread.GetValue(2).ToString();
                txtInfoAdres.Text = dbread.GetValue(3).ToString();
                txtInfoWoonplaats.Text = dbread.GetValue(4).ToString();
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();


        }
        public void wijzigKlantGegevens(int klantid)
        {
            //een nieuwe database connectie
            Globaal.Connection.Open();
            OleDbConnection con = new OleDbConnection();
            //een query die de klanten uit de database update
            string sql = "UPDATE Klanten SET klantvoorletters = @Voorletters, " +
                "klantachternaam = @Achternaam, klantadres = @Adres, " +
                "klantwoonplaats = @Woonplaats WHERE klantid = " +
                "@klantid";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //koppelt de parameters met de textboxes
            dbcom.Parameters.AddWithValue("@Voorletters", txtInfoVoorletters.Text);
            dbcom.Parameters.AddWithValue("@Achternaam", txtInfoAchternaam.Text);
            dbcom.Parameters.AddWithValue("@Adres", txtInfoAdres.Text);
            dbcom.Parameters.AddWithValue("@Woonplaats", txtInfoWoonplaats.Text);
            dbcom.Parameters.AddWithValue("@klantid", klantid);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Gewijzigd");
        }
   
        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxOverzicht.SelectedItem != null)
            {
                klantId = ((Klant)lbxOverzicht.SelectedItem).id;
                LadenKlantDetails(klantId);
            }
        }
        public void VerwijderKlantGegevens(int klantId)
        {
            Globaal.Connection.Open();
            //een Delete Query die een klant uit de database verwijderd.
            string sql = "DELETE FROM klanten WHERE [klantid] = @klantId";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //een parameter voor extra beveiliging.
            dbcom.Parameters.AddWithValue("@klantId", klantId);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            //hier wordt de listbox verversd zodat hij de meest recente gegevens pakt.
            LeesGegevens();
            MessageBox.Show("Verwijderd");
        }
        private void TonenKlantgegevens_Load(object sender, EventArgs e)
        {
            LeesGegevens();
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            InvoerKlantgegevens frm = new InvoerKlantgegevens();
            this.Close();
            frm.Show();
        }


        public void btnVerwijder_Click(object sender, EventArgs e)
        {
            VerwijderKlantGegevens(klantId);
        }

        private void btnwijzig_Click(object sender, EventArgs e)
        {
            if (lbxOverzicht.SelectedItem != null)
            {
                wijzigKlantGegevens(klantId);
                //ververst de listbox
                
                LeesGegevens();
            }
            else
            {
                MessageBox.Show("Kies eerst");
            }
        }

        private void btnBehandelingen_Click(object sender, EventArgs e)
        {
            TonenBehandelingen frm = new TonenBehandelingen(klantId);
            this.Close();
            frm.Show();
        }

        private void btnAlleBehandelingen_Click(object sender, EventArgs e)
        {
            ToonAlleBehandelingen frm = new ToonAlleBehandelingen();
            this.Close();
            frm.Show();
        }

        private void btnVoegBehandelingen_Click(object sender, EventArgs e)
        {
            ToevoegenBehandeling frm = new ToevoegenBehandeling(klantId);
            this.Close();
            frm.Show();
        }
    }
}
