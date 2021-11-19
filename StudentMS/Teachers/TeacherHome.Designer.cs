
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherHome));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnVleresimet = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            resources.ApplyResources(this.pnlContent, "pnlContent");
            this.pnlContent.BackColor = System.Drawing.Color.LightGreen;
            this.pnlContent.Name = "pnlContent";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pbHelp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnStudent);
            this.panel2.Controls.Add(this.btnVleresimet);
            this.panel2.Controls.Add(this.btnCourses);
            this.panel2.Controls.Add(this.pnlActive);
            this.panel2.Controls.Add(this.lblTeacher);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Name = "panel2";
            // 
            // pbHelp
            // 
            resources.ApplyResources(this.pbHelp, "pbHelp");
            this.pbHelp.Image = global::StudentMS.Properties.Resources.help_question_icon_13201613888629608821;
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnStudent
            // 
            resources.ApplyResources(this.btnStudent, "btnStudent");
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnVleresimet
            // 
            resources.ApplyResources(this.btnVleresimet, "btnVleresimet");
            this.btnVleresimet.FlatAppearance.BorderSize = 0;
            this.btnVleresimet.ForeColor = System.Drawing.Color.White;
            this.btnVleresimet.Name = "btnVleresimet";
            this.btnVleresimet.UseVisualStyleBackColor = true;
            this.btnVleresimet.Click += new System.EventHandler(this.btnVleresimet_Click);
            // 
            // btnCourses
            // 
            resources.ApplyResources(this.btnCourses, "btnCourses");
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // pnlActive
            // 
            resources.ApplyResources(this.pnlActive, "pnlActive");
            this.pnlActive.BackColor = System.Drawing.Color.LightGreen;
            this.pnlActive.Name = "pnlActive";
            // 
            // lblTeacher
            // 
            resources.ApplyResources(this.lblTeacher, "lblTeacher");
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTeacher.Name = "lblTeacher";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Name = "panel3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::StudentMS.Properties.Resources.Capture_removebg_preview;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::StudentMS.Properties.Resources.help_question_icon_13201613888629608821;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // TeacherHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContent);
            this.Name = "TeacherHome";
            this.Load += new System.EventHandler(this.TeacherHome_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}