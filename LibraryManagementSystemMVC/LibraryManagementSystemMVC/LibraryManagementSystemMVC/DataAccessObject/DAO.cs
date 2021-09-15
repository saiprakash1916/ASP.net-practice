using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Library_Management_System.DataAccessObject
{
    public class DAO
    {
        SqlConnection connection;
        String connectionString = "";
        public DAO()
        {
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            
        }
        public SqlConnection GetSqlConnection()
        {
            connection = new SqlConnection(connectionString);
            return connection;
        }


    }
}