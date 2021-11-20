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
using StudentMS_BLL;
using StudentMS_BO;
namespace StudentMS.Courses
{
    public partial class Vleresimi : Form
    {
        StudentBLL stBLL = new StudentBLL();
        CoursesBLL courseBLL = new CoursesBLL();
        VleresimetBLL vleresimiBLL = new VleresimetBLL();
      
        public Vleresimi()
        {
            InitializeComponent();
            LoadCourseData();
            LoadStudentData();
        }
        

        //mbushja e comboboxave me vlerat nga db
        public void LoadStudentData()
        {
            cbStudenti.DataSource = stBLL.ShowStudentList();
            cbStudenti.DisplayMember = "Emri";
            cbStudenti.ValueMember = "StudentID";
        }
        public void LoadCourseData()
        {
            cbLenda.DataSource = courseBLL.ShowCourses();
            cbLenda.DisplayMember = "Titulli";
            cbLenda.ValueMember = "CourseID";
        }
       
        private void btnRuaj_Click(object sender, EventArgs e)
        {
            VleresimetBO vleresimet = new VleresimetBO(Convert.ToInt32(cbLenda.SelectedValue), Convert.ToInt32(cbStudenti.SelectedValue),
               Convert.ToInt32(txtTesti1.Text), Convert.ToInt32(txtTesti2.Text), 
                Convert.ToInt32(txtNota.Text) );
            vleresimiBLL.InsertoVleresime(vleresimet);
        }



        public int ID;
  

      

         private void dgvVleresimet_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRow = dgvVleresimet.Rows[dgvVleresimet.SelectedCells[0].RowIndex];

            ID =  int.Parse(Convert.ToString(SelectedRow.Cells["VleresimiID"].Value));
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("A dëshironi ta fshini rekordin e selektuar.", "Paralajmërim për fshirje.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = vleresimiBLL.DeleteVleresimin(ID);
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
        private void btnRifresko_Click(object sender, EventArgs e)
        {
            DataTable list = vleresimiBLL.GetVleresimet();
            dgvVleresimet.DataSource = list;
            dgvVleresimet.Columns["VleresimiID"].Visible = false;
        }

        private void Vleresimi_Load(object sender, EventArgs e)
        {
            DataTable list = vleresimiBLL.GetVleresimet();
            dgvVleresimet.DataSource = list;
            dgvVleresimet.Columns["VleresimiID"].Visible = false;
        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Mirejeta\source\repos\StudentMS\StudentMS\Help\UserManuali.chm", HelpNavigator.Topic, "VleresimetTeacher_Help.htm");
        }

        private void cbGjuha_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");

            switch (cbGjuha.SelectedIndex)
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
            Vleresimi_Load(sender, e);
        }
    }
}
 