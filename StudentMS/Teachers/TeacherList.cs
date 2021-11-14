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

namespace StudentMS.Teachers
{
    public partial class TeacherList : Form
    {
        public TeacherList()
        {
            InitializeComponent();
        }

        private void TeacherList_Load(object sender, EventArgs e)
        {
            TeacherBLL teacherBLL = new TeacherBLL();
            DataTable list = teacherBLL.ShowTeachers();
            dgvTeachers.DataSource = list;
        }
    }
}
