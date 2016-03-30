using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class Gallery : MasterClass
    {
        public int GalleryId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public Gallery()
        {
            GalleryId = 0;
            UserId = 0;
            Name = "";
        }

        public Gallery(int GalleryId, int UserId, string Name)
        {
            this.GalleryId = GalleryId;
            this.UserId = UserId;
            this.Name = Name;
        }


        public override int Insert()
        {
            ConexionDb conection = new ConexionDb();
            int result = 0;

            try
            {
                result = Convert.ToInt32(conection.ObtenerValor(String.Format("Insert Into Galleries (UserId,Name) Values ({0}, '{1}'); SELECT SCOPE_IDENTITY(); --", this.UserId, this.Name)));
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
                result = conection.Ejecutar(String.Format("Update Galleries Set UserId = {0}, Name = '{1}' Where GalleryId = {2} --", this.UserId, this.Name, this.GalleryId));
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
                result = conection.Ejecutar(String.Format("Delete from Galleries Where GalleryId = {0} --", this.GalleryId));
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
                dt = conection.ObtenerDatos(String.Format("Select * From Galleries Where GalleryId = {0} --", SearchId));
                if (dt.Rows.Count > 0)
                {
                    this.GalleryId = (int)dt.Rows[0]["GalleryId"];
                    this.UserId = (int)dt.Rows[0]["UserId"];
                    this.Name = dt.Rows[0]["Password"].ToString();
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
            return conection.ObtenerDatos("select " + Fields + " from Galleries where " + Condition + " " + FinalOrder + " --");
        }

    }
}
