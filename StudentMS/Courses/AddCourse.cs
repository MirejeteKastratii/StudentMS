using StudentMS_BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMS_BLL;
using System.Globalization;

namespace StudentMS.Courses
{
    public partial class AddCourse : Form
    {
        CoursesBLL courseService = new CoursesBLL();
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        } 
     
        private void btnRuaj_Click(object sender, EventArgs e)
        {
            CoursesBO courseBo = new CoursesBO(txtCourseTitle.Text, txtCourseDescription.Text,txtSyllabusi.Text,Convert.ToInt32(txtSessions.Text) );
            courseService.AddCourses(courseBo);
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
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
                    culture = new CultureInfo("sq-XK");
                    break;
            }
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            this.Controls.Clear();
            InitializeComponent();
            AddCourse_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
