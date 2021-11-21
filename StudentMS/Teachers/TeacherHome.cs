using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMS.Teachers
{
    public partial class TeacherHome : Form
    {
        private void TeacherHome_Load(object sender, EventArgs e)
        {

        }
        Courses.Courses_Teachers courseList = new Courses.Courses_Teachers();
        Courses.Vleresimi vleresimet = new Courses.Vleresimi();
        Students.Students_Teacher studentList = new Students.Students_Teacher();
        Courses.Lesson ora = new Courses.Lesson();
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
            if (pnlContent.Contains(ora))
            {
                ora.Hide();
            }
            label4.Hide();
            label2.Hide();
            label3.Hide();
            pictureBox3.Hide();
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
            if (pnlContent.Contains(ora))
            {
                ora.Hide();
            }
            label4.Hide();
            label2.Hide();
            label3.Hide();
            pictureBox3.Hide();
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
            if (pnlContent.Contains(ora))
            {
                ora.Hide();
            }
            label4.Hide();
            label2.Hide();
            label3.Hide();
            pictureBox3.Hide();
            studentList.TopLevel = false;
            studentList.Parent = pnlContent;
            studentList.Dock = DockStyle.Fill;
            studentList.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    culture = new CultureInfo("sq-XK");
                    break;
                case 1:
                    culture = new CultureInfo("en-US");
                    break;

                default:
                    culture = new CultureInfo("en-US");
                    break;
            }
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            this.Controls.Clear();
            //inicializo komponentet me kulturen e paracaktuar
            InitializeComponent();
            TeacherHome_Load(sender, e);
        }

        //shto nje picture box per help
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Mirejeta\source\repos\StudentMS\StudentMS\Help\UserManuali.chm", HelpNavigator.Topic, "TeacherHome_Help.htm");
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOra_Click(object sender, EventArgs e)
        {
            pnlActive.Height = btnOra.Height;
            pnlActive.Top = btnOra.Top;
            if (pnlContent.Contains(courseList))
            {
                courseList.Hide();
            }
            if (pnlContent.Contains(studentList))
            {
                studentList.Hide();
            }
            if (pnlContent.Contains(vleresimet))
            {
                vleresimet.Hide();
            }
            label4.Hide();
            label2.Hide();
            label3.Hide();
            pictureBox3.Hide();
            ora.TopLevel = false;
            ora.Parent = pnlContent;
            ora.Dock = DockStyle.Fill;
            ora.Show();
        }
    }
}
