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
            if (Session["loginName"] != null)
            {
                btnLogin.Text = "Logout";
                btnLogin.NavigateUrl = "?logout";

                if (Request.Url.ToString().EndsWith("?logout"))
                {
                    Session.RemoveAll();
                    Response.Redirect("Login.aspx?logout");
                }
            }
        }
    }
}