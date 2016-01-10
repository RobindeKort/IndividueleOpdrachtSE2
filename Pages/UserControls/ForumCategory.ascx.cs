using IndividueleOpdrachtSE2.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IndividueleOpdrachtSE2.Pages.UserControls
{
    public partial class ForumCategory : System.Web.UI.UserControl
    {
        private Category category;
        private string currentCategory;

        public Category Category { get { return category; } set { category = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            currentCategory = Convert.ToString(Request.QueryString["categoryName"]);
            SelectCategory();
        }

        private void SelectCategory()
        {
            string longurl = Request.Url.ToString().Substring(0, Request.Url.ToString().LastIndexOf('/')) + "/Forum.aspx";
            var uriBuilder = new UriBuilder(longurl);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["categoryName"] = Category.CategoryName;
            uriBuilder.Query = query.ToString();
            longurl = uriBuilder.ToString();

            HyperLink hyperlink = new HyperLink();
            hyperlink.NavigateUrl = longurl;
            hyperlink.Text = category.CategoryName;
            hyperlink.CssClass = "list-group-item";
            
            if (currentCategory == category.CategoryName)
            {
                hyperlink.CssClass += " active";
            }

            categoryLink.Controls.Add(hyperlink);
        }
    }
}