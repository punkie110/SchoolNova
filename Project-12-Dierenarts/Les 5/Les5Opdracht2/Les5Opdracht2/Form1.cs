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
namespace Les5Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Overzicht()
        {
            OleDbConnection con= new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\recepten.accdb ";
            con.Open();
            string sql = "SELECT COUNT(*) FROM Categorie";
            OleDbCommand dbcom = new OleDbCommand(sql, con);
            txtCategorieen.Text = dbcom.ExecuteScalar().ToString();
            string sql2 = "SELECT COUNT(*) FROM Recept";
            OleDbCommand dbcom2 = new OleDbCommand(sql2, con);
            txtRecepten.Text = dbcom2.ExecuteScalar().ToString();
            string sql3 = "SELECT COUNT(*) FROM Recept WHERE (Bereidingstijd <= 30)";
            OleDbCommand dbcom3 = new OleDbCommand(sql3, con);
            txtBereidingstijd.Text = dbcom3.ExecuteScalar().ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Overzicht();
        }

        private void txtCategorieen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
