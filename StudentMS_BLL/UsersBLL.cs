using StudentMS_BO;
using StudentMS_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BLL
{
    public class UsersBLL
    {
        private readonly UsersDAL usersDAL;
        public UsersBLL()
        {
            usersDAL = new UsersDAL();
        }

        public DataTable ShowUsers()
        {
            return usersDAL.GetUsersList();
        }
        public bool DeleteUser(int ID)
        {
            return usersDAL.DeleteUsers(ID);
        }
        public void AddUsers(UsersBO model)
        {
             usersDAL.InsertUsers(model);
        }
        public UsersBO GetUserByID(int id)
        {
            return usersDAL.GetUserByID(id);
        }
        public void EditUsers(UsersBO model)
        {
            usersDAL.UpdateUsers(model);
        }
    }
}
