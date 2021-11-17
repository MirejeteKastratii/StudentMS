
namespace StudentMS.Students
{
    partial class StudentList
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
            this.lblListaStudenteve = new System.Windows.Forms.Label();
            this.btnRifreskoStudent = new System.Windows.Forms.Button();
            this.btnEditoStudent = new System.Windows.Forms.Button();
            this.btnFshijStudent = new System.Windows.Forms.Button();
            this.dgvListaStudenteve = new System.Windows.Forms.DataGridView();
            this.btn_PrintStudentList = new System.Windows.Forms.Button();
            this.btn_ExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaStudenteve)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaStudenteve
            // 
            this.lblListaStudenteve.AutoSize = true;
            this.lblListaStudenteve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblListaStudenteve.Location = new System.Drawing.Point(66, 47);
            this.lblListaStudenteve.Name = "lblListaStudenteve";
            this.lblListaStudenteve.Size = new System.Drawing.Size(200, 26);
            this.lblListaStudenteve.TabIndex = 2;
            this.lblListaStudenteve.Text = "Lista e studenteve :";
            this.lblListaStudenteve.Click += new System.EventHandler(this.lblListaStudenteve_Click);
            // 
            // btnRifreskoStudent
            // 
            this.btnRifreskoStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRifreskoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnRifreskoStudent.Location = new System.Drawing.Point(303, 47);
            this.btnRifreskoStudent.Name = "btnRifreskoStudent";
            this.btnRifreskoStudent.Size = new System.Drawing.Size(133, 47);
            this.btnRifreskoStudent.TabIndex = 0;
            this.btnRifreskoStudent.Text = "Rifresko";
            this.btnRifreskoStudent.UseVisualStyleBackColor = true;
            this.btnRifreskoStudent.Click += new System.EventHandler(this.btnRifreskoStudent_Click);
            // 
            // btnEditoStudent
            // 
            this.btnEditoStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditoStudent.Location = new System.Drawing.Point(442, 47);
            this.btnEditoStudent.Name = "btnEditoStudent";
            this.btnEditoStudent.Size = new System.Drawing.Size(133, 47);
            this.btnEditoStudent.TabIndex = 1;
            this.btnEditoStudent.Text = "Edito rekordin";
            this.btnEditoStudent.UseVisualStyleBackColor = true;
            // 
            // btnFshijStudent
            // 
            this.btnFshijStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFshijStudent.Location = new System.Drawing.Point(581, 47);
            this.btnFshijStudent.Name = "btnFshijStudent";
            this.btnFshijStudent.Size = new System.Drawing.Size(133, 47);
            this.btnFshijStudent.TabIndex = 2;
            this.btnFshijStudent.Text = "Fshij rekordin";
            this.btnFshijStudent.UseVisualStyleBackColor = true;
            this.btnFshijStudent.Click += new System.EventHandler(this.btnFshijStudent_Click);
            // 
            // dgvListaStudenteve
            // 
            this.dgvListaStudenteve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaStudenteve.Location = new System.Drawing.Point(14, 103);
            this.dgvListaStudenteve.Name = "dgvListaStudenteve";
            this.dgvListaStudenteve.RowHeadersWidth = 51;
            this.dgvListaStudenteve.RowTemplate.Height = 24;
            this.dgvListaStudenteve.Size = new System.Drawing.Size(700, 349);
            this.dgvListaStudenteve.TabIndex = 6;
            this.dgvListaStudenteve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaStudenteve_CellClick);
            // 
            // btn_PrintStudentList
            // 
            this.btn_PrintStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btn_PrintStudentList.Location = new System.Drawing.Point(14, 460);
            this.btn_PrintStudentList.Name = "btn_PrintStudentList";
            this.btn_PrintStudentList.Size = new System.Drawing.Size(133, 47);
            this.btn_PrintStudentList.TabIndex = 7;
            this.btn_PrintStudentList.Text = "Printo";
            this.btn_PrintStudentList.UseVisualStyleBackColor = true;
            this.btn_PrintStudentList.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_ExportToExcel
            // 
            this.btn_ExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btn_ExportToExcel.Location = new System.Drawing.Point(230, 460);
            this.btn_ExportToExcel.Name = "btn_ExportToExcel";
            this.btn_ExportToExcel.Size = new System.Drawing.Size(133, 47);
            this.btn_ExportToExcel.TabIndex = 8;
            this.btn_ExportToExcel.Text = "Eksporto ne Excel";
            this.btn_ExportToExcel.UseVisualStyleBackColor = true;
            this.btn_ExportToExcel.Click += new System.EventHandler(this.btn_ExportToExcel_Click);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(726, 519);
            this.Controls.Add(this.btn_ExportToExcel);
            this.Controls.Add(this.btn_PrintStudentList);
            this.Controls.Add(this.dgvListaStudenteve);
            this.Controls.Add(this.btnFshijStudent);
            this.Controls.Add(this.btnEditoStudent);
            this.Controls.Add(this.btnRifreskoStudent);
            this.Controls.Add(this.lblListaStudenteve);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaStudenteve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaStudenteve;
        private System.Windows.Forms.Button btnRifreskoStudent;
        private System.Windows.Forms.Button btnEditoStudent;
        private System.Windows.Forms.Button btnFshijStudent;
        private System.Windows.Forms.DataGridView dgvListaStudenteve;
        private System.Windows.Forms.Button btn_PrintStudentList;
        private System.Windows.Forms.Button btn_ExportToExcel;
    }
}