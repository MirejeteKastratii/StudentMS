using DGVPrinterHelper;
using StudentMS_BLL;
using StudentMS_BO;
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

namespace StudentMS.Users
{
    public partial class ManageUsers : Form
    {
        UsersBLL usersService = new UsersBLL();
        public ManageUsers()
        {
            InitializeComponent();
        }

 
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            DataTable list = usersService.ShowUsers();
            dgvUsers.DataSource = list;
            dgvUsers.Columns["UserID"].Visible = false;
        }

        int userID;

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedRow = dgvUsers.Rows[dgvUsers.SelectedCells[0].RowIndex];
            userID = int.Parse(Convert.ToString(SelectedRow.Cells["UserID"].Value));
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("A dëshironi ta fshini rekordin e selektuar.", "Paralajmërim për fshirje.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = usersService.DeleteUser(userID);
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

        private void btnRifreskoManage_Click(object sender, EventArgs e)
        {
            DataTable list = usersService.ShowUsers();
            dgvUsers.DataSource = list;
            dgvUsers.Columns["UserID"].Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.Title = "Lista e përdoruesëve.";
            dGVPrinter.SubTitle = "Lista e përdoruesëve me të dhënat personale!";
            dGVPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dGVPrinter.PageNumbers = true;
            dGVPrinter.PageNumberInHeader = false;
            dGVPrinter.PorportionalColumns = true;
            dGVPrinter.HeaderCellAlignment = StringAlignment.Near;
            dGVPrinter.Footer = "Education";
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintDataGridView(dgvUsers);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //prove per kalimin e suers ne excel
            if (dgvUsers.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application exlApp = new Microsoft.Office.Interop.Excel.Application();
                exlApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvUsers.Columns.Count + 1; i++)
                {
                    exlApp.Cells[1, i] = dgvUsers.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dgvUsers.Rows.Count - 1; i++)
                {
                    for (int j = 3; j < dgvUsers.Columns.Count; j++)
                    {
                        exlApp.Cells[i + 2, j + 1] = dgvUsers.Rows[i].Cells[j].Value.ToString();
                    }
                }

                exlApp.Columns.AutoFit();
                exlApp.Visible = true;
            }
        }
        int role;

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbRoles.SelectedIndex)
            {
                case 0:
                    role = 1;
                    break;
                case 1:
                    role = 2;
                    break;
                default:
                    role = 1;
                    break;
            }
        }
        private void btnEditUsers_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            UsersBO userBO = new UsersBO(txtUserName.Text, txtPass.Text, role);
            usersService.AddUsers(userBO);
        }

        private void btnClose_Click(object sender, EventArgs e)
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
            CultureInfo culture = new CultureInfo("en-US");
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
            ManageUsers_Load(sender, e);
        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Mirejeta\source\repos\StudentMS\StudentMS\Help\UserManuali.chm", HelpNavigator.Topic, "ManageUsersAdmin_Help.htm");
        }
    }
}