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
          Students.StudentList stList = new Students.StudentList();
          Courses.CourseList courseList = new Courses.CourseList();
        Users.ManageUsers mngUsers = new Users.ManageUsers();

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnViewStaff.Height;
            pnlActive.Top = btnViewStaff.Top;
          
                    
            if (pnlContent.Contains(stList))
            {
                stList.Hide();
            }
         
            if (pnlContent.Contains(mngUsers))
            {
                mngUsers.Hide();
            }
            if (pnlContent.Contains(courseList))
            {
                courseList.Hide();
            }
            tchList.TopLevel = false;
            tchList.Parent = pnlContent;
            tchList.Dock = DockStyle.Fill;
            tchList.Show();

        }

        
        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnViewCourses.Height;
            pnlActive.Top = btnViewCourses.Top;
            if (pnlContent.Contains(tchList))
            {
                tchList.Hide();
            }
           
            if (pnlContent.Contains(stList))
            {
                stList.Hide();
            }
           
            if (pnlContent.Contains(mngUsers))
            {
                mngUsers.Hide();
            }
        
            courseList.TopLevel = false;
            courseList.Parent = pnlContent;
            courseList.Dock = DockStyle.Fill;
            courseList.Show();
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
         
            if (pnlContent.Contains(mngUsers))
            {
                mngUsers.Hide();
            }
         
            stList.TopLevel = false;
            stList.Parent = pnlContent;
            stList.Dock = DockStyle.Fill;
            stList.Show();
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
            
            

            mngUsers.TopLevel = false;
            mngUsers.Parent = pnlContent;
            mngUsers.Dock = DockStyle.Fill;
            mngUsers.Show();
        }

       

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Mirejeta\source\repos\StudentMS\StudentMS\Help\UserManuali.chm", HelpNavigator.Topic, "AdminHome_Help.htm");
        }
    }
}
