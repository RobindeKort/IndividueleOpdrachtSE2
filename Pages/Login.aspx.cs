using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndividueleOpdrachtSE2.CSharp;

namespace IndividueleOpdrachtSE2.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        // Maakt een nieuwe instantie van 'Administratie' aan
        private Administratie admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();

            // Toont een bevestiging wanneer de gebruiker uitlogt
            if (Request.Url.ToString().EndsWith("?logout"))
            {
                Response.Write("<script language=\"javascript\">alert('" + "You have succesfully logged out!" + "');</script>");
            }
        }

        protected void btnInloggen_Click(object sender, EventArgs e)
        {
            // Wanneer de gebruiker de correcte gegevens invoert en op de
            // Log In knop drukt, wordt hij/zij ingelogd. Indien de gegevens
            // niet kloppen, wordt er een toepasselijke melding getoond
            foreach (User u in admin.Users)
            {
                if (u.LoginName == tbxInputUsername.Text)
                {
                    if (u.Password == tbxInputPassword.Text)
                    {
                        Session["loginName"] = tbxInputUsername.Text;
                        Response.Redirect("Index.aspx");
                    }
                    errorLabel.Text = "Incorrect Password";
                    return;
                }
            }
            errorLabel.Text = "Incorrect Username";
        }
    }
}