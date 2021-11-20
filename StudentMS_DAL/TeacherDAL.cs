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
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_InsertTeachersPaFoto", DbConn.conn);

                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    //    DbConn.cmd.Parameters.AddWithValue("@Foto", model.Foto);
                    DbConn.cmd.Parameters.AddWithValue("@Emri", model.Emri);
                    DbConn.cmd.Parameters.AddWithValue("@Mbiemri", model.Mbiemri);
                    DbConn.cmd.Parameters.AddWithValue("@Gjinia", model.Gjinia);
                    DbConn.cmd.Parameters.AddWithValue("@Email", model.Email);
                    DbConn.cmd.Parameters.AddWithValue("@NumriTelefonit", model.NrTel);
                    DbConn.cmd.Parameters.AddWithValue("@VendBanimi", model.Vendbanimi);
                    DbConn.cmd.Parameters.AddWithValue("@Specializimi", model.Specializimi);
                    DbConn.cmd.Parameters.AddWithValue("@WeeklyWorkingHours", model.WeeklyWorkingHr);
                    DbConn.cmd.Parameters.AddWithValue("@InsertBy", 1);
                    DbConn.cmd.Parameters.AddWithValue("@InsertDate", DateTime.Now);
                    DbConn.cmd.Parameters.AddWithValue("@Ditelindja", model.Birthdate);


                    DbConn.cmd.ExecuteNonQuery();//egzekuton rreshtin 31
                    DbConn.conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        //kthehu kur t merresh me edit + krijo proceduren per editim
        public TeacherBO GetTeacherByID(int TchID)
        {
            DataSet ds;
            TeacherBO tchBo = new TeacherBO();
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_GetTeacherByID", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", TchID);
                    DbConn.dataAdapter = new SqlDataAdapter(DbConn.cmd);
                    ds = new DataSet();
                    DbConn.dataAdapter.Fill(ds);
                    tchBo.Emri = Convert.ToString(ds.Tables[0].Rows[0]["Emri"]);
                    tchBo.Mbiemri = Convert.ToString(ds.Tables[0].Rows[0]["Mbiemri"]);
                    tchBo.Gjinia = Convert.ToString(ds.Tables[0].Rows[0]["Gjinia"]);
                    tchBo.Email = Convert.ToString(ds.Tables[0].Rows[0]["Email"]);
                    tchBo.NrTel = Convert.ToString(ds.Tables[0].Rows[0]["NrTel"]);
                    tchBo.Vendbanimi = Convert.ToString(ds.Tables[0].Rows[0]["Vendbanimi"]);
                    tchBo.Specializimi = Convert.ToString(ds.Tables[0].Rows[0]["Specializimi"]);
                    tchBo.WeeklyWorkingHr = Convert.ToInt32(ds.Tables[0].Rows[0]["WeeklyWorkingHr"]);
                    tchBo.Birthdate = Convert.ToDateTime(ds.Tables[0].Rows[0]["Birthdate"]);
                    DbConn.conn.Close();
                    return tchBo;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public bool DeleteTeacher(int ID)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_DeleteTeacher", DbConn.conn);
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
        public bool UpdateTeacher(TeacherBO model)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_EditTeachers", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", model.TeacherID);
                    DbConn.cmd.Parameters.AddWithValue("@Foto", model.Foto);
                    DbConn.cmd.Parameters.AddWithValue("@Emri", model.Emri);
                    DbConn.cmd.Parameters.AddWithValue("@Mbiemri", model.Mbiemri);
                    DbConn.cmd.Parameters.AddWithValue("@Gjinia", model.Gjinia);
                    DbConn.cmd.Parameters.AddWithValue("@BirthDate", model.Birthdate);
                    DbConn.cmd.Parameters.AddWithValue("@Email", model.Email);
                    DbConn.cmd.Parameters.AddWithValue("@NumriTelefonit", model.NrTel);
                    DbConn.cmd.Parameters.AddWithValue("@VendBanimi", model.Vendbanimi);
                    DbConn.cmd.Parameters.AddWithValue("@Specializimi", model.Specializimi);
                    DbConn.cmd.Parameters.AddWithValue("@WeeklyWorkingHours", model.WeeklyWorkingHr);
                    DbConn.cmd.Parameters.AddWithValue("@LUB", 1);
                    DbConn.cmd.Parameters.AddWithValue("@LUD", model.LUN);
                    DbConn.cmd.ExecuteNonQuery();
                    DbConn.conn.Close();
                    return true;
                   

                }

            }
            catch (Exception ex)
            {

                throw ex;
                return false;
            }
        }

        public bool UpdateTeachersPaFoto(TeacherBO model)
        {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_EditTeachersPaFoto", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", model.TeacherID);
                  //  DbConn.cmd.Parameters.AddWithValue("@Foto", model.Foto);
                    DbConn.cmd.Parameters.AddWithValue("@Emri", model.Emri);
                    DbConn.cmd.Parameters.AddWithValue("@Mbiemri", model.Mbiemri);
                    DbConn.cmd.Parameters.AddWithValue("@Gjinia", model.Gjinia);
                    DbConn.cmd.Parameters.AddWithValue("@BirthDate", model.Birthdate);
                    DbConn.cmd.Parameters.AddWithValue("@Email", model.Email);
                    DbConn.cmd.Parameters.AddWithValue("@NumriTelefonit", model.NrTel);
                    DbConn.cmd.Parameters.AddWithValue("@VendBanimi", model.Vendbanimi);
                    DbConn.cmd.Parameters.AddWithValue("@Specializimi", model.Specializimi);
                    DbConn.cmd.Parameters.AddWithValue("@WeeklyWorkingHours", model.WeeklyWorkingHr);
                    DbConn.cmd.Parameters.AddWithValue("@LUB", "1");
                    DbConn.cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                    DbConn.cmd.Parameters.AddWithValue("@LUN", 1);
                    DbConn.cmd.ExecuteNonQuery();
                    DbConn.conn.Close();
                    return true;


                }

            }
            catch (Exception ex)
            {

                throw ex;
                return false;
            }
        }
    }
}
