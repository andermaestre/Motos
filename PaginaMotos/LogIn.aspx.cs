using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaMotos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void entra()
        {

            //tbUser;//usuario introducido
            int id;
            string strConnection = ConfigurationManager.ConnectionStrings["DAM_Compartido_DEVConnectionString"].ToString();
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                
                string query = "Moto.IdDelNick";

                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Nick", tbUser.Text);



                // string query2 = "EXEC Moto.ContraseXId " + id;
                sqlConnection.Open();
                SqlDataReader sqlreader = cmd.ExecuteReader();
                if (sqlreader.HasRows)
                {
                   id = int.Parse(sqlreader[0].ToString());
                }
                tbPass.Text = id.ToString();

                /*if (tbPass.Equals(resppa))
                {
                    Response.Redirect("~/HomePageAfterLogin.aspx");
                }*/
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            entra();
        }
    }
}