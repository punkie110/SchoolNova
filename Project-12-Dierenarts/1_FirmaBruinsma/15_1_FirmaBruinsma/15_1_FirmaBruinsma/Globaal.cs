using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _15_1_FirmaBruinsma
{
    class Globaal
    {
        // vaste connectie naar database
        public static OleDbConnection Connection = new OleDbConnection
            (@"Provider=Microsoft.ACE.OLEDB.12.0;
            data source = ..\\..\\..\\Bruinsma.accdb ; 
            Persist Security Info=False;");
    }
}
