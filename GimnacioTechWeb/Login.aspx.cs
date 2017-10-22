﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsuariosBLL.Autenticar(NombreUsuarioTextBox.Text, ClaveTextBox.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(NombreUsuarioTextBox.Text, true);             
            }
        }
    }
}