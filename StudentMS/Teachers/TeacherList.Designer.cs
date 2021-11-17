
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.brnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(14, 103);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(700, 404);
            this.dgvTeachers.TabIndex = 0;
            this.dgvTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellClick);
            // 
            // lblTeacherList
            // 
            this.lblTeacherList.AutoSize = true;
            this.lblTeacherList.Font = new System.Drawing.Font("Montserrat", 13F);
            this.lblTeacherList.Location = new System.Drawing.Point(41, 46);
            this.lblTeacherList.Name = "lblTeacherList";
            this.lblTeacherList.Size = new System.Drawing.Size(186, 25);
            this.lblTeacherList.TabIndex = 1;
            this.lblTeacherList.Text = "Lista e profesorëve:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(442, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 47);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Edito rekordin";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(581, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Fshij rekordin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // brnRefresh
            // 
            this.brnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnRefresh.Location = new System.Drawing.Point(303, 40);
            this.brnRefresh.Name = "brnRefresh";
            this.brnRefresh.Size = new System.Drawing.Size(133, 47);
            this.brnRefresh.TabIndex = 2;
            this.brnRefresh.Text = "Rifresko";
            this.brnRefresh.UseVisualStyleBackColor = true;
            this.brnRefresh.Click += new System.EventHandler(this.brnRefresh_Click);
            // 
            // TeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(726, 519);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.brnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTeacherList);
            this.Controls.Add(this.dgvTeachers);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button brnRefresh;
    }
}