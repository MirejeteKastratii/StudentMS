using StudentMS_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMS.Courses
{
    public partial class CourseList : Form
    {
        public CourseList()
        {
            InitializeComponent();
        }

        private void btnRifreskoKurset_Click(object sender, EventArgs e)
        {
            CoursesBLL coursesBLL = new CoursesBLL();
            DataTable list = coursesBLL.ShowCourses();
            dgvListaKurseve.DataSource = list;
        }

        private void CourseList_Load(object sender, EventArgs e)
        {

            CoursesBLL coursesBLL = new CoursesBLL();
            DataTable list = coursesBLL.ShowCourses();
            dgvListaKurseve.DataSource = list;
            //fsheh kolonen i ID per tabelen ne dgv
            dgvListaKurseve.Columns["CourseID"].Visible = false;
        }
    }
}
