using DGVPrinterHelper;
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
    public partial class Vleresimet : Form
    {
        public Vleresimet()
        {
            InitializeComponent();
        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Mirejeta\source\repos\StudentMS\StudentMS\Help\UserManuali.chm", HelpNavigator.Topic, "VleresimetTeacher_Help.htm");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            CultureInfo culture = new CultureInfo("en-US");
            switch (comboBox3 .SelectedIndex)
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
            comboBox3_SelectedIndexChanged(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
            dGVPrinter.PrintDataGridView(dGvVlersimet);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dGvVlersimet.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exlApp = new Microsoft.Office.Interop.Excel.Application();
                exlApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dGvVlersimet.Columns.Count + 1; i++)
                {
                    exlApp.Cells[1, i] = dGvVlersimet.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dGvVlersimet.Rows.Count - 1; i++)
                {
                    for (int j = 3; j < dGvVlersimet.Columns.Count; j++)
                    {
                        exlApp.Cells[i + 2, j + 1] = dGvVlersimet.Rows[i].Cells[j].Value.ToString();
                    }
                }

                exlApp.Columns.AutoFit();
                exlApp.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Vleresimet_Load(object sender, EventArgs e)
        {

        }
    }
}
