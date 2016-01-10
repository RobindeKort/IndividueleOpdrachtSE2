using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndividueleOpdrachtSE2.CSharp;

namespace IndividueleOpdrachtSE2.Pages.UserControls
{
    public partial class TeamMatch : System.Web.UI.UserControl
    {
        private Match match;

        public Match Match { get { return match; } set { match = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowVictorLoser();
            ShowMatchDuration();
        }

        private void ShowVictorLoser()
        {
            blueTeam.Text = match.BlueTeam.ToString();
            purpleTeam.Text = match.PurpleTeam.ToString();
            if (match.Victor == match.BlueTeam)
            {
                blueTeam.CssClass += " victor";
                purpleTeam.CssClass += " loser";
            }
            else
            {
                blueTeam.CssClass += " loser";
                purpleTeam.CssClass += " victor";
            }
        }

        private void ShowMatchDuration()
        {
            DateTime endTime = match.StartTime.Add(match.MatchDuration);
            duration.InnerText = match.StartTime + " - " + endTime;
        }
    }
}