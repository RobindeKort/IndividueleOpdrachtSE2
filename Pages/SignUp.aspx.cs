using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndividueleOpdrachtSE2.CSharp;

namespace IndividueleOpdrachtSE2.Pages
{
    public partial class SignUp : System.Web.UI.Page
    {
        private Administratie admin;

        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new Administratie();

            if (!Page.IsPostBack)
            {
                ddlRegion.DataSource = admin.Regions;
                ddlRegion.DataBind();
            }

            if (Request.Url.ToString().EndsWith("?success"))
            {
                Response.Write("<script language=\"javascript\">alert('" + "User has succesfully been created!" + "');</script>");
            }
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            int temp;
            if (tbxDay.Text == "" || tbxMonth.Text == "" || tbxYear.Text == "")
            {
                errorLabel.Text = "Please Enter Your Birthday";
            }
            else if (!Int32.TryParse(tbxDay.Text, out temp) ||
                     !Int32.TryParse(tbxMonth.Text, out temp) ||
                     !Int32.TryParse(tbxYear.Text, out temp))
            {
                errorLabel.Text = "Invalid Date of Birth";
            }
            else
            {
                string name = tbxInputUsername.Text;
                string password = tbxInputPassword.Text;
                string email = tbxInputEmail.Text;
                Region region = null;
                foreach (Region r in admin.Regions)
                {
                    if (r.Name == ddlRegion.SelectedValue)
                    {
                        region = r;
                        break;
                    }
                }
                DateTime dob = new DateTime(Convert.ToInt32(tbxYear.Text),
                                            Convert.ToInt32(tbxMonth.Text),
                                            Convert.ToInt32(tbxDay.Text));
                bool newsletter = cbxNews.Checked;
                NormalUser user = new NormalUser(name, password, email, region, dob, newsletter);
                if (!admin.AddUser(user))
                {
                    errorLabel.Text = "Username is already taken";
                    tbxInputUsername.Text = "";
                    return;
                }
                Response.Redirect("SignUp.aspx?success");
                //tbxInputUsername.Text = "";
                //tbxInputPassword.Text = "";
                //tbxInputEmail.Text = "";
                //tbxDay.Text = "";
                //tbxMonth.Text = "";
                //tbxYear.Text = "";
            }
        }
    }
}