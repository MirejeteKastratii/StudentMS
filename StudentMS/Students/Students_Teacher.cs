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

namespace StudentMS.Students
{
    public partial class Students_Teacher : Form
    {
        StudentBLL stBLL = new StudentBLL();
        public Students_Teacher()
        {
            InitializeComponent();
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.Hide();
             foreach (var c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
       
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvStudents.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exlApp = new Microsoft.Office.Interop.Excel.Application();
                exlApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvStudents.Columns.Count + 1; i++)
                {
                    exlApp.Cells[1, i] = dgvStudents.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dgvStudents.Rows.Count - 1; i++)
                {
                    for (int j = 3; j < dgvStudents.Columns.Count; j++)
                    {
                        exlApp.Cells[i + 2, j + 1] = dgvStudents.Rows[i].Cells[j].Value.ToString();
                    }
                }

                exlApp.Columns.AutoFit();
                exlApp.Visible = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable list = stBLL.ShowStudentList();
            dgvStudents.DataSource = list;
            dgvStudents.Columns["StudentID"].Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.Title = "Lista e studentëve";
            dGVPrinter.SubTitle = "Lista e studentëve me të dhënat personale !";
            dGVPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dGVPrinter.PageNumbers = true;
            dGVPrinter.PageNumberInHeader = false;
            dGVPrinter.PorportionalColumns = true;
            dGVPrinter.HeaderCellAlignment = StringAlignment.Near;
            dGVPrinter.Footer = "Education";
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintDataGridView(dgvStudents);
        }

        private void Students_Teacher_Load(object sender, EventArgs e)
        {
            DataTable list = stBLL.ShowStudentList();
            dgvStudents.DataSource = list;
            dgvStudents.Columns["StudentID"].Visible = false;
        }
    }
}
