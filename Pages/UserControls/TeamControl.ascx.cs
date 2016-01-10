using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndividueleOpdrachtSE2.CSharp;

namespace IndividueleOpdrachtSE2.Pages.UserControls
{
    public partial class TeamControl : System.Web.UI.UserControl
    {
        private RankedTeam team;

        public RankedTeam Team { get { return team; } set { team = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            string longurl = Request.Url.ToString().Substring(0, Request.Url.ToString().LastIndexOf('/')) + "/TeamPage.aspx";
            var uriBuilder = new UriBuilder(longurl);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["teamName"] = team.TeamName;
            uriBuilder.Query = query.ToString();
            longurl = uriBuilder.ToString();

            HyperLink hyperlink = new HyperLink();
            hyperlink.NavigateUrl = longurl;
            hyperlink.Text = team.ToString();
            teamLink.Controls.Add(hyperlink);
        }
    }
}