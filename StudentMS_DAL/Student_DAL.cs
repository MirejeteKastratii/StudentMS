using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_DAL
{
   public class Student_DAL
    {
        public DataTable ShowStudents()
        {
            using (DbConn.conn = new SqlConnection(DbConn.connString))
            {

                DbConn.dataAdapter = new SqlDataAdapter("usp_StudentList", DbConn.conn);
               DataTable dt = new DataTable();
                DbConn.dataAdapter.Fill(dt);
                return dt;
            }
        }
        public bool DeleteStudent(int ID)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_DeleteStudents", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", ID);

                    DbConn.cmd.ExecuteNonQuery();
                    DbConn.conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {

                return true;
            }
        }
        //Krijo metoden per update
        //krijo metoden per edit
    }
}
