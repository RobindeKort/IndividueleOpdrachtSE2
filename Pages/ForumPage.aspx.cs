using IndividueleOpdrachtSE2.CSharp;
using IndividueleOpdrachtSE2.Pages.UserControls;
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
        // Nieuwe instantie van 'Administratie' aanmaken
        private Administratie admin;
        // Dit is de geselecteerde 'Discussion'
        private Discussion discussion;

        public Discussion Discussion { get { return discussion; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();
            // Haalt de geselecteerde 'Discussion' uit de query string die in de URL zit
            LoadDiscussion();
            // Laadt alle 'Categories' aan de linkerkant van het scherm
            LoadCategories();
            // Laadt alle 'Comments' die bij de geselecteerde 'Discussion' horen
            LoadComments();
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
            this.Title = discussion.ToString();
        }

        private void LoadCategories()
        {
            foreach (Category c in admin.Categories)
            {
                ForumCategory forumCategory = (ForumCategory)LoadControl("UserControls/ForumCategory.ascx");
                forumCategory.Category = c;
                category.Controls.Add(forumCategory);
            }
        }

        private void LoadComments()
        {
            comments.Controls.Clear();
            if (discussion != null)
            {
                foreach (DiscussionComment c in discussion.Comments)
                {
                    CommentControl comment = (CommentControl) LoadControl("UserControls/CommentControl.ascx");
                    comment.Comment = c;
                    comments.Controls.Add(comment);
                }
            }
        }

        protected void submit(object sender, EventArgs e)
        {
            foreach (User u in admin.Users)
            {
                if (u.LoginName == (string)Session["loginName"])
                {
                    User writer = u;
                    DiscussionComment comment = new DiscussionComment(0, writer, tbxComment.Text, DateTime.Now, discussion.DiscussionID);
                    admin.AddComment(comment);
                    //admin.RefreshDiscussions();
                    //LoadComments();
                    //tbxComment.Text = "";
                    Response.Redirect(Request.Url.ToString());
                    return;
                }
            }
            Response.Write("<script language=\"javascript\">alert('Invalid User!');</script>");
        }
    }
}