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
    public class TeacherDAL
    {
        public DataTable GetTeacherList()
        {

            using (DbConn.conn = new SqlConnection(DbConn.connString))
            {
                //E lidh databazen edhe projektin tone permes adapterit na vijne te dhanat ne nje format qe ne e percaktojme
                DbConn.dataAdapter = new SqlDataAdapter("usp_TeachersList", DbConn.conn);
                //strukture e ngjashme me datatable te sql e cila behet map shume lehte me datagridin
                DataTable dt = new DataTable();
                DbConn.dataAdapter.Fill(dt);
                return dt;
            }
        }
        public void InsertTeachers(TeacherBO model)
        {
            using (DbConn.conn = new SqlConnection(DbConn.connString))
            {
                DbConn.cmd = new SqlCommand("usp_InsertTeachers", DbConn.conn);
                DbConn.cmd.CommandType = CommandType.StoredProcedure;

                DbConn.cmd.Parameters.AddWithValue("@Foto", model.Foto);
                DbConn.cmd.Parameters.AddWithValue("@Emri", model.Emri);
                DbConn.cmd.Parameters.AddWithValue("@Mbiemri", model.Mbiemri);
                DbConn.cmd.Parameters.AddWithValue("@Gjinia", model.Gjinia);
                DbConn.cmd.Parameters.AddWithValue("@Email", model.Email);
                DbConn.cmd.Parameters.AddWithValue("@NumriTelefonit", model.NrTel);
                DbConn.cmd.Parameters.AddWithValue("@VendBanimi", model.Vendbanimi);
                DbConn.cmd.Parameters.AddWithValue("@Specializimi", model.Specializimi);
                DbConn.cmd.Parameters.AddWithValue("@WeeklyWorkingHours", model.WeeklyWorkingHr);
                DbConn.cmd.Parameters.AddWithValue("@InsertBy", model.InsertBy);
                DbConn.cmd.Parameters.AddWithValue("@InsertDate", model.InsertDate);
                DbConn.cmd.Parameters.AddWithValue("@LUB", model.LUB);
                DbConn.cmd.Parameters.AddWithValue("LUD", model.LUD);
                DbConn.cmd.Parameters.AddWithValue("@LUN", model.LUN);

                DbConn.cmd.ExecuteNonQuery();//egzekuton rreshtin 31
            }

        }
    }
}
