using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les8Opdracht2
{
   class Globaal
    {

        public static OleDbConnection Connection = new OleDbConnection
           (@"Provider=Microsoft.ACE.OLEDB.12.0;
            data source = ..\\..\\..\\Recepten.accdb ; 
            Persist Security Info=False;");
    }
}
