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

namespace StudentMS.Students
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDilStudent_Click(object sender, EventArgs e)
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
            label1_Click(sender, e);
        }
    }
}
