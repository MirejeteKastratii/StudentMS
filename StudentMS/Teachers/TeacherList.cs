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
using StudentMS_BO;

namespace StudentMS.Teachers
{
    public partial class TeacherList : Form
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        public TeacherList()
        {
            InitializeComponent();
        }
        public TeacherList(int StaffID)
        {
            InitializeComponent();
            LoadStaffData(StaffID);
        }
        private void LoadStaffData(int StaffID)
        {
            TeacherBO tchBO = teacherBLL.GetTeacherData(StaffID);
        }
        private void TeacherList_Load(object sender, EventArgs e)
        {
        
            DataTable list = teacherBLL.ShowTeachers();
            dgvTeachers.DataSource = list;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacherForm = new AddTeacher();
            addTeacherForm.Show();
        }

        private void brnRefresh_Click(object sender, EventArgs e)
        {
            TeacherBLL teacherBLL = new TeacherBLL();
            DataTable list = teacherBLL.ShowTeachers();
            dgvTeachers.DataSource = list;
        }

        //kthehu qetu 
        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var vID = int.Parse(dgvTeachers.Rows[e.RowIndex].Cells[0].Value.ToString());   //kthen id te rreshtit te selektuar     }
            TeacherList tchListFrm = new TeacherList(vID);
            tchListFrm.teacherBLL.GetTeacherData(vID);
          
        }
    }
}
