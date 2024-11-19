using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_dierenarts
{
    internal class Klant
    {
        public int id { get; set; }
        public string voorletters { get; set; }
        public string achternaam { get; set; }
        public string adres { get; set; }
        public string woonplaats { get; set; }

        public string volledigeNaam { get { return voorletters + achternaam; } }

        public static List<Klant> GetAll()
        {
            List<Klant> list = new List<Klant>();

            //maakt een nieuwe database connectie
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();
            //een nieuwe query die alle klanten ophaalt
            string sql = "SELECT * FROM klanten";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //zet de waardes van de database gelijk aan de textboxes
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Klant klant = new Klant();
                klant.id = (int)dbread.GetValue(0);
                klant.voorletters = dbread.GetValue(1).ToString();
                klant.achternaam = dbread.GetValue(2).ToString();
                klant.adres = dbread.GetValue(3).ToString();
                klant.woonplaats = dbread.GetValue(4).ToString();
                list.Add(klant);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
    }
}
