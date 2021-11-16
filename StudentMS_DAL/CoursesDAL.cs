using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_BO;

namespace StudentMS_DAL
{
    public class CoursesDAL
    {
        public DataTable GetCoursesList()
        {
            using (DbConn.conn = new SqlConnection(DbConn.connString))
            {
                DbConn.dataAdapter = new SqlDataAdapter("usp_CoursesList", DbConn.conn);
                DataTable dt = new DataTable();
                DbConn.dataAdapter.Fill(dt);
                return dt;
            }
        }
        public void InsertCourse(CoursesBO model)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_InsertCourse", DbConn.conn);

                    DbConn.cmd.Parameters.AddWithValue("Titulli", model.Titulli);
                    DbConn.cmd.Parameters.AddWithValue("Pershkrimi", model.Pershkrimi);
                    DbConn.cmd.Parameters.AddWithValue("Syllabusi", model.Syllabusi);
                    DbConn.cmd.Parameters.AddWithValue("Sessionet", model.Sesionet);
                    DbConn.cmd.Parameters.AddWithValue("InsertBy", 1);
                    DbConn.cmd.Parameters.AddWithValue("InsertDate", DateTime.Now);

                    DbConn.cmd.ExecuteNonQuery();
                    DbConn.conn.Close();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public CoursesBO GetCourseByID(int CourseID)
        {
            DataSet ds;
            CoursesBO courseBO = new CoursesBO();

            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_GetCourseByID", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", CourseID);
                    DbConn.dataAdapter = new SqlDataAdapter(DbConn.cmd);
                    ds = new DataSet();
                    DbConn.dataAdapter.Fill(ds);
                    courseBO.Titulli = Convert.ToString(ds.Tables[0].Rows[0]["Titulli"]);
                    courseBO.Pershkrimi = Convert.ToString(ds.Tables[0].Rows[0]["Pershkrimi"]);
                    courseBO.Syllabusi = Convert.ToString(ds.Tables[0].Rows[0]["Syllabusi"]);
                    courseBO.Sesionet = Convert.ToInt32(ds.Tables[0].Rows[0]["Sessionet"]);

                    DbConn.conn.Close();
                    return courseBO;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
