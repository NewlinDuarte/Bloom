using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using BLL;

namespace Bloom
{
    public partial class UploadPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (PhotoUpload.HasFile)
            {
                try
                {
                    Upload upl = new Upload();
                    upl.GalleryId = 1;
                    upl.Title = "Test";
                    string filename = Path.GetFileName(PhotoUpload.FileName);
                    PhotoUpload.SaveAs(Server.MapPath("~/Uploads/") + filename);
                    string url = Server.MapPath("~/Uploads/") + filename;
                    upl.Image = url;
                    if (upl.Insert())
                        Label1.Text = "Upload status: File uploaded!";
                }
                catch (Exception ex)
                {
                    Label1.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }


            }
        }
    }
}