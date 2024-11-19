using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4opdracht1
{
 class Reservering
    {
        public int KluisNr { get; set; }
        public int StudentId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Totaal { get { return StudentId + " " + Voornaam + " " + Achternaam; } }

        public static List<Reservering> getAll()
        {
            List<Reservering> list = new List<Reservering>();

            Globaal.Connection.Open();

            string sql = "SELECT * FROM Kluis";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            OleDbDataReader dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Reservering reservering = new Reservering();
                reservering.KluisNr = (int)dbread["Kluisnr"];
                list.Add(reservering);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static List<Reservering> getAvailable()
        {
            List<Reservering> list = new List<Reservering>();

            Globaal.Connection.Open();

            string sql = "SELECT Studentid, Voornaam, Achternaam FROM Student WHERE Student.Studentid NOT IN (SELECT Student.Studentid FROM Student INNER JOIN Kluisreservering ON Student.Studentid = Kluisreservering.Studentid)";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            OleDbDataReader dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Reservering reservering = new Reservering();
                reservering.StudentId = (int)dbread["Studentid"];
                reservering.Voornaam = (string)dbread["Voornaam"];
                reservering.Achternaam = (string)dbread["Achternaam"];
                list.Add(reservering);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static List<Reservering> getOccupied()
        {
            List<Reservering> list = new List<Reservering>();

            Globaal.Connection.Open();

            string sql = "SELECT Student.Studentid, Voornaam, Achternaam FROM (Student INNER JOIN Kluisreservering ON Student.Studentid = Kluisreservering.Studentid) INNER JOIN Kluis ON Kluisreservering.Kluisnr = Kluis.Kluisnr";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            OleDbDataReader dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Reservering reservering = new Reservering();
                reservering.StudentId = (int)dbread["Studentid"];
                reservering.Voornaam = (string)dbread["Voornaam"];
                reservering.Achternaam = (string)dbread["Achternaam"];
                list.Add(reservering);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
    }
}
