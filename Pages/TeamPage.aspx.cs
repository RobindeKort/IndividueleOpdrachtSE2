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
    public partial class TeamPage : System.Web.UI.Page
    {
        private Administratie admin;
        private RankedTeam team;

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();
            LoadTeam();
            LoadMembers();
            LoadMatches();
        }

        private void LoadTeam()
        {
            string teamName = Request.QueryString["teamName"];
            foreach (RankedTeam t in admin.Teams)
            {
                if (t.TeamName == teamName)
                {
                    team = t;
                }
            }
            TeamName.InnerText = team.ToString();
            this.Title = team.ToString();
        }

        private void LoadMembers()
        {
            foreach (Player p in team.Members)
            {
                TeamPlayer teamPlayer = (TeamPlayer)LoadControl("UserControls/TeamPlayer.ascx");
                teamPlayer.Player = p;
                players.Controls.Add(teamPlayer);
            }
        }

        private void LoadMatches()
        {
            foreach (Match m in admin.Matches)
            {
                if (m.BlueTeam == team || m.PurpleTeam == team)
                {
                    TeamMatch teamMatch = (TeamMatch)LoadControl("UserControls/TeamMatch.ascx");
                    teamMatch.Match = m;
                    matches.Controls.Add(teamMatch);
                }
            }
        }
    }
}