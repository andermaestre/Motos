﻿using System;
using System.Collections.Generic;
using System.Configuration;
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
            String respus, resppa;
            //tbUser;//usuario introducido
            string conection = ConfigurationManager.ConnectionStrings[""].ToString();

            /*if (tbPass.Equals(resppa))
            {
                Response.Redirect("~/HomePageAfterLogin.aspx");
            }*/
        }
    }
}