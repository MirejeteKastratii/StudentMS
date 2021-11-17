using DGVPrinterHelper;
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

        private void btnPrinto_Click(object sender, EventArgs e)
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.Title = "Lista e kurseve";
            dGVPrinter.SubTitle = "Lista me detajet per kurset !";
            dGVPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dGVPrinter.PageNumbers = true;
            dGVPrinter.PageNumberInHeader = false;
            dGVPrinter.PorportionalColumns = true;
            dGVPrinter.HeaderCellAlignment = StringAlignment.Near;
            dGVPrinter.Footer = "Education";
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintDataGridView(dgvListaKurseve);
        }
    }
}
