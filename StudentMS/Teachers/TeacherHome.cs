using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMS.Teachers
{
    public partial class TeacherHome : Form
    {

        Courses.CourseList courseList = new Courses.CourseList();
        Courses.Vleresimet vleresimet = new Courses.Vleresimet();
        Students.StudentList studentList = new Students.StudentList();
        public TeacherHome()
        {
            InitializeComponent();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnCourses.Height;
            pnlActive.Top = btnCourses.Top;
            if (pnlContent.Contains(vleresimet))
            {
                vleresimet.Hide();
            }
            if (pnlContent.Contains(studentList))
            {
                studentList.Hide();
            }
            courseList.TopLevel = false;
            courseList.Parent = pnlContent;
            courseList.Dock = DockStyle.Fill;
            courseList.Show();
        }

        private void btnVleresimet_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnVleresimet.Height;
            pnlActive.Top = btnVleresimet.Top;
            if (pnlContent.Contains(courseList))
            {
                courseList.Hide();
            }
            if (pnlContent.Contains(studentList))
            {
                studentList.Hide();
            }
            vleresimet.TopLevel = false;
            vleresimet.Parent = pnlContent;
            vleresimet.Dock = DockStyle.Fill;
            vleresimet.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnStudent.Height;
            pnlActive.Top = btnStudent.Top;
            if (pnlContent.Contains(courseList))
            {
                courseList.Hide();
            }
            if (pnlContent.Contains(vleresimet))
            {
                vleresimet.Hide();
            }
            studentList.TopLevel = false;
            studentList.Parent = pnlContent;
            studentList.Dock = DockStyle.Fill;
            studentList.Show();
        }
    }
}
