using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_DAL
{
    public class DbConn
    {
<<<<<<< HEAD
        public static string connString = ConfigurationManager.ConnectionStrings["connStringMirejete"].ConnectionString.ToString();
        //public static string connString = ConfigurationManager.ConnectionStrings["connStringFlorentine"].ConnectionString.ToString();
=======
        //public static string connString = ConfigurationManager.ConnectionStrings["connStringMirejete"].ConnectionString.ToString();
       // public static string connString = ConfigurationManager.ConnectionStrings["connStringFlorentine"].ConnectionString.ToString();
        public static string connString = ConfigurationManager.ConnectionStrings["connStringAmra"].ConnectionString.ToString();
>>>>>>> f68cc0ad72d6edfe8b9210d10c61a9e52895e5d1
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;
    }
}
