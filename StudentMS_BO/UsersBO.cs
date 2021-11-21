using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    public class UsersBO:Base
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int RoleID { get; set; }
        public UsersBO(string uName, string uPass, int role)
        {
            UserName = uName;
            UserPassword = uPass;
            RoleID = role;
        }
        public UsersBO()
        {

        }
        public UsersBO(int id,string uName, string uPass, int role)
        {
            ID = id;
            UserName = uName;
            UserPassword = uPass;
            RoleID = role;
        }
    }


}
