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
    public partial class Courses_Teachers : Form
    {
        public Courses_Teachers()
        {
            InitializeComponent();
        }

        private void Courses_Teachers_Load(object sender, EventArgs e)
        {
            CoursesBLL coursesBLL = new CoursesBLL();
            DataTable list = coursesBLL.ShowCourses();
            dgvCourses.DataSource = list;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CoursesBLL coursesBLL = new CoursesBLL();
            DataTable list = coursesBLL.ShowCourses();
            dgvCourses.DataSource = list;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvCourses.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exlApp = new Microsoft.Office.Interop.Excel.Application();
                exlApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvCourses.Columns.Count + 1; i++)
                {
                    exlApp.Cells[1, i] = dgvCourses.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dgvCourses.Rows.Count - 1; i++)
                {
                    for (int j = 3; j < dgvCourses.Columns.Count; j++)
                    {
                        exlApp.Cells[i + 2, j + 1] = dgvCourses.Rows[i].Cells[j].Value.ToString();
                    }
                }

                exlApp.Columns.AutoFit();
                exlApp.Visible = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
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
            dGVPrinter.PrintDataGridView(dgvCourses);
        }
    }
}
