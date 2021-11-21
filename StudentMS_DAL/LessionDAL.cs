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
    public class LessionDAL
    {
        public DataTable GetLessionList() {
            using (DbConn.conn = new SqlConnection(DbConn.connString))
            {
                DbConn.dataAdapter = new SqlDataAdapter("usp_OraList", DbConn.conn);
              DataTable dt = new DataTable();
                DbConn.dataAdapter.Fill(dt);
                return dt;
            }
        }
        public void InsertLessions(LessionBO model) {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_InsertOren", DbConn.conn);

                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@Data", model.Data) ;
                    DbConn.cmd.Parameters.AddWithValue("@NrOres", model.NrOres) ;
                    DbConn.cmd.Parameters.AddWithValue("@LendaID", model.LendaID) ;
                    DbConn.cmd.Parameters.AddWithValue("@MesuesiID", model.MesuesiID) ;
                    DbConn.cmd.Parameters.AddWithValue("@TemaMesimore", model.TemaMesimore);
                    DbConn.cmd.Parameters.AddWithValue("@InsertBy", '2');
                    DbConn.cmd.Parameters.AddWithValue("@InsertDate" , DateTime.Now);
                   
                    DbConn.cmd.ExecuteNonQuery();
                    DbConn.conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool DeleteLession(int ID) {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_DeleteOren", DbConn.conn);
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
        public bool UpdateLession(LessionBO model) {
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_UpdateOren", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@@ID", model.OraID);
                    DbConn.cmd.Parameters.AddWithValue("@Data", model.Data);
                    DbConn.cmd.Parameters.AddWithValue("@NrOres", model.NrOres);
                    DbConn.cmd.Parameters.AddWithValue("@LendaID", model.LendaID);
                    DbConn.cmd.Parameters.AddWithValue("@MesuesiID", model.MesuesiID);
                    DbConn.cmd.Parameters.AddWithValue("@TemaMesimore", model.TemaMesimore);
                    DbConn.cmd.Parameters.AddWithValue("@LUB", "2");
                    DbConn.cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                    DbConn.cmd.Parameters.AddWithValue("@LUN", model.LUN);
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
    public LessionBO GetOrenByID(int id)
        {
            DataSet ds;
            LessionBO oraBO = new LessionBO();
            try
            {
                using (DbConn.conn = new SqlConnection(DbConn.connString))
                {
                    DbConn.conn.Open();
                    DbConn.cmd = new SqlCommand("usp_GetOraByID", DbConn.conn);
                    DbConn.cmd.CommandType = CommandType.StoredProcedure;

                    DbConn.cmd.Parameters.AddWithValue("@ID", id);
                    DbConn.dataAdapter = new SqlDataAdapter(DbConn.cmd);
                    ds = new DataSet();
                    DbConn.dataAdapter.Fill(ds);
                    oraBO.Data = DateTime.Parse(Convert.ToString(ds.Tables[0].Rows[0]["Data"]));
                    oraBO.NrOres= int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["NrOres"]));
                    oraBO.LendaID= int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["LendaID"]));
                    oraBO.MesuesiID= int.Parse(Convert.ToString(ds.Tables[0].Rows[0]["MesuesiID"]));
                    oraBO.TemaMesimore= Convert.ToString(ds.Tables[0].Rows[0]["TemaMesimore"]);


                    DbConn.conn.Close();
                    return oraBO;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    
    }
}
