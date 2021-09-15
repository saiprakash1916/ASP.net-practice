using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HallParadise
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * from GetAllUsers",connection);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataList1.DataSource = dt;
            DataList1.DataBind();
            connection.Close();
        }
    }
}