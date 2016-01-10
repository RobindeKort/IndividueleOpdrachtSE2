using IndividueleOpdrachtSE2.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace IndividueleOpdrachtSE2.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        private Administratie admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();

            ShowName();
        }

        private void ShowName()
        {
            string loginName = (string)Session["loginName"];
            if (loginName != null)
            {
                foreach (User u in admin.Users)
                {
                    if (u.LoginName == loginName)
                    {
                        HtmlGenericControl p = new HtmlGenericControl("p");
                        p.InnerText = u.ToString();
                        name.Controls.Add(p);
                        break;
                    }
                }
            }
        }
    }
}