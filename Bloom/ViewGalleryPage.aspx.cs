using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bloom
{
    public partial class ViewGalleryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Upload upl = new Upload();
            DataTable dt = new DataTable();
            
            if (Request.QueryString["UserId"] != null)
            {
                dt = upl.ListWithUser(Request.QueryString["UserId"].ToString());

            }
            else
            {
                dt = upl.ListWithUser();               
            }
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }
    }
}