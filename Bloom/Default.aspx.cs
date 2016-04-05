using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace Bloom
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Random rnd = new Random();
                //Upload upl = new Upload();
                //DataTable dt = new DataTable();
                //dt = upl.ListWithUser();
                //int x = 0;
                //x = rnd.Next(dt.Rows.Count);
                //RandomLabel1.Text = dt.Rows[x]["Title"].ToString();
                //RandomImage1.ImageUrl = dt.Rows[x]["Img"].ToString();
                //RandomHyperLink1.NavigateUrl = "~/ViewImagePage.aspx?ImageId=" + dt.Rows[x]["UploadId"].ToString();

                //x = rnd.Next(dt.Rows.Count);
                //RandomLabel2.Text = dt.Rows[x]["Title"].ToString();
                //RandomImage2.ImageUrl = dt.Rows[x]["Img"].ToString();
                //RandomHyperLink2.NavigateUrl = "~/ViewImagePage.aspx?ImageId=" + dt.Rows[x]["UploadId"].ToString();

                //x = rnd.Next(dt.Rows.Count);
                //RandomLabel3.Text = dt.Rows[x]["Title"].ToString();
                //RandomImage3.ImageUrl = dt.Rows[x]["Img"].ToString();
                //RandomHyperLink3.NavigateUrl = "~/ViewImagePage.aspx?ImageId=" + dt.Rows[x]["UploadId"].ToString();

                //x = rnd.Next(dt.Rows.Count);
                //RandomLabel4.Text = dt.Rows[x]["Title"].ToString();
                //RandomImage4.ImageUrl = dt.Rows[x]["Img"].ToString();
                //RandomHyperLink4.NavigateUrl = "~/ViewImagePage.aspx?ImageId="+ dt.Rows[x]["UploadId"].ToString();

                
                //RecentImage1.ImageUrl = dt.Rows[0]["Img"].ToString();
                //RecentHyperLink1.NavigateUrl = "~/ViewImagePage.aspx?ImageId=" + dt.Rows[0]["UploadId"].ToString();

                //RecentImage2.ImageUrl = dt.Rows[1]["Img"].ToString();
                //RecentHyperLink2.NavigateUrl = "~/ViewImagePage.aspx?ImageId=" + dt.Rows[1]["UploadId"].ToString();

                //RecentImage3.ImageUrl = dt.Rows[2]["Img"].ToString();
                //RecentHyperLink3.NavigateUrl = "~/ViewImagePage.aspx?ImageId=" + dt.Rows[2]["UploadId"].ToString();

                //RecentImage4.ImageUrl = dt.Rows[3]["Img"].ToString();
                //RecentHyperLink4.NavigateUrl = "~/ViewImagePage.aspx?ImageId=" + dt.Rows[3]["UploadId"].ToString();




            }
        }

    }
}