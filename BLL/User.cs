using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class User : MasterClass
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }



        public User()
        {
            UserId = 0;
            UserName = "";
            Password = "";
        }

        public User(int UserId, string UserName, string Password)
        {
            this.UserId = UserId;
            this.UserName = UserName;
            this.Password = Password;
        }

        public override int Insert()
        {
            ConexionDb conection = new ConexionDb();
            int result = 0;

            try
            {
                result = Convert.ToInt32(conection.ObtenerValor(String.Format("Insert Into Users (Created,UserName,Password) Values (GetDate(),'{0}', '{1}'); SELECT SCOPE_IDENTITY(); --", this.UserName, this.Password)));
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
                result = conection.Ejecutar(String.Format("Update Users Set UserName = '{0}', Password = '{1}' Where UserId = {2} --", this.UserName, this.Password, this.UserId));
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
                result = conection.Ejecutar(String.Format("Delete from Users Where UserId = {0} --", this.UserId));
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
                dt = conection.ObtenerDatos(String.Format("Select * From Users Where UserId = {0} --", SearchId));
                if (dt.Rows.Count > 0)
                {
                    this.UserId = (int)dt.Rows[0]["UserId"];
                    this.UserName = dt.Rows[0]["UserName"].ToString();
                    this.Password = dt.Rows[0]["Password"].ToString();
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
            return conection.ObtenerDatos("select " + Fields + " from Users where " + Condition + " " + FinalOrder + " --");

        }
    }
}
