using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;

namespace Bloom
{
    public partial class ViewImagePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillData();
            }
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Upload upl = new Upload();
            upl.Search(3);
            Image1.ImageUrl = upl.Image;
        }

        protected void SubmitButton_Click1(object sender, EventArgs e)
        {
            Comment comment = new Comment();
            comment.Content = CommentTextBox.Text.ToString().Trim();
            comment.CommentSectionId = 1;
            comment.UserId = 1;
            if (comment.Insert() > 0) {
                CommentTextBox.Text = "";
            }          
        }



        private void LoadImages()
        {
            
        }
        protected void GridViewUploadedImageFile_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           
        }

        private void fillData()
        {
            Comment comment = new Comment();
            DataTable dt = new DataTable();
            dt = comment.commentSectionList(1);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }
      
    }
    
}