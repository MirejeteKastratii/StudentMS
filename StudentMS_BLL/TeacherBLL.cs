using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_DAL;
using StudentMS_BO;

namespace StudentMS_BLL
{
    public class TeacherBLL
    {
        //objekti nga dali gjithashtu objekti inicializohetne konstruktor te teacherBLL
        private readonly TeacherDAL teacherDAL;
        public TeacherBLL()
        {
            teacherDAL = new TeacherDAL();
        }
        public DataTable ShowTeachers()
        {
            return teacherDAL.GetTeacherList();
        }

        //e perfunduar, perfundo edhe te DAL - i
        public TeacherBO GetTeacherData(int StaffID)
        {
            return teacherDAL.GetTeacherByID(StaffID);
        }
        public void AddTeachers(TeacherBO model)
        {
            teacherDAL.InsertTeachers(model);
        }
        public bool DeleteTeachers(int TeacherID)
        {
            return teacherDAL.DeleteTeacher(TeacherID);
        }
        public bool UpdateTeachers(TeacherBO model)
        {
            return teacherDAL.UpdateTeacher(model);
        }

        public bool UpdateTeachersPaFoto(TeacherBO model)
        {
            return teacherDAL.UpdateTeachersPaFoto(model);
        }
    }
}
