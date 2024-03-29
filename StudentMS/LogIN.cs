﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
                            else if (role == "")
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

        private void cbGjuha_SelectedIndexChanged(object sender, EventArgs e)
        {

            CultureInfo culture = new CultureInfo("sq-XK");
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
            //inicializo komponentet me kulturen e paracaktuar
            InitializeComponent();
            LogIN_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Mirejeta\source\repos\StudentMS\StudentMS\Help\UserManuali.chm", HelpNavigator.Topic, "LogIn_Help.htm");
        }
    }
}
