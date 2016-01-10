using IndividueleOpdrachtSE2.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IndividueleOpdrachtSE2.Pages.UserControls
{
    public partial class ForumPost : System.Web.UI.UserControl
    {
        private Discussion discussion;

        public Discussion Discussion { get { return discussion; } set { discussion = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            string longurl = Request.Url.ToString().Substring(0, Request.Url.ToString().LastIndexOf('/')) + "/ForumPage.aspx";
            var uriBuilder = new UriBuilder(longurl);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["discussionID"] = Convert.ToString(discussion.DiscussionID);
            uriBuilder.Query = query.ToString();
            longurl = uriBuilder.ToString();

            HyperLink hyperlink = new HyperLink();
            hyperlink.NavigateUrl = longurl;
            hyperlink.Text = discussion.Title;
            titleLink.Controls.Add(hyperlink);
        }
    }
}