using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndividueleOpdrachtSE2.CSharp;

namespace IndividueleOpdrachtSE2.Pages.UserControls
{
    public partial class TeamPlayer : System.Web.UI.UserControl
    {
        private Player player;

        public Player Player { get { return player; } set { player = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}