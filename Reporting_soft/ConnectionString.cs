using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Reporting_soft
{
    public static class ConnectionString
    {
        public static SqlConnection MySqlConnection;
        public static SqlConnection GetConnection()
        {
            if (MySqlConnection == null)
            {
                MySqlConnection = new SqlConnection();
                MySqlConnection.ConnectionString = @"Data Source = DESKTOP-MM58A5G; Initial Catalog = Northwind; Integrated Security = True;";
                MySqlConnection.Open();
            }
            return MySqlConnection;
        }
    }
}