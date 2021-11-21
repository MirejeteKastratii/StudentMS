using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using StudentMS_BO;

namespace StudentMS_DAL
{
   public class VleresimiDAL
    {
       public DataTable GetVleresimet() {
            using (DbConn.conn = new SqlConnection(DbConn.connString))
            {
                DbConn.dataAdapter = new SqlDataAdapter("usp_VleresimList", DbConn.conn);
             DataTable dt = new DataTable();
                DbConn.dataAdapter.Fill(dt);
                return dt;
            }
        
        
        }
        public void InsertVlersimet(VleresimetBO model) {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_InsertVleresimet", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@CourseID", model.CoursesID);
                    DbConn.cmd.Parameters.AddWithValue("@StudentID", model.StudentsID) ;
                    DbConn.cmd.Parameters.AddWithValue("@Testi1", model.Testi1);
                    DbConn.cmd.Parameters.AddWithValue("@Testi2", model.Testi2);
                    DbConn.cmd.Parameters.AddWithValue("@FinalGrade", model.FinaleGrade) ;
                    DbConn.cmd.Parameters.AddWithValue("@InsertBy", 2);
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
        public bool DeleteVleresimi(int ID)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_DeleteVleresimi", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", ID);

                    DbConn.cmd.ExecuteNonQuery();
                    DbConn.conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public VleresimetBO GetVleresimetByID(int ID)
        {
            DataSet ds;
            VleresimetBO vleresimetBO = new VleresimetBO();
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_GetVleresimetByID", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", ID);
                    DbConn.dataAdapter = new SqlDataAdapter(DbConn.cmd);
                    ds = new DataSet();
                    DbConn.dataAdapter.Fill(ds);
                    vleresimetBO.CoursesID = int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["CourseID"]));
                    vleresimetBO.StudentsID = int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["StudentID"]));
                    vleresimetBO.Testi1 = int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["Testi1"]));
                    vleresimetBO.Testi2 = int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["Testi2"]));
                    vleresimetBO.FinaleGrade = int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["FinalGrade"]));


                    DbConn.conn.Close();
                    return vleresimetBO;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public void EditoVleresimet(VleresimetBO model)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_UpdateVlersim", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", model.ID);
                    DbConn.cmd.Parameters.AddWithValue("@CourseID", model.CoursesID);
                    DbConn.cmd.Parameters.AddWithValue("@StudentID", model.StudentsID);
                    DbConn.cmd.Parameters.AddWithValue("@Testi1", model.Testi1);
                    DbConn.cmd.Parameters.AddWithValue("@Testi2", model.Testi2);
                    DbConn.cmd.Parameters.AddWithValue("@FinalGrade", model.FinaleGrade);
                    DbConn.cmd.Parameters.AddWithValue("@LUB", "2");
                    DbConn.cmd.Parameters.AddWithValue("@LUD",DateTime.Now);
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
    }
}
