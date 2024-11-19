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

        }

        // weergeven van klanten
        private void Overzichtklanten()
        {
            // maken verbinding
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            // opstellen query, telt het aantal gegevens in de database
            string sql = "SELECT COUNT(*) FROM klanten";
            
            // uitvoeren query
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
           
            // lezen gegevens uit database de ExecuteScalar laat een waarde zien als uitkomst van de query
            txtAantalKlanten.Text = dbcom.ExecuteScalar().ToString();
           
            // sluiten verbinding
            Globaal.Connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Overzichtklanten();

        }

        private void txtAantalKlanten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
