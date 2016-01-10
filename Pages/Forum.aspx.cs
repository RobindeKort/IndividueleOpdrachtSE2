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

            ddlCategory.DataSource = admin.Categories;
            ddlCategory.DataBind();

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

        protected void btnDiscussion_Click(object sender, EventArgs e)
        {
            foreach (User u in admin.Users)
            {
                if (u.LoginName == (string)Session["loginName"])
                {
                    User writer = u;
                    Category category = null;
                    foreach (Category c in admin.Categories)
                    {
                        if (c.CategoryName == ddlCategory.SelectedValue)
                        {
                            category = c;
                        }
                    }
                    Discussion discussion = new Discussion(0, writer, category, tbxDiscussionTitle.Text, tbxDiscussionLink.Text, tbxDiscussion.Text, DateTime.Now);
                    admin.AddDiscussion(discussion);
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