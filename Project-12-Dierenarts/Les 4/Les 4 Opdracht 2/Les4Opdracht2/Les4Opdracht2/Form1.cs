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

namespace Les4Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInlog_Click(object sender, EventArgs e)
        {
            //hier opent hij de connectie naar de database
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\inlogsysteem.accdb ";
            con.Open();
            OleDbDataReader dbread = null;
            //hier schrijft hij een query die de gebruikersnamen en de wachtwoorden uit de database halen
            string sql = "SELECT * FROM inlog WHERE gebruikersnaam = " +
                "@gebruikersnaam AND wachtwoord = @wachtwoord";
            OleDbCommand dbcom = new OleDbCommand(sql, con);
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
           

            if (dbread.HasRows)
            {
                MessageBox.Show("ingelogd");
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("niet ingelogd");
            }

        
    }
    }
}
