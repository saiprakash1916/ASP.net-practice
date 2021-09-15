using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCCreateCategoryEvent.Models
{
    public class EventBo
    {
        string connectionString = null;
        public EventBo()
        {
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }
        public List<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Event", connection);
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    events.Add(new Event(int.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString()));
                }
                connection.Close();
            }
            return events;
        }
        public List<Event> GetAllEventsByType(string Type)
        {
            List<Event> events = new List<Event>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Stall where Category = '" + Type + "'", connection);
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    events.Add(new Event(int.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString()));
                }
                connection.Close();
            }
            return events;
        }
        public int CreateEvent(Event events)
        {
            int noOfRecords = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("sp_CreateEvent", connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", events.Name);
                sqlCommand.Parameters.AddWithValue("@Type", events.Type);
                sqlCommand.Parameters.AddWithValue("@Organizer", events.Organizer);
                noOfRecords = sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            return noOfRecords;
        }
    }
}