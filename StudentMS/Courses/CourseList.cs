using DGVPrinterHelper;
using StudentMS_BLL;
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

namespace StudentMS.Courses
{
    public partial class CourseList : Form
    {
        public CourseList()
        {
            InitializeComponent();
        }
        //refresh
        private void btnRifreskoKurset_Click(object sender, EventArgs e)
        {
            CoursesBLL coursesBLL = new CoursesBLL();
            DataTable list = coursesBLL.ShowCourses();
            dgvListaKurseve.DataSource = list;
        }
        //
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

        private void btnExcel_Click(object sender, EventArgs e)
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

        private void btnDil_Click(object sender, EventArgs e)
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
            CourseList_Load(sender, e);
        }

       

        private void pbHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Mirejeta\source\repos\StudentMS\StudentMS\Help\UserManuali.chm", HelpNavigator.Topic, "CourseListAdmin_Help.htm");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}