using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class  MasterClass
    {

        public abstract int Insert();

        public abstract bool Edit();

        public abstract bool Delete();

        public abstract bool Search(int SearchId);

        public abstract DataTable List(string Fields, string Condition, string Order);
    }
}
