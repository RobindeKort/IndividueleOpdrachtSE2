using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IndividueleOpdrachtSE2.Pages
{
    public partial class LeagueOfLegends : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wanneer een gebruiker ingelogd is:
            if (Session["loginName"] != null)
            {
                // Login wordt Logout
                btnLogin.Text = "Logout";
                // Pagina verwijst naar zichzelf met een langere URL zodat de pagina weet
                // dat de op dat moment ingelogde gebruiker uitgelogd moet worden
                btnLogin.NavigateUrl = "?logout";

                // Wanneer de gebruiker op de 'Logout' knop heeft gedrukt wordt de sessie leeggemaakt
                // en daarmee de gebruiker uitgelogd
                if (Request.Url.ToString().EndsWith("?logout"))
                {
                    Session.RemoveAll();
                    Response.Redirect("Login.aspx?logout");
                }
            }
        }
    }
}