using IndividueleOpdrachtSE2.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IndividueleOpdrachtSE2.Pages
{
    public partial class Forum : System.Web.UI.Page
    {
        Administratie admin;
        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();
            LoadDiscussions();
        }

        private void LoadDiscussions()
        {
            foreach (Discussion d in admin.Discussions)
            {
                ForumPost forumPost = (ForumPost)LoadControl("UserControls/ForumPost.ascx");
                forumPost.Discussion = d;
                discussion.Controls.Add(forumPost);
            }
        }
    }
}