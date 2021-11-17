using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string role = "";
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlLogin.Left = btnAdmin.Left;
            pnlLogin.Width = btnAdmin.Width;
            pnlLogin.BackColor = Color.Pink;
            role = "Admin";


        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            pnlLogin.Left = btnTeacher.Left;
            pnlLogin.Width = btnTeacher.Width;
            pnlLogin.BackColor = Color.LightGreen;
            role = "Teacher";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ju lutem shkruani emrin dhe fjalëkalimin e përdoruesit.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (DbConn.conn = new SqlConnection(DbConn.connString))
                    {
                        DbConn.dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE UserName = '" + txtUserName.Text + "' AND UserPass = '" + txtPassword.Text + "'", DbConn.conn);
                        DataTable dTable = new DataTable();
                        DbConn.dataAdapter.Fill(dTable);

                        if (dTable.Rows[0][0].ToString() == "1")
                        {
                            this.Hide();
                            if (role == "Admin")
                            {
                                new Teachers.Home().Show();
                            }
                           else if (role == "Teacher")
                            {
                                new Teachers.TeacherHome().Show();
                            }
                            else if(role == "")
                            {
                                MessageBox.Show("Ju lutem zgjidhni rolin tuaj.");
                            }
                        }
                        else
                            MessageBox.Show("Emri ose Fjalëkalimi është i gabuar.");
                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        private void LogIN_Load(object sender, EventArgs e)
        {

        }
    }
}
