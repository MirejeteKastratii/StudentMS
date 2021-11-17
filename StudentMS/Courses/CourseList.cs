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

        private void btn_ExportToExcelCourses_Click(object sender, EventArgs e)
        {
            if (dgvListaKurseve.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exlApp = new Microsoft.Office.Interop.Excel.Application();
                exlApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvListaKurseve.Columns.Count + 1; i++)
                {
                        exlApp.Cells[1, i] = dgvListaKurseve.Columns[i - 1].HeaderText;
                       
                }

                for (int i = 0; i < dgvListaKurseve.Rows.Count - 1; i++)
                {
                    for (int j = 3; j < dgvListaKurseve.Columns.Count; j++)
                    {
                        exlApp.Cells[i + 2, j + 1] = dgvListaKurseve.Rows[i].Cells[j].Value.ToString();
                    }
                }

                exlApp.Columns.AutoFit();
                exlApp.Visible = true;
            }
        }
    }
}
