using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_DAL
{
    public class StudentDAL
    {

        public DataTable ShowStudents()
        {
            using (DbConn.conn = new SqlConnection(DbConn.connString))
            {
               
                DbConn.dataAdapter = new SqlDataAdapter("usp_StudentList", DbConn.conn);
                //strukture e ngjashme me datatable te sql e cila behet map shume lehte me datagridin
                DataTable dt = new DataTable();
                DbConn.dataAdapter.Fill(dt);
                return dt;
            }
        }
    }
}
