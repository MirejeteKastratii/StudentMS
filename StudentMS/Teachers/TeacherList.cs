﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using StudentMS_BLL;
using StudentMS_BO;

namespace StudentMS.Teachers
{
    public partial class TeacherList : Form
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        AddTeacher addtch = new AddTeacher();
        public TeacherList()
        {
            InitializeComponent();
    
        }
        public TeacherList(int StaffID)
        {
            InitializeComponent();
            LoadStaffData(StaffID);
        }
        //kqyre per me e hek
        private void LoadStaffData(int StaffID)
        {
            TeacherBO tchBO = teacherBLL.GetTeacherData(StaffID);
        }
        private void TeacherList_Load(object sender, EventArgs e)
        {
        
            DataTable list = teacherBLL.ShowTeachers();
            dgvTeachers.DataSource = list;
            dgvTeachers.Columns["TeacherID"].Visible = false;    
        
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
       public int TeacherID;
        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*var vID = int.Parse(dgvTeachers.Rows[e.RowIndex].Cells[0].Value.ToString());   //kthen id te rreshtit te selektuar     }
            TeacherList tchListFrm = new TeacherList(vID);
            tchListFrm.teacherBLL.GetTeacherData(vID);*/
            var SelectedRow = dgvTeachers.Rows[dgvTeachers.SelectedCells[0].RowIndex];

            TeacherID = int.Parse(Convert.ToString(SelectedRow.Cells["TeacherID"].Value));
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("A dëshironi ta fshini rekordin e selektuar.", "Paralajmërim për fshirje.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = teacherBLL.DeleteTeachers(TeacherID);
                if (isDeleted == true)
                {
                    MessageBox.Show("Rekordi është fshi.");
                }
                else
                {
                    MessageBox.Show("Rekordi nuk është fshi.");

                }
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.Title = "Lista e profesorëve:";
            dGVPrinter.SubTitle = "Lista e profesorëve me të dhënat personale !";
            dGVPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dGVPrinter.PageNumbers = true;
            dGVPrinter.PageNumberInHeader = false;
            dGVPrinter.PorportionalColumns = true;
            dGVPrinter.HeaderCellAlignment = StringAlignment.Near;
            dGVPrinter.Footer = "Education";
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintDataGridView(dgvTeachers);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exlApp = new Microsoft.Office.Interop.Excel.Application();
                exlApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvTeachers.Columns.Count + 1; i++)
                {
                    exlApp.Cells[1, i] = dgvTeachers.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dgvTeachers.Rows.Count - 1; i++)
                {
                    for (int j = 3; j < dgvTeachers.Columns.Count; j++)
                    {
                        exlApp.Cells[i + 2, j + 1] = dgvTeachers.Rows[i].Cells[j].Value.ToString();
                    }
                }

                exlApp.Columns.AutoFit();
                exlApp.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            TeacherList_Load(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Mirejeta\source\repos\StudentMS\StudentMS\Help\UserManuali.chm", HelpNavigator.Topic, "TeacherListAdmin_Help.htm");
        }

        private void lblTeacherList_Click(object sender, EventArgs e)
        {

        }

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddTeacher addTch = new AddTeacher();
            addTch.Show();

            // TeacherBO teacherBO = new TeacherBO(txtEmri.Text, txtMbiemri.Text, gender, txtEmail.Text, txtNrTel.Text, txtVendbanimi.Text, txtSpecializimi.Text, int.Parse(txtOrePune.Text), dtDitelindja.Value);
        }
    }
}
