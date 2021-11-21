using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMS_BLL;
namespace StudentMS.Students
{
    public partial class StudentsRaport : Form
    {
        public StudentsRaport()
        {
            InitializeComponent();
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.Close();
            btnFemer.Checked = false;
            btnMashkull.Checked = false;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            string gender;
            if (btnFemer.Checked)
            {
                gender = "F";
            }
            else
                gender = "M";
            StudentBLL stBll = new StudentBLL();
            DataSet list =stBll.StudentsByGender(gender);

            dgvGender.DataSource = list.Tables[0];
        }
    }
}
