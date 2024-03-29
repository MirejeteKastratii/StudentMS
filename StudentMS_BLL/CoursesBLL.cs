﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_DAL;
using StudentMS_BO;
using System.Data;

namespace StudentMS_BLL
{
    public class CoursesBLL
    {
        private readonly CoursesDAL coursesDAL;
        public CoursesBLL()
        {
            coursesDAL = new CoursesDAL();
        }
        public void EditCourses(CoursesBO kursi)
        {
            coursesDAL.EditCourses(kursi);
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
        public bool DeleteCourse(int ID)
        {
            return coursesDAL.DeleteCourses(ID);
        }
    }
}
