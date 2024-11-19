using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Opdracht1
{
     class Klas
    {

        public String klasSelected;
        public string Klascode { get; set; }
        public string opleiding { get; set; }

        public string weergaveNaam { get { return Klascode + " " + opleiding; } }

        public static List<Klas> getAll()
        {
            List<Klas> list = new List<Klas>();
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            string sql = "SELECT * FROM Opleiding";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Klas klas = new Klas();
                klas.Klascode = dbread.GetValue(0).ToString();
                klas.opleiding = dbread.GetValue(1).ToString();
                list.Add(klas);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static List<Klas> select(string klasSelected)
        {
            List<Klas> list = new List<Klas>();
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            string sql = "SELECT * FROM Opleiding WHERE klascode = @klasSelected";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@klasSelected", klasSelected);
            dbread = dbcom.ExecuteReader();

            while (dbread.Read())
            {
                Klas klas = new Klas();
                klas.Klascode = dbread.GetValue(0).ToString();
                klas.opleiding = dbread.GetValue(1).ToString();
                list.Add(klas);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
    }
}
