using StudentMS_BLL;
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

namespace StudentMS.Teachers
{
    public partial class AddTeacher : Form
    {
        private TeacherBLL teacherService;
        public AddTeacher()
        {
            InitializeComponent();
            teacherService = new TeacherBLL();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string gender;
            if (rdFemale.Checked)
            {
                gender = "F";
            }
            else
                gender = "M";
            TeacherBO teacherBO = new TeacherBO(txtEmri.Text, txtMbiemri.Text, gender, txtEmail.Text, txtNrTel.Text, txtVendbanimi.Text, txtSpecializimi.Text, int.Parse(txtOrePune.Text), dtDitelindja.Value );
            teacherService.AddTeachers(teacherBO);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
