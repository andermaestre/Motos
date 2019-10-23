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
    public partial class SignIn : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btn_alta_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nick = tbaNick.Text;
            string nombre = tbaNombre.Text;
            string apellido = tbaApellido.Text;
            string pass = tbaPass.Text;
            string pass2 = tbaPass2.Text;

            string query = "Moto.InsertUsers";
            string strConnection = ConfigurationManager.ConnectionStrings["DAM_Compartido_DEVConnectionString"].ToString();
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nick", nick);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Pass", pass);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}