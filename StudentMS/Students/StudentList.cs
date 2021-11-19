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
using DGVPrinterHelper;
using StudentMS_BLL;

namespace StudentMS.Students
{
    public partial class StudentList : Form
    {
        StudentBLL stBLL = new StudentBLL();
        public StudentList()
        {
            InitializeComponent();
        }
        
        private void StudentList_Load(object sender, EventArgs e)
        {
            DataTable list = stBLL.ShowStudentList();
            dgvListaStudenteve.DataSource = list;
            dgvListaStudenteve.Columns["StudentID"].Visible = false;

        }

        private void lblListaStudenteve_Click(object sender, EventArgs e)
        {

        }

        private void btnRifreskoStudent_Click(object sender, EventArgs e)
        {
            DataTable list = stBLL.ShowStudentList();
            dgvListaStudenteve.DataSource = list;
            dgvListaStudenteve.Columns["StudentID"].Visible = false;

        }

        int StudentID;
        private void btnFshijStudent_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("A dëshironi ta fshini rekordin e selektuar.", "Paralajmërim për fshirje.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = stBLL.DeleteStudents(StudentID);
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

        private void dgvListaStudenteve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvListaStudenteve.Rows[dgvListaStudenteve.SelectedCells[0].RowIndex];
            StudentID = int.Parse(Convert.ToString(selectedRow.Cells["StudentID"].Value));
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.Title = "Lista e studentëve";
            dGVPrinter.SubTitle = "Lista e studentëve me të dhënat personale !";
            dGVPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dGVPrinter.PageNumbers = true;
            dGVPrinter.PageNumberInHeader = false;
            dGVPrinter.PorportionalColumns = true;
            dGVPrinter.HeaderCellAlignment=StringAlignment.Near;
            dGVPrinter.Footer = "Education";
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintDataGridView(dgvListaStudenteve);
                
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = new CultureInfo("en-US");
            CultureInfo culture;
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
            StudentList_Load(sender, e);
        }

        private void pbHelp_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Mirejeta\source\repos\StudentMS\StudentMS\Help\UserManuali.chm", HelpNavigator.Topic, "StudentListAdmin_Help.htm");
        }
    }
}
