
namespace StudentMS.Teachers
{
    partial class TeacherHome
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnVleresimet = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.LightGreen;
            this.pnlContent.Location = new System.Drawing.Point(206, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(726, 519);
            this.pnlContent.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.btnStudent);
            this.panel2.Controls.Add(this.btnVleresimet);
            this.panel2.Controls.Add(this.btnCourses);
            this.panel2.Controls.Add(this.pnlActive);
            this.panel2.Controls.Add(this.lblTeacher);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 519);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 96);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentMS.Properties.Resources.Capture_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTeacher.Location = new System.Drawing.Point(59, 125);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(89, 22);
            this.lblTeacher.TabIndex = 1;
            this.lblTeacher.Text = "TEACHER";
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.LightGreen;
            this.pnlActive.Location = new System.Drawing.Point(3, 150);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(12, 46);
            this.pnlActive.TabIndex = 2;
            // 
            // btnCourses
            // 
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(14, 176);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(184, 46);
            this.btnCourses.TabIndex = 3;
            this.btnCourses.Text = "Shiko kurset";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnVleresimet
            // 
            this.btnVleresimet.FlatAppearance.BorderSize = 0;
            this.btnVleresimet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVleresimet.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btnVleresimet.ForeColor = System.Drawing.Color.White;
            this.btnVleresimet.Location = new System.Drawing.Point(14, 228);
            this.btnVleresimet.Name = "btnVleresimet";
            this.btnVleresimet.Size = new System.Drawing.Size(184, 46);
            this.btnVleresimet.TabIndex = 3;
            this.btnVleresimet.Text = "Shiko vlerësimet";
            this.btnVleresimet.UseVisualStyleBackColor = true;
            this.btnVleresimet.Click += new System.EventHandler(this.btnVleresimet_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Location = new System.Drawing.Point(15, 280);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(184, 46);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Shiko studentët";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // TeacherHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.Name = "TeacherHome";
            this.Text = "TeacherHome";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnVleresimet;
    }
}