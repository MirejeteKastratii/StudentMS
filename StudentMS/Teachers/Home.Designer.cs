
namespace StudentMS.Teachers
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewStaff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnAddCourses = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnAddStudents = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.FlatAppearance.BorderSize = 0;
            this.btnViewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnViewStaff.ForeColor = System.Drawing.Color.White;
            this.btnViewStaff.Location = new System.Drawing.Point(14, 133);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(184, 46);
            this.btnViewStaff.TabIndex = 0;
            this.btnViewStaff.Text = "Shiko Profesorët";
            this.btnViewStaff.UseVisualStyleBackColor = true;
            this.btnViewStaff.Click += new System.EventHandler(this.btnViewStaff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.btnManageUsers);
            this.panel1.Controls.Add(this.btnAddStudents);
            this.panel1.Controls.Add(this.btnViewStudents);
            this.panel1.Controls.Add(this.btnAddCourses);
            this.panel1.Controls.Add(this.btnViewCourses);
            this.panel1.Controls.Add(this.btnAddStaff);
            this.panel1.Controls.Add(this.btnViewStaff);
            this.panel1.Controls.Add(this.pnlActive);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 519);
            this.panel1.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Thistle;
            this.pnlContent.Location = new System.Drawing.Point(206, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(726, 519);
            this.pnlContent.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 89);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentMS.Properties.Resources.Capture_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlActive.Location = new System.Drawing.Point(3, 133);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(12, 46);
            this.pnlActive.TabIndex = 2;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(14, 186);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(184, 46);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Shto Profesor";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.FlatAppearance.BorderSize = 0;
            this.btnViewCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnViewCourses.ForeColor = System.Drawing.Color.White;
            this.btnViewCourses.Location = new System.Drawing.Point(13, 243);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(184, 46);
            this.btnViewCourses.TabIndex = 0;
            this.btnViewCourses.Text = "Shiko Kurset";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // btnAddCourses
            // 
            this.btnAddCourses.FlatAppearance.BorderSize = 0;
            this.btnAddCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddCourses.ForeColor = System.Drawing.Color.White;
            this.btnAddCourses.Location = new System.Drawing.Point(13, 297);
            this.btnAddCourses.Name = "btnAddCourses";
            this.btnAddCourses.Size = new System.Drawing.Size(184, 46);
            this.btnAddCourses.TabIndex = 0;
            this.btnAddCourses.Text = "Shto Kurs";
            this.btnAddCourses.UseVisualStyleBackColor = true;
            this.btnAddCourses.Click += new System.EventHandler(this.btnAddCourses_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.FlatAppearance.BorderSize = 0;
            this.btnViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnViewStudents.ForeColor = System.Drawing.Color.White;
            this.btnViewStudents.Location = new System.Drawing.Point(13, 350);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(184, 46);
            this.btnViewStudents.TabIndex = 0;
            this.btnViewStudents.Text = "Shiko Nxenesit";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.FlatAppearance.BorderSize = 0;
            this.btnAddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddStudents.ForeColor = System.Drawing.Color.White;
            this.btnAddStudents.Location = new System.Drawing.Point(13, 403);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Size = new System.Drawing.Size(184, 46);
            this.btnAddStudents.TabIndex = 0;
            this.btnAddStudents.Text = "Shto Nxenes";
            this.btnAddStudents.UseVisualStyleBackColor = true;
            this.btnAddStudents.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(14, 456);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(184, 46);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Menaxho përdoruesit";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblAdmin.ForeColor = System.Drawing.Color.LightGreen;
            this.lblAdmin.Location = new System.Drawing.Point(70, 108);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(67, 22);
            this.lblAdmin.TabIndex = 3;
            this.lblAdmin.Text = "ADMIN";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Button btnAddStudents;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnAddCourses;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Label lblAdmin;
    }
}