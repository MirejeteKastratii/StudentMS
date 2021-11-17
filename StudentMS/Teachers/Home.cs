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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        TeacherList tchList = new TeacherList();
        AddTeacher addTch = new AddTeacher();
        Students.AddStudents addStudents = new Students.AddStudents();
        Students.StudentList stList = new Students.StudentList();
        Courses.AddCourse addCourse = new Courses.AddCourse();
        Courses.CourseList courseList = new Courses.CourseList();
        Users.ManageUsers addUsers = new Users.ManageUsers();
        Users.ManageUsers mngUsers = new Users.ManageUsers();

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnViewStaff.Height;
            pnlActive.Top = btnViewStaff.Top;
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }
            if (pnlContent.Contains(courseList))
            {
                addTch.Hide();
            }
            if (pnlContent.Contains(addStudents))
            {
                addStudents.Hide();
            }
            if (pnlContent.Contains(stList))
            {
                stList.Hide();
            }
            if (pnlContent.Contains(addUsers))
            {
                addUsers.Hide();
            }
            if (pnlContent.Contains(mngUsers))
            {
                mngUsers.Hide();
            }
            if (pnlContent.Contains(addTch))
            {
                addTch.Hide();
            }
            tchList.TopLevel = false;
            tchList.Parent = pnlContent;
            tchList.Dock = DockStyle.Fill;
            tchList.Show();

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnAddStaff.Height;
            pnlActive.Top = btnAddStaff.Top;
            if (pnlContent.Contains(tchList))
            {
                tchList.Hide();
            }
            if (pnlContent.Contains(courseList))
            {
                addTch.Hide();
            }
            if (pnlContent.Contains(addStudents))
            {
                addStudents.Hide();
            }
            if (pnlContent.Contains(stList))
            {
                stList.Hide();
            }
            if (pnlContent.Contains(addUsers))
            {
                addUsers.Hide();
            }
            if (pnlContent.Contains(mngUsers))
            {
                mngUsers.Hide();
            }
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }
            addTch.TopLevel = false;
            addTch.Parent = pnlContent;
            addTch.Dock = DockStyle.Fill;
            addTch.Show();
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnViewCourses.Height;
            pnlActive.Top = btnViewCourses.Top;
            if (pnlContent.Contains(tchList))
            {
                tchList.Hide();
            }
            if (pnlContent.Contains(addTch))
            {
                addTch.Hide();
            }
            if (pnlContent.Contains(addStudents))
            {
                addStudents.Hide();
            }
            if (pnlContent.Contains(stList))
            {
                stList.Hide();
            }
            if (pnlContent.Contains(addUsers))
            {
                addUsers.Hide();
            }
            if (pnlContent.Contains(mngUsers))
            {
                mngUsers.Hide();
            }
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }
            courseList.TopLevel = false;
            courseList.Parent = pnlContent;
            courseList.Dock = DockStyle.Fill;
            courseList.Show();
        }

        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnAddCourses.Height;
            pnlActive.Top = btnAddCourses.Top;
            if (pnlContent.Contains(tchList))
            {
                tchList.Hide();
            }
            if (pnlContent.Contains(courseList))
            {
                courseList.Hide();
            }
            if (pnlContent.Contains(addStudents))
            {
                addStudents.Hide();
            }
            if (pnlContent.Contains(stList))
            {
                stList.Hide();
            }
            if (pnlContent.Contains(addUsers))
            {
                addUsers.Hide();
            }
            if (pnlContent.Contains(mngUsers))
            {
                mngUsers.Hide();
            }
            if (pnlContent.Contains(addTch))
            {
                addTch.Hide();
            }
           
            addCourse.TopLevel = false;
            addCourse.Parent = pnlContent;
            addCourse.Dock = DockStyle.Fill;
            addCourse.Show();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnViewStudents.Height;
            pnlActive.Top = btnViewStudents.Top;
            if (pnlContent.Contains(tchList))
            {
                tchList.Hide();
            }
            if (pnlContent.Contains(courseList))
            {
                courseList.Hide();
            }
            if (pnlContent.Contains(addStudents))
            {
                addStudents.Hide();
            }
            if (pnlContent.Contains(mngUsers))
            {
                mngUsers.Hide();
            }
            if (pnlContent.Contains(addUsers))
            {
                addUsers.Hide();
            }
            if (pnlContent.Contains(addTch))
            {
                addTch.Hide();
            }
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }
            stList.TopLevel = false;
            stList.Parent = pnlContent;
            stList.Dock = DockStyle.Fill;
            stList.Show();
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnAddStudents.Height;
            pnlActive.Top = btnAddStudents.Top;
            if (pnlContent.Contains(tchList))
            {
                tchList.Hide();
            }
            if (pnlContent.Contains(courseList))
            {
                courseList.Hide();
            }
            if (pnlContent.Contains(stList))
            {
                stList.Hide();
            }
            if (pnlContent.Contains(mngUsers))
            {
                mngUsers.Hide();
            }
            if (pnlContent.Contains(addUsers))
            {
                addUsers.Hide();
            }
            if (pnlContent.Contains(addTch))
            {
                addTch.Hide();
            }
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }

            addStudents.TopLevel = false;
            addStudents.Parent = pnlContent;
            addStudents.Dock = DockStyle.Fill;
            addStudents.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnManageUsers.Height;
            pnlActive.Top = btnManageUsers.Top;
            if (pnlContent.Contains(tchList))
            {
                tchList.Hide();
            }
            if (pnlContent.Contains(courseList))
            {
                courseList.Hide();
            }
            if (pnlContent.Contains(stList))
            {
                stList.Hide();
            }
            if (pnlContent.Contains(stList))
            {
                stList.Hide();
            }
            if (pnlContent.Contains(addUsers))
            {
                addUsers.Hide();
            }
            if (pnlContent.Contains(addTch))
            {
                addTch.Hide();
            }
            if (pnlContent.Contains(addCourse))
            {
                addCourse.Hide();
            }

            mngUsers.TopLevel = false;
            mngUsers.Parent = pnlContent;
            mngUsers.Dock = DockStyle.Fill;
            mngUsers.Show();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
