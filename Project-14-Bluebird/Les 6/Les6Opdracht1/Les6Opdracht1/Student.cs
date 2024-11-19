using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les6Opdracht1
{
     class Student
    {
        public int Studentid { get; set; }
        public int Studentnummer { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Klascode { get; set; }
        public string Volledig { get { return Studentnummer + " " + Voornaam + " " + Achternaam + " " + Klascode; } }

        public static List<Student> getAll()
        {
            List<Student> list = new List<Student>();
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            string sql = "SELECT * FROM Student";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                Student student = new Student();
                student.Studentid = (int)dbread.GetValue(0);
                student.Studentnummer = (int)dbread.GetValue(1);
                student.Voornaam = dbread.GetValue(2).ToString();
                student.Achternaam = dbread.GetValue(3).ToString();
                student.Klascode = dbread.GetValue(4).ToString();
                list.Add(student);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static void addStudent(string voornaam, string achternaam, int studentnummer, string klas)
        {
            try
            {
                Globaal.Connection.Open();
                //de insert into query die waardes toevoegd aan de database.
                string sql = "INSERT INTO Student (Studentnummer, Voornaam, " +
                  "Achternaam, Klascode) VALUES (@studentnummer, " +
                 "@voornaam, @achternaam, @klas)";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                //er zijn hier parameters gemaakt voor extra beveiliging
                //door de AddWithValue command geef je de parameters de waarde mee.
                dbcom.Parameters.AddWithValue("@studentnummer", studentnummer);
                dbcom.Parameters.AddWithValue("@voornaam", voornaam);
                dbcom.Parameters.AddWithValue("@achternaam", achternaam);
                dbcom.Parameters.AddWithValue("@klas", klas);

                dbcom.ExecuteNonQuery();
                dbcom.Dispose();
                Globaal.Connection.Close();

            }
            catch (Exception ex)
            {
                Globaal.Connection.Close();
                return;
            }
        }
        public static List<Student> select(string klasSelected)
        {
            List<Student> list = new List<Student>();
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            string sql = "SELECT * FROM Student WHERE klascode = @klasSelected";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@klasSelected", klasSelected);
            dbread = dbcom.ExecuteReader();

            while (dbread.Read())
            {
                Student student = new Student();
                student.Klascode = (string)dbread["Klascode"];
                student.Studentnummer = (int)dbread["studentnummer"];
                student.Voornaam = (string)dbread["voornaam"];
                student.Achternaam = (string)dbread["achternaam"];
                list.Add(student);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static List<Student> getOne(string studentId)
        {
            List<Student> list = new List<Student>();
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            string sql = "SELECT * FROM Student WHERE Studentid = @studentId";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@studentId", studentId);
            dbread = dbcom.ExecuteReader();

            while (dbread.Read())
            {
                Student student = new Student();
                student.Klascode = (string)dbread["Klascode"];
                student.Studentnummer = (int)dbread["studentnummer"];
                student.Voornaam = (string)dbread["voornaam"];
                student.Achternaam = (string)dbread["achternaam"];
                list.Add(student);
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return list;
        }
        public static int getFirst()
        {
            int studentid = 0;

            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            string sql = "SELECT first(Studentid) as id FROM Student";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {

                studentid = (int)dbread["id"];

            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return studentid;
        }
        public void editSelected(int id)
        {
            //een nieuwe database connectie
            Globaal.Connection.Open();
            OleDbConnection con = new OleDbConnection();
            //een query die de klanten uit de database update
            string sql = "UPDATE Student SET Studentnummer = @Studentnummer, " +
                "Voornaam = @Voornaam, Achternaam = @Achternaam, " +
                "Klascode = @Klascode WHERE Studentid = " +
                "@Studentid";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            //koppelt de parameters met de textboxes
            dbcom.Parameters.AddWithValue("@Studentnummer", Studentnummer);
            dbcom.Parameters.AddWithValue("@Voornaam", Voornaam);
            dbcom.Parameters.AddWithValue("@Achternaam", Achternaam);
            dbcom.Parameters.AddWithValue("@Klascode", Klascode);
            dbcom.Parameters.AddWithValue("@Studentid", Studentid);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Gewijzigd");
        }
        public static void delete(int id)
        {
            Globaal.Connection.Open();

            string sql = "DELETE FROM Student WHERE [Studentid] = @studentId";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbcom.Parameters.AddWithValue("@studentId", id);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Verwijderd");
        }
        public static int getLast()
        {
            int studentid = 0;

            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            string sql = "SELECT last(Studentid) as id FROM Student";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);

            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                studentid = (int)dbread["id"];
            }
            dbread.Close();
            dbcom.Dispose();
            Globaal.Connection.Close();

            return studentid;
        }

    }
}
