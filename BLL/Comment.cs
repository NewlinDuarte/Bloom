using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Comment : MasterClass
    {
        public int CommentId { get; set; }
        public int CommentSectionId { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }

        public Comment()
        {
            CommentId = 0;
            CommentSectionId = 0;
            UserId = 0;
            Created = DateTime.Now;
            Content = "";
        }

        public Comment(int CommentId, int CommentSectionId, int UserId, DateTime Created, string Content)
        {
            this.CommentId = CommentId;
            this.CommentSectionId = CommentSectionId;
            this.UserId = UserId;
            this.Created = Created;
            this.Content = Content;
        }

        public override int Insert()
        {
            ConexionDb conection = new ConexionDb();
            int result = 0;

            try
            {
                result = Convert.ToInt32(conection.ObtenerValor(string.Format("Insert Into Comments (CommentSectionId,UserId,Created,Comment) Values ({0}, {1}, GetDate(),'{2}'); SELECT SCOPE_IDENTITY(); --", CommentSectionId, this.UserId, this.Content)));
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
                result = conection.Ejecutar(String.Format("Update Comments Set Content = '{0}' Where CommentId = {2} --", this.Content,  this.CommentId));
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
                result = conection.Ejecutar(String.Format("Delete from Comments Where CommentId = {0} --", this.CommentId));
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
                dt = conection.ObtenerDatos(String.Format("Select * From Comments Where CommentId = {0} --", SearchId));
                if (dt.Rows.Count > 0)
                {
                    this.CommentId = (int)dt.Rows[0]["CommentId"];
                    this.CommentSectionId = (int)dt.Rows[0]["CommentSectionId"];
                    this.UserId = (int)dt.Rows[0]["UserId"];
                    this.Created = (DateTime)dt.Rows[0]["Created"];
                    this.Content = dt.Rows[0]["Content"].ToString();
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
            return conection.ObtenerDatos("select " + Fields + " from Comments as c where " + Condition + " " + FinalOrder + " --");
        }

        public  DataTable commentSectionList(int commentSectionId)
        {
            ConexionDb conection = new ConexionDb();
            return conection.ObtenerDatos("select u.UserName as Name, c.Comment as Comment  from Comments as c inner join Users as u on u.UserId = c.UserId where CommentSectionId = " + commentSectionId);
        }

    }
}
