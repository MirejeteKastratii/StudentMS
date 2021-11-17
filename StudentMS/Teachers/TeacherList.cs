using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int TeacherID;
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
                if (isDeleted)
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
    }
}
