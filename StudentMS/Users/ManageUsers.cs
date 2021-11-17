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

namespace StudentMS.Users
{
    public partial class ManageUsers : Form
    {
        UsersBLL usersService = new UsersBLL();
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            //fshije
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
    }
}
