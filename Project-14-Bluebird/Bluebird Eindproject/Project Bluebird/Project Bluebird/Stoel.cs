using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bluebird
{
    class Stoel
    {

        public int StoelNr { get; set; }

        public string StoelNaam { get; set; }

        public int Klasse { get; set; }

        //Totaal combineerd het stoelnummer en stoelnaam.
        public string Totaal { get { return StoelNr + " " + StoelNaam; } }

        //een Get all functie die alle stoelen ophaalt uit de database. 
        public static List<Stoel> GetAll()
        {
            List<Stoel> list = new List<Stoel>();
            OleDbDataReader dbread = null;
            Globaal.Connection.Open();
            string sql = "SELECT * FROM Stoel";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Stoel stoel = new Stoel();
                stoel.StoelNr = (int)dbread["Stoelnr"];
                stoel.StoelNaam = (string)dbread["Stoelnaam"];
              //  stoel.Klasse = (int)dbread["Klasse"];

                list.Add(stoel);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();
            return list;
        }
       
    }
}

