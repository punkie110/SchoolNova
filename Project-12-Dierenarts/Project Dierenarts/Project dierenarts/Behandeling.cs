using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_dierenarts
{
    internal class Behandeling
    {
        public int Id { get; set; }
        public string Omschrijving { get; set; }
        public string Prijs {  get; set; }

        public override string ToString()
        {
            return this.Omschrijving;
        }

        public static List<Behandeling> GetAll()
        {
            List<Behandeling> list = new List<Behandeling> ();

            //maakt een nieuwe database connectie
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();
            //een nieuwe query die alle klanten ophaalt
            string sql = "SELECT * FROM behandelingen";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //zet de waardes van de database gelijk aan de textboxes
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Behandeling behandeling = new Behandeling ();
                behandeling.Id = (int)dbread.GetValue(0);
                behandeling.Omschrijving = dbread.GetValue(1).ToString();
                behandeling.Prijs = dbread.GetValue(2).ToString();
                list.Add(behandeling);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static List<Behandeling> GetByKlantId(int klantId)
        {
            List<Behandeling> list = new List<Behandeling>();

            //maakt een nieuwe database connectie
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();
            //een nieuwe query die alle klanten ophaalt
            string sql = "SELECT b.* FROM behandelingen b, behandelregel r WHERE r.behandelingscode = b.id AND [klantid] = @klantId"; ;
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //zet de waardes van de database gelijk aan de textboxes
            dbcom.Parameters.AddWithValue("@klantId", klantId);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Behandeling behandeling = new Behandeling();
                behandeling.Id = (int)dbread.GetValue(0);
                behandeling.Omschrijving = dbread.GetValue(1).ToString();
                behandeling.Prijs = dbread.GetValue(2).ToString();
                list.Add(behandeling);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
    }
}
