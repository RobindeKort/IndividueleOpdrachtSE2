using IndividueleOpdrachtSE2.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace IndividueleOpdrachtSE2.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        // Maakt een nieuwe instantie van 'Administratie' aan
        private Administratie admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();

            // Laat de naam van de op dat moment ingelogde gebruiker zien in de ASP:PlaceHolder
            ShowName();
            // Vult de ListBoxes met de bijbehorende gebruikers
            BindListBoxes();
        }

        private void ShowName()
        {
            string loginName = (string)Session["loginName"];
            if (loginName != null)
            {
                foreach (User u in admin.Users)
                {
                    if (u.LoginName == loginName)
                    {
                        HtmlGenericControl p = new HtmlGenericControl("p");
                        p.InnerText = "Logged in as: " + u.ToString();
                        name.Controls.Add(p);
                        break;
                    }
                }
            }
        }

        private void BindListBoxes()
        {
            lbxUsers.DataSource = admin.Normalusers;
            lbxUsers.DataBind();
            lbxPlayers.DataSource = admin.Players;
            lbxPlayers.DataBind();
            lbxEmployees.DataSource = admin.Employees;
            lbxEmployees.DataBind();
        }
    }
}