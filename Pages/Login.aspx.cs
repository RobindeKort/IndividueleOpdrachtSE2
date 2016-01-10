using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndividueleOpdrachtSE2.CSharp;

namespace IndividueleOpdrachtSE2.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        private Administratie admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();

            if (Request.Url.ToString().EndsWith("?logout"))
            {
                Response.Write("<script language=\"javascript\">alert('" + "You have succesfully logged out!" + "');</script>");
            }
        }

        protected void btnInloggen_Click(object sender, EventArgs e)
        {
            foreach (User u in admin.Users)
            {
                if (u.LoginName == tbxInputUsername.Text)
                {
                    if (u.Password == tbxInputPassword.Text)
                    {
                        Session["loginName"] = tbxInputUsername.Text;
                        Response.Redirect("Index.aspx");
                    }
                    errorLabel.Text = "Incorrect Password";
                    return;
                }
            }
            errorLabel.Text = "Incorrect Username";
        }
    }
}