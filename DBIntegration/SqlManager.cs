using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBIntegration
{
    public static class SqlManager
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Test; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}
