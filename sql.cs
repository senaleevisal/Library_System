using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    internal class sql
    {
        public static SqlConnection ConnectToDatabase()
        {
            // Replace these with your actual database details
            string connectionString = "Server=localhost; Database=Library; User Id=root; Password=;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
    
}
