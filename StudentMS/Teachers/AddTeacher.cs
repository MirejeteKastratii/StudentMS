using StudentMS_BLL;
using StudentMS_BO;
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
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
        private void AddTeacher_Load(object sender, EventArgs e)
        {

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
            AddTeacher_Load(sender, e);
        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblhr_Click(object sender, EventArgs e)
        {

        }

        private void lblInWeek_Click(object sender, EventArgs e)
        {

        }

        private void lblSpecializim_Click(object sender, EventArgs e)
        {

        }

        private void lblNrTel_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblVendbanimi_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
