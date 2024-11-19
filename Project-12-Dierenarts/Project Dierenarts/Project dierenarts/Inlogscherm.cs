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

namespace Project_dierenarts
{
    public partial class Inlogscherm : Form
    {
        public Inlogscherm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            int t = 0;
            //hier opent hij de connectie naar de database
            Globaal.Connection.Open();
            OleDbDataReader dbread = null;
            //hier schrijft hij een query die de gebruikersnamen en de wachtwoorden uit de database halen
            string sql = "SELECT * FROM medewerker WHERE gebruikerid = " +
                "@gebruikersnaam AND wachtwoord = @wachtwoord";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //parameters voor extra beveiliging
            OleDbParameter param1 = new OleDbParameter();
            param1.ParameterName = "@gebruikersnaam";
            param1.Value = txtGebruikersnaam.Text;

            OleDbParameter param2 = new OleDbParameter();
            param2.ParameterName = "@wachtwoord";
            param2.Value = txtWachtwoord.Text;

            dbcom.Parameters.Add(param1);
            dbcom.Parameters.Add(param2);

            dbread = dbcom.ExecuteReader();
            //een int die omhoog gaat als dbread een true meegeeft
            while (dbread.Read())
            {
                t++;
            }
            //als dbread.read dus true is verhoogt hij t met 1 waardoor hij het klantenscherm laat zien
            if (t == 1)
            {
                Globaal.Connection.Close();
                MessageBox.Show("ingelogd");
                TonenKlantgegevens frm = new TonenKlantgegevens();
                this.Hide();
                frm.Show();
              
            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord is onjuist.");
            }
            Globaal.Connection.Close();
        }
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
