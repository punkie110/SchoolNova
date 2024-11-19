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

namespace _15_9_Inlogsysteem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInlog_Click(object sender, EventArgs e)
        {
            int t = 0;
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
            //een int die omhoog gaat als dbread een true meegeeft
            while (dbread.Read())
            {
                t++;
            }
            //als dbread.read dus true is verhoogt hij t met 1 waardoor hij het inlogscherm laat zien
            if (t == 1)
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

        private void txtGebruikersnaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
