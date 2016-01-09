using IndividueleOpdrachtSE2.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IndividueleOpdrachtSE2.Pages
{
    public partial class ForumPage : System.Web.UI.Page
    {
        private Administratie admin;
        private Discussion discussion;

        public Discussion Discussion { get { return discussion; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();
            LoadDiscussion();
        }

        private void LoadDiscussion()
        {
            int discussionID = Convert.ToInt32(Request.QueryString["discussionID"]);
            foreach (Discussion d in admin.Discussions)
            {
                if (d.DiscussionID == discussionID)
                {
                    discussion = d;
                }
            }
        }
    }
}