using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndividueleOpdrachtSE2.CSharp;
using IndividueleOpdrachtSE2.Pages.UserControls;

namespace IndividueleOpdrachtSE2.Pages
{
    public partial class Teams : System.Web.UI.Page
    {
        private Administratie admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();
            LoadTeams();
        }

        private void LoadTeams()
        {
            foreach (RankedTeam t in admin.Teams)
            {
                TeamControl teamControl = (TeamControl)LoadControl("UserControls/TeamControl.ascx");
                teamControl.Team = t;
                teams.Controls.Add(teamControl);
            }
        }
    }
}