using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Bloom
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("~/Default.aspx");
                }else
                    UserNameTextBox.Text = Session["user"].ToString();
            }


        }

        protected void ChangeNameButton_Click(object sender, EventArgs e)
        {
            ChangePasswordButton.Enabled = false;
            UserNameTextBox.Enabled = true;
            CurrentPasswordTextBox.Enabled = true;
        }

        protected void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangeNameButton.Enabled = false;
            CurrentPasswordTextBox.Enabled = true;
            NewPasswordTextBox.Enabled = true;
            ConfirmPasswordTextBox.Enabled = true;
        }





        protected void CleanButton_Click(object sender, EventArgs e)
        {
            ChangePasswordButton.Enabled = true;
            ChangeNameButton.Enabled = true;
            UserNameTextBox.Enabled = false;
            CurrentPasswordTextBox.Enabled = false;
            NewPasswordTextBox.Enabled = false;
            ConfirmPasswordTextBox.Enabled = false;
        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {

            if (!ChangeNameButton.Enabled)
            {
                User user = new User();
                user.Search((int)Session["userId"]);

                if (CurrentPasswordTextBox.Text.Trim() == user.Password && NewPasswordTextBox.Text.Trim() == ConfirmPasswordTextBox.Text.Trim())
                {
                    user.Password = NewPasswordTextBox.Text.Trim();
                    if (user.Edit())
                    {
                        ResultLabel.Text = "Editing completed successfully!";
                        ResultLabel.Visible = true;
                    }
                }
            }
            else
            {
                User user = new User();
                user.Search((int)Session["userId"]);
                if (CurrentPasswordTextBox.Text.Trim() == user.Password)
                {
                    user.UserName = UserNameTextBox.Text.Trim();
                    if (user.Edit())
                    {
                        Session["user"] = user.UserName.ToString();
                        ResultLabel.Text = "Editing completed successfully!";
                        ResultLabel.Visible = true;
                    }
                        
                }
            }
        }

    }
}