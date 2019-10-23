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
            
            string strConnection = ConfigurationManager.ConnectionStrings["DAM_Compartido_DEVConnectionString"].ToString();
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                
                string query = "Moto.IdDelNick";

                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Nick", tbUser.Text);
                Int32 id;


                
                sqlConnection.Open();
                SqlDataReader sqlreader = cmd.ExecuteReader();
                if (sqlreader.Read())
                {
                   id = sqlreader.GetInt32(0);

                }
                else
                {
                    id = 0;
                }
                sqlreader.Close();
                
                string query2 = "Moto.PassConNick";
                SqlCommand cmd2 = new SqlCommand(query2, sqlConnection);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@Id", id);
                string pass;
                SqlDataReader sqlreader2 = cmd2.ExecuteReader();
                if (sqlreader2.Read())
                {
                    pass = sqlreader2.GetString(0);

                }
                else
                {
                    pass = "ERROR";
                }

                if (pass.Equals(tbPass.Text))
                {
                    Response.Redirect("~\\HomePageAfterLogin.aspx");
                }
                else
                {
                    Response.Write("<script>Alert(\"Mal!!\")");
                    
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            entra();
        }
    }
}