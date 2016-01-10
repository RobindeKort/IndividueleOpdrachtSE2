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
    public partial class Forum : System.Web.UI.Page
    {
        Administratie admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();
            LoadDiscussions();
            LoadCategories();
        }

        private void LoadDiscussions()
        {
            string currentCategory = Convert.ToString(Request.QueryString["categoryName"]);
            if (currentCategory == null)
            {
                foreach (Discussion d in admin.Discussions)
                {
                    ForumPost forumPost = (ForumPost)LoadControl("UserControls/ForumPost.ascx");
                    forumPost.Discussion = d;
                    discussion.Controls.Add(forumPost);
                }
            }
            else
            {
                foreach (Discussion d in admin.Discussions)
                {
                    if (d.Category.CategoryName == currentCategory)
                    {
                        ForumPost forumPost = (ForumPost)LoadControl("UserControls/ForumPost.ascx");
                        forumPost.Discussion = d;
                        discussion.Controls.Add(forumPost);
                    }
                }
            }
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
    }
}