using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project.DataAccessObject
{
    public class DAOBook
    {
        SqlConnection connection = null;
        string connectionString = "";
        public DAOBook()
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