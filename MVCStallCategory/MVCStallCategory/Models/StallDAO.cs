using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCStallCategory.Models
{
    public class StallDAO
    {
        string connectionString = null;
        public StallDAO()
        {
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }
        public List<Stall> GetAllStalls()
        {
            List<Stall> stallList = new List<Stall>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Stall", connection);
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    stallList.Add(new Stall(int.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(),sdr[4].ToString()));
                }
                connection.Close();
            }
            return stallList;
        }
        public List<Stall> GetStallsByCategory(string category)
        {
            List<Stall> stallList = new List<Stall>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Stall where Category = '"+category+"'", connection);
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    stallList.Add(new Stall(int.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString()));
                }
                connection.Close();
            }
                return stallList;
        }
    }
}