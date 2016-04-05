using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bloom
{
    public partial class UserCreation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(CompareValidator1.IsValid && RegularExpressionValidator2.IsValid && RegularExpressionValidator3.IsValid)
            {
                User user = new User();
                user.UserName = UserNameTextBox.Text.Trim();
                user.Password = PasswordTextBox.Text.Trim();
                if (user.Insert() > 0)
                    SuccessLabel.Text = "User created successfully";
                else
                    SuccessLabel.Text = "An error ocurred during the user creation process";
                SuccessLabel.Visible = true;
            }
        }

        protected void CleanButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";
            SuccessLabel.Visible = false;
        }
    }
}