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
                int image = Convert.ToInt32(Request.QueryString["ImageId"]);
                Upload upl = new Upload();
                upl.Search(image);
                Image1.ImageUrl = upl.Image;
            }
            CommentSection cs = new CommentSection();           
            cs.SearchByImage(Convert.ToInt32(Request.QueryString["ImageId"]));
            fillData(cs.CommentSectionId);
        }

        protected void SubmitButton_Click1(object sender, EventArgs e)
        {
            CommentSection cs = new CommentSection();
            Comment comment = new Comment();
            var CommentTextBox = (TextBox)LoginView1.FindControl("CommentTextBox");
            comment.Content = CommentTextBox.Text.ToString().Trim();
            cs.SearchByImage(Convert.ToInt32(Request.QueryString["ImageId"]));           
            comment.CommentSectionId = cs.CommentSectionId;
            comment.UserId = (int)Session["userId"];
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

        private void fillData(int CommentSectionId)
        {
            Comment comment = new Comment();
            DataTable dt = new DataTable();
            dt = comment.commentSectionList(CommentSectionId);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }
      
    }
    
}