using IndividueleOpdrachtSE2.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IndividueleOpdrachtSE2.Pages.UserControls
{
    public partial class CommentControl : System.Web.UI.UserControl
    {
        private Comment comment;

        public Comment Comment { get { return comment; } set { comment = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}