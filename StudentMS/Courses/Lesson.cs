using DGVPrinterHelper;
using StudentMS_BLL;
using StudentMS_BO;
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
    
    public partial class Lesson : Form
    {
        LessionBLL service = new LessionBLL();
        TeacherBLL tchBll = new TeacherBLL();
        CoursesBLL courseBLL = new CoursesBLL();
        public Lesson()
        {
            InitializeComponent();
            LoadTeachers();
            LoadCourses();
        }
        public void LoadTeachers()
        {
            cmbMesuesi.DataSource = tchBll.ShowTeachers();
            cmbMesuesi.DisplayMember = "Emri";
            cmbMesuesi.ValueMember = "TeacherID";
        }
        public void LoadCourses()
        {
            cmbLenda.DataSource = courseBLL.ShowCourses();
            cmbLenda.DisplayMember = "Titulli";
            cmbLenda.ValueMember = "CourseID";
        }

        private void btnClose_Click(object sender, EventArgs e)
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
            if (dgvLessons.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exlApp = new Microsoft.Office.Interop.Excel.Application();
                exlApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvLessons.Columns.Count + 1; i++)
                {
                    exlApp.Cells[1, i] = dgvLessons.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dgvLessons.Rows.Count - 1; i++)
                {
                    for (int j = 3; j < dgvLessons.Columns.Count; j++)
                    {
                        exlApp.Cells[i + 2, j + 1] = dgvLessons.Rows[i].Cells[j].Value.ToString();
                    }
                }

                exlApp.Columns.AutoFit();
                exlApp.Visible = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.Title = "Lista e orëve";
            dGVPrinter.SubTitle = "Lista me detajet për orët !";
            dGVPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dGVPrinter.PageNumbers = true;
            dGVPrinter.PageNumberInHeader = false;
            dGVPrinter.PorportionalColumns = true;
            dGVPrinter.HeaderCellAlignment = StringAlignment.Near;
            dGVPrinter.Footer = "Education";
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintDataGridView(dgvLessons);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("A dëshironi ta fshini rekordin e selektuar.", "Paralajmërim për fshirje.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = service.DeleteLession(ID);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LessionBO ora = new LessionBO(ID, dateTimePicker1.Value, Convert.ToInt32(txtNumriOres.Text), Convert.ToInt32(((DataRowView)cmbLenda.SelectedValue)["CourseID"]), Convert.ToInt32(cmbMesuesi.SelectedValue.ToString()), txtTemaMesimore.Text);
            service.UpdateLession(ora);
            

            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;

            }
            dateTimePicker1.Value = DateTimePicker.MaximumDateTime;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            LessionBO ora = new LessionBO(dateTimePicker1.Value,Convert.ToInt32(txtNumriOres.Text), Convert.ToInt32(((DataRowView)cmbLenda.SelectedValue)["CourseID"]), Convert.ToInt32(cmbMesuesi.SelectedValue.ToString()), txtTemaMesimore.Text);
            service.InsertLessions(ora);
              foreach (var c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;

            }
            dateTimePicker1.Value = DateTimePicker.MaximumDateTime;
        }

        private void btnRifresko_Click(object sender, EventArgs e)
        {
            DataTable list = service.LessionLista();
            dgvLessons.DataSource = list;
            dgvLessons.Columns["OraID"].Visible = false;
        }

        private void Lesson_Load(object sender, EventArgs e)
        {
            DataTable list = service.LessionLista();
            dgvLessons.DataSource = list;
            dgvLessons.Columns["OraID"].Visible = false;
        }

        int ID;
        private void dgvLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRow = dgvLessons.Rows[dgvLessons.SelectedCells[0].RowIndex];

            ID = int.Parse(Convert.ToString(SelectedRow.Cells["OraID"].Value));
        }

        private void cmbLenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvLessons_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LessionBLL oraBLL = new LessionBLL();
            LessionBO oraBO = oraBLL.GetLessionByID(ID);
            FillData(oraBO);
        }
        public void FillData(LessionBO lessionBo)
        {
            dateTimePicker1.Value = lessionBo.Data;
            txtNumriOres.Text = Convert.ToString( lessionBo.NrOres);
            cmbLenda.SelectedIndex = lessionBo.LendaID;
            cmbMesuesi.SelectedIndex = lessionBo.MesuesiID;
            txtTemaMesimore.Text = lessionBo.TemaMesimore;

        }
    }
}
