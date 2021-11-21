using StudentMS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_DAL;
using System.Data;
using StudentMS_BO;

namespace StudentMS_BLL
{
    public class StudentBLL
    {
        Student_DAL stDAL = new Student_DAL();
        public StudentBLL()
        {
            
        }
        public DataTable ShowStudentList()
        {
            return stDAL.ShowStudents();
        }
        public bool DeleteStudents(int StudentID)
        {
            return stDAL.DeleteStudent(StudentID);
        }
        public void InsertStudents(StudentsBO model)
        {
            stDAL.InsertStudents(model);
        }
    }
}
