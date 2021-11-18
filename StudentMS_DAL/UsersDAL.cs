using StudentMS_BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_DAL
{
    public class UsersDAL
    {
        public DataTable GetUsersList()
        {
            using (DbConn.conn = new SqlConnection(DbConn.connString))
            {
                DbConn.dataAdapter = new SqlDataAdapter("usp_UsersList", DbConn.conn);
                DataTable dt = new DataTable();
                DbConn.dataAdapter.Fill(dt);
                return dt;
            }
        }
        //procedura per deletekrijon konfilkt me role id
        public bool DeleteUsers(int ID)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_DeleteUsers", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", ID);

                    DbConn.cmd.ExecuteNonQuery();
                    DbConn.conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //procedura per insert krijon konfilkt me role id
        public void InsertUsers(UsersBO model)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_InsertUsers", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;
                    DbConn.cmd.Parameters.AddWithValue("@UserName", model.UserName);
                    DbConn.cmd.Parameters.AddWithValue("@UserPass", model.UserPassword);
                    DbConn.cmd.Parameters.AddWithValue("@RoleID", model.RoleID);
                    DbConn.cmd.Parameters.AddWithValue("@InsertBy", "1");
                    DbConn.cmd.Parameters.AddWithValue("@InsertDate", DateTime.Now);
                    DbConn.cmd.ExecuteNonQuery();
                    DbConn.conn.Close();

                }
            }
            catch (Exception ex) 
            {

                throw ex;
            }
        }
        public void UpdateUsers() { }//te implementohet
    }
}
