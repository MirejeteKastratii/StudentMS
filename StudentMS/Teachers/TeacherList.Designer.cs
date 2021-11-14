
namespace StudentMS.Teachers
{
    partial class TeacherList
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
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.lblTeacherList = new System.Windows.Forms.Label();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(12, 85);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(776, 353);
            this.dgvTeachers.TabIndex = 0;
            // 
            // lblTeacherList
            // 
            this.lblTeacherList.AutoSize = true;
            this.lblTeacherList.Location = new System.Drawing.Point(27, 43);
            this.lblTeacherList.Name = "lblTeacherList";
            this.lblTeacherList.Size = new System.Drawing.Size(100, 13);
            this.lblTeacherList.TabIndex = 1;
            this.lblTeacherList.Text = "Lista e profesorëve:";
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(647, 26);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(141, 46);
            this.btnAddTeacher.TabIndex = 2;
            this.btnAddTeacher.Text = "Shto rekord";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // TeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.lblTeacherList);
            this.Controls.Add(this.dgvTeachers);
            this.Name = "TeacherList";
            this.Text = "TeacherList";
            this.Load += new System.EventHandler(this.TeacherList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Label lblTeacherList;
        private System.Windows.Forms.Button btnAddTeacher;
    }
}