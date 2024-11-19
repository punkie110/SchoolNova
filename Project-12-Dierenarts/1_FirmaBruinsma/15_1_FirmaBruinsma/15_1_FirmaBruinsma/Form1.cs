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

            // opstellen query
            string sql = "SELECT * FROM klanten";
            
            // uitvoeren query
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            OleDbDataReader dbread = null;

            // lezen gegevens uit database
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                lbxOverzicht.Items.Add(dbread.GetValue(1).ToString() 
                + " " + dbread.GetValue(2).ToString() 
                + " " + dbread.GetValue(3).ToString());
            }

            // sluiten verbinding
            dbread.Close();
            Globaal.Connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Overzichtklanten();
           
        }
    }
}
