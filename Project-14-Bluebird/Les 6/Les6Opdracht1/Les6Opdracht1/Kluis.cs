using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les6Opdracht1
{
    class Kluis
    {
        public int KluisNr { get; set; }
        public int StudentId { get; set; }
        public string Voornaam { get; set; }

        public string Achternaam { get; set; }
        public string Totaal { get { return StudentId + " " + Voornaam + " " + Achternaam; } }
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

            string sql = "SELECT Student.Studentid, Voornaam, Achternaam FROM (Student INNER JOIN Kluisreservering ON Student.Studentid = Kluisreservering.Studentid) INNER JOIN Kluis ON Kluisreservering.Kluisnr = Kluis.Kluisnr";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            OleDbDataReader dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Kluis kluis = new Kluis();
                //   kluis.KluisNr = (int)dbread["Kluisnr"];
                kluis.StudentId = (int)dbread["Studentid"];
                kluis.Voornaam = (string)dbread["Voornaam"];
                kluis.Achternaam = (string)dbread["Achternaam"];
                list.Add(kluis);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static void addKluisreservering(int kluisNr, int studentId)
        {
            try
            {
                Globaal.Connection.Open();
                //de insert into query die waardes toevoegd aan de database.
                string sql = "INSERT INTO Kluisreservering (kluisNr, studentId) VALUES (@kluisNr, " +
                 "@studentId)";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                //er zijn hier parameters gemaakt voor extra beveiliging
                //door de AddWithValue command geef je de parameters de waarde mee.
                dbcom.Parameters.AddWithValue("@kluisNr", kluisNr);
                dbcom.Parameters.AddWithValue("@studentId", studentId);

                dbcom.ExecuteNonQuery();
                dbcom.Dispose();
                Globaal.Connection.Close();
                MessageBox.Show("Ingevoerd");

            }
            catch (Exception ex)
            {
                Globaal.Connection.Close();
                return;
            }
        }
        public static void delete(int id)
        {
            Globaal.Connection.Open();
           
            string sql = "DELETE FROM Kluisreservering WHERE [Studentid] = @studentId";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbcom.Parameters.AddWithValue("@studentId", id);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Verwijderd");
        }
        public void editSelected(int id)
        {
            //een nieuwe database connectie
            Globaal.Connection.Open();
            OleDbConnection con = new OleDbConnection();
            //een query die de klanten uit de database update
            string sql = "UPDATE Kluisreservering SET Kluisnummer = @Kluisnummer, " +
                "WHERE Studentid = @Studentid";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //koppelt de parameters met de textboxes
            dbcom.Parameters.AddWithValue("@kluisnummer", KluisNr);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Gewijzigd");
        }
    }


}

