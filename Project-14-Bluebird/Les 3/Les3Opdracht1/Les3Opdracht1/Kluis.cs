using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Les3Opdracht1
{
     class Kluis
    {
        public int KluisNr {  get; set; }
        public static List<Kluis> getAll()
        {
            List<Kluis> list = new List<Kluis>();

            Globaal.Connection.Open();

            string sql = "SELECT * FROM Kluis";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            OleDbDataReader dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Kluis kluis = new Kluis();
                kluis.KluisNr = (int)dbread["Kluisnr"];
                list.Add(kluis);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static List<Kluis> getAvailable()
        {
            List<Kluis> list = new List<Kluis>();

            Globaal.Connection.Open();

            string sql = "SELECT Kluisnr FROM Kluis WHERE Kluisnr NOT IN (SELECT Kluisnr FROM Kluisreservering)";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            OleDbDataReader dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Kluis kluis = new Kluis();
                kluis.KluisNr = (int)dbread["Kluisnr"];
                list.Add(kluis);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static List<Kluis> getOccupied()
        {
            List<Kluis> list = new List<Kluis>();

            Globaal.Connection.Open();

            string sql = "SELECT Kluis.Kluisnr FROM Kluis RIGHT JOIN Kluisreservering ON Kluis.Kluisnr = Kluisreservering.Kluisnr";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            OleDbDataReader dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Kluis kluis = new Kluis();
                kluis.KluisNr = (int)dbread["Kluisnr"];
                list.Add(kluis);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
    }
   
}
