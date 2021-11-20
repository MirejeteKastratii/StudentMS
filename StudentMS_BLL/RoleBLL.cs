using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_DAL;

namespace StudentMS_BLL
{
   public class RoleBLL
    {
        RoleDAL roliDAL = new RoleDAL();
        public DataTable GetRoles()
        {
            return roliDAL.GetRoles();
        }
    }
}
