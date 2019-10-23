using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace PaginaMotos
{
    public partial class HomePageAfterLogin : System.Web.UI.Page
    {
        string strConnection = ConfigurationManager.ConnectionStrings["DAM_Compartido_DEVConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                string query = "SELECT meeting_name as Nombre,Desde,Hasta,Distancia,Fecha FROM Moto.Meetings ORDER BY MeetingID DESC";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddMeetingPage.aspx");
        }
    }
}