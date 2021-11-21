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
                    DbConn.cmd.Parameters.AddWithValue("@UserPassword", model.UserPassword);
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
        public void UpdateUsers(UsersBO model) {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_UpdateUsers", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", model.ID);
                    DbConn.cmd.Parameters.AddWithValue("@UserName", model.UserName);
                    DbConn.cmd.Parameters.AddWithValue("@UserPassword", model.UserPassword);
                    DbConn.cmd.Parameters.AddWithValue("@RoleID", model.RoleID);
                     DbConn.cmd.Parameters.AddWithValue("@LUB", "1");
                    DbConn.cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                    DbConn.cmd.Parameters.AddWithValue("@LUN", (model.LUN + 1));

                    DbConn.cmd.ExecuteNonQuery();
                    DbConn.conn.Close();



                }

            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        public UsersBO GetUserByID(int ID)
        {
            DataSet ds;
            UsersBO usersBO = new UsersBO();
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_GetUsersByID", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", ID);
                    DbConn.dataAdapter = new SqlDataAdapter(DbConn.cmd);
                    ds = new DataSet();
                    DbConn.dataAdapter.Fill(ds);
                    usersBO.UserName = Convert.ToString(ds.Tables[0].Rows[0]["UserName"]);
                    usersBO.UserPassword = Convert.ToString(ds.Tables[0].Rows[0]["UserPASS"]);
                    usersBO.RoleID = Convert.ToInt32((Convert.ToString(ds.Tables[0].Rows[0]["RoleID"])));
                    

                    DbConn.conn.Close();
                    return usersBO;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
