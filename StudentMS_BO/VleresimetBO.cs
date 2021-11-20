using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    public class VleresimetBO:Base
    {
        public int ID { get; set; }
        public int CoursesID { get; set; }
          public int StudentsID { get; set; }
        public int Testi1 { get; set; }
        public int Testi2 { get; set; }
        public int Homeworks { get; set; }
        public int FinaleGrade { get; set; }

        public VleresimetBO(int courseID, int studentID, int test1, int test2, int notaFinale)
        {
            CoursesID = courseID;
            StudentsID = studentID;
            Testi1 = test1;
            Testi2 = test2;
            FinaleGrade = notaFinale;
        }
    }
}
