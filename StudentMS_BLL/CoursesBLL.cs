using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_DAL;
using StudentMS_BO;
using System.Data;

namespace StudentMS_BLL
{
    internal class CoursesBLL
    {
        private readonly CoursesDAL coursesDAL;
        public CoursesBLL()
        {
            coursesDAL = new CoursesDAL();
        }
        public DataTable ShowCourses()
        {
            return coursesDAL.GetCoursesList();
        }
        public CoursesBO GetCourseData(int CoursesID)
        {
            return coursesDAL.GetCourseByID(CoursesID);
        }
        public void AddCourses(CoursesBO model)
        {
            coursesDAL.InsertCourse(model);
        }
    }
}
