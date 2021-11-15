using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMS_DAL;

namespace StudentMS
{
    public partial class LogIN : Form
    {
        public LogIN()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlLogin.Left = btnAdmin.Left;
            pnlLogin.Width = btnAdmin.Width;
            pnlLogin.BackColor = Color.Pink;


        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            pnlLogin.Left = btnTeacher.Left;
            pnlLogin.Width = btnTeacher.Width;
            pnlLogin.BackColor = Color.LightGreen;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ju lutem shkruani emrin dhe fjalëkalimin e përdoruesit.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            }
            else
            {
                try
                {
                   //perdore lidhjen me db per me e realizu log inin, ne baze te butonave qe useri i shtyp shfaqja pamjen e teacherit apo adminit
                }
            }
        }
    }
}
