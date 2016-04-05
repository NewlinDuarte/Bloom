using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BLL
{
    public class Upload : MasterClass
    {
        public int UploadId { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }

        public Upload()
        {
            UploadId = 0;
            UserId = 0;
            Created = DateTime.Now;
            Title = "";
        }

        public Upload(int UploadId, int GalleryId, DateTime Created, string Title, string Image)
        {
            this.UploadId = UploadId;
            this.UserId = GalleryId;
            this.Created = Created;
            this.Title = Title;
            this.Image = Image;
        }

        public override int Insert()
        {
            ConexionDb conection = new ConexionDb();
            int result = 0;

            try
            {

                result = Convert.ToInt32(conection.ObtenerValor(string.Format("Insert Into Uploads (UserId,Created,Title,Img) Values ({0},GetDate(),'{1}','{2}'); SELECT SCOPE_IDENTITY(); --", UserId, Title,Image)));
            }
            catch
            {
                result = 0;
            }
            return result;
        }
        public override bool Edit()
        {
            ConexionDb conection = new ConexionDb();
            bool result = false;
            try
            {
                result = conection.Ejecutar(String.Format("Update Uploads Set UserId = '{0}', Title = '{1}' Where UploadId = {2} --", this.UserId, this.Title, this.UploadId));
            }
            catch
            {
                result = false;
            }
            return result;
        }
        public override bool Delete()
        {
            ConexionDb conection = new ConexionDb();
            bool result = false;
            try
            {
                result = conection.Ejecutar(String.Format("Delete from Uploads Where UploadId = {0} --", this.UploadId));
            }
            catch
            {
                result = false;
            }
            return result;
        }


        public override bool Search(int SearchId)
        {
            ConexionDb conection = new ConexionDb();
            DataTable dt = new DataTable();

            try
            {
                dt = conection.ObtenerDatos(String.Format("Select * From Uploads Where UploadId = {0} --", SearchId));
                if (dt.Rows.Count > 0)
                {
                    this.UploadId = (int)dt.Rows[0]["UploadId"];
                    this.UserId = (int)dt.Rows[0]["UserId"];
                    this.Created =  (DateTime)dt.Rows[0]["Created"];
                    this.Title = dt.Rows[0]["Title"].ToString();                       
                    this.Image = dt.Rows[0]["Img"].ToString();
                }
            }
            catch
            {
                return false;
            }
            return dt.Rows.Count > 0;
        }

        public DataTable ListWithUser(string searchId = "upl.UserId")
        {
            ConexionDb conection = new ConexionDb();
            DataTable dt = new DataTable();

            try
            {
                dt = conection.ObtenerDatos(String.Format("select upl.*, us.UserName from Uploads as upl inner join Users as us on us.UserId = {0} --", searchId));
                if (dt.Rows.Count > 0)
                {
                    this.UploadId = (int)dt.Rows[0]["UploadId"];
                    this.UserId = (int)dt.Rows[0]["UserId"];
                    this.Created = (DateTime)dt.Rows[0]["Created"];
                    this.Title = dt.Rows[0]["Title"].ToString();
                    this.Image = dt.Rows[0]["Img"].ToString();
                }
            }
            catch
            {
                dt.Clear();
                return dt;
            }
            return dt;
        }


        public override DataTable List(string Fields, string Condition, string Order)
        {
            ConexionDb conection = new ConexionDb();
            string FinalOrder = "";

            if (!Order.Equals(""))
            {
                FinalOrder = " Order by " + Order;
            }
            return conection.ObtenerDatos("select " + Fields + " from Uploads where " + Condition + " " + FinalOrder + " --");
        }


        

    }
}
