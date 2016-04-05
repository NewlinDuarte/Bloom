using BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Bloom
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(!(Session["user"] == null))
                {
                    var UserName = (HyperLink)LoginView.FindControl("UserName");
                    UserName.Text = "Welcome " + Session["user"].ToString();
                }
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            var UserNameTextBox = (TextBox)LoginView.FindControl("UserNameTextBox");
            var PasswordTextBox = (TextBox)LoginView.FindControl("PasswordTextBox");
            
            if(user.ConfirmLogin(UserNameTextBox.Text, PasswordTextBox.Text)>0)
            {
                Session["user"] = user.UserName;
                Session["userId"] = user.UserId;
                FormsAuthentication.RedirectFromLoginPage(user.UserName, true);             
            }

        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();           
        }

       
    }
}
