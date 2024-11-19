using Les5Opdracht1;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les5Opdracht1
{
    class Kluis
    {
        public int KluisNr { get; set; }
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
    }
    
}
