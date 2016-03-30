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

           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Upload upl = new Upload();
            upl.Search(3);
            Image1.ImageUrl = upl.Image;
        }



        private void LoadImages()
        {
            
        }
        protected void GridViewUploadedImageFile_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           
        }
      
    }
    
}