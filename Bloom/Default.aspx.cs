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
                Random rnd = new Random();
                Upload upl = new Upload();
                DataTable dt = new DataTable();
                dt = upl.ListWithUser();

                if(dt.Rows.Count < 4)
                {
                    dt.Columns.Add("UploadId", typeof(int));
                    dt.Columns.Add("UserId", typeof(int));
                    dt.Columns.Add("Title", typeof(string));
                    dt.Columns.Add("Img", typeof(string));
                    while (dt.Rows.Count < 4)
                    {
                        var hyperlink = (HyperLink)RecentRepeater.FindControl("RecentHyperLink1");
                        hyperlink.NavigateUrl = "#";
                        var hyperlink1 = (HyperLink)RandomRepeater.FindControl("RandomHyperLink1");
                        hyperlink1.NavigateUrl = "#";
                        dt.Rows.Add(0,0,"","", "http://placehold.it/350x150");
                    }
                }
                RecentRepeater.DataSource = dt;
                RecentRepeater.DataBind();
                RandomRepeater.DataSource = dt;
                RandomRepeater.DataBind();



                }
                




            }
        }

    }
