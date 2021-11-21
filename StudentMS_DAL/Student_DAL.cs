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
        public void InsertStudents(StudentsBO model)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_InsertStudent", DbConn.conn);

                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@Emri", model.Emri);
                    DbConn.cmd.Parameters.AddWithValue("@Mbiemri", model.Mbiemri);
                    DbConn.cmd.Parameters.AddWithValue("@Datalindjes", model.DataLindjes);
                    DbConn.cmd.Parameters.AddWithValue("@Gjinia", model.Gjinia);
                    DbConn.cmd.Parameters.AddWithValue("@Email", model.Email);
                    DbConn.cmd.Parameters.AddWithValue("@NumriTelefonit", model.NumriTel);
                    DbConn.cmd.Parameters.AddWithValue("@InsertBy", "1") ;
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

}
        //Krijo metoden per update
        //krijo metoden per edit
    }

