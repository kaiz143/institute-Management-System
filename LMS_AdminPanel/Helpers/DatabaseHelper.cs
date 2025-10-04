using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LMS_AdminPanel.Helpers
{
     internal class DatabaseHelper
    {
        public static String ConnectionString = "Server=DESKTOP-UMCDN7D\\SQLEXPRESS;Database=LMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;\r\n";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
