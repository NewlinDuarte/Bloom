using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommentSection : MasterClass
    {
        public int CommentSectionId { get; set; }
        public int UploadId { get; set; }

        public CommentSection()
        {
            CommentSectionId = 0;
            UploadId = 0;
        }

        public CommentSection(int CommentSectionId, int UploadId)
        {
            this.CommentSectionId = CommentSectionId;
            this.UploadId = UploadId;
        }


        public override int Insert()
        {
            ConexionDb conection = new ConexionDb();
            int result = 0;

            try
            {
                result = Convert.ToInt32(conection.ObtenerValor(String.Format("Insert Into CommentSections (UploadId) Values ({0}); SELECT SCOPE_IDENTITY(); --", this.UploadId)));
            }
            catch
            {
                result = 0;
            }
            return result;
        }
        //CommentSections will always exist in the same upload which means editing and deleting are not possible
        public override bool Edit()
        {
            throw new NotImplementedException();
        }
        public override bool Delete()
        {
            throw new NotImplementedException();
        }


        public override bool Search(int SearchId)
        {
            ConexionDb conection = new ConexionDb();
            DataTable dt = new DataTable();

            try
            {
                dt = conection.ObtenerDatos(String.Format("Select * From CommentSections Where CommentSectionId = {0} --", SearchId));
                if (dt.Rows.Count > 0)
                {
                    this.CommentSectionId = (int)dt.Rows[0]["CommentSectionId"];
                    this.UploadId = (int)dt.Rows[0]["UploadId"];
                }
            }
            catch
            {
                return false;
            }
            return dt.Rows.Count > 0;
        }


        public override DataTable List(string Fields, string Condition, string Order)
        {
            ConexionDb conection = new ConexionDb();
            string FinalOrder = "";

            if (!Order.Equals(""))
            {
                FinalOrder = " Order by " + Order;
            }
            return conection.ObtenerDatos("select " + Fields + " from CommentSections where " + Condition + " " + FinalOrder + " --");
        }

        
    }
}
