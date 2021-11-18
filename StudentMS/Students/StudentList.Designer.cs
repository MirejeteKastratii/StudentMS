
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentList));
            this.lblListaStudenteve = new System.Windows.Forms.Label();
            this.btnRifreskoStudent = new System.Windows.Forms.Button();
            this.btnEditoStudent = new System.Windows.Forms.Button();
            this.btnFshijStudent = new System.Windows.Forms.Button();
            this.dgvListaStudenteve = new System.Windows.Forms.DataGridView();
            this.btn_PrintStudentList = new System.Windows.Forms.Button();
            this.btnDil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaStudenteve)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaStudenteve
            // 
            resources.ApplyResources(this.lblListaStudenteve, "lblListaStudenteve");
            this.lblListaStudenteve.Name = "lblListaStudenteve";
            this.lblListaStudenteve.Click += new System.EventHandler(this.lblListaStudenteve_Click);
            // 
            // btnRifreskoStudent
            // 
            resources.ApplyResources(this.btnRifreskoStudent, "btnRifreskoStudent");
            this.btnRifreskoStudent.Name = "btnRifreskoStudent";
            this.btnRifreskoStudent.UseVisualStyleBackColor = true;
            this.btnRifreskoStudent.Click += new System.EventHandler(this.btnRifreskoStudent_Click);
            // 
            // btnEditoStudent
            // 
            resources.ApplyResources(this.btnEditoStudent, "btnEditoStudent");
            this.btnEditoStudent.Name = "btnEditoStudent";
            this.btnEditoStudent.UseVisualStyleBackColor = true;
            // 
            // btnFshijStudent
            // 
            resources.ApplyResources(this.btnFshijStudent, "btnFshijStudent");
            this.btnFshijStudent.Name = "btnFshijStudent";
            this.btnFshijStudent.UseVisualStyleBackColor = true;
            this.btnFshijStudent.Click += new System.EventHandler(this.btnFshijStudent_Click);
            // 
            // dgvListaStudenteve
            // 
            resources.ApplyResources(this.dgvListaStudenteve, "dgvListaStudenteve");
            this.dgvListaStudenteve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaStudenteve.Name = "dgvListaStudenteve";
            this.dgvListaStudenteve.RowTemplate.Height = 24;
            this.dgvListaStudenteve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaStudenteve_CellClick);
            // 
            // btn_PrintStudentList
            // 
            resources.ApplyResources(this.btn_PrintStudentList, "btn_PrintStudentList");
            this.btn_PrintStudentList.Name = "btn_PrintStudentList";
            this.btn_PrintStudentList.UseVisualStyleBackColor = true;
            this.btn_PrintStudentList.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btnDil
            // 
            resources.ApplyResources(this.btnDil, "btnDil");
            this.btnDil.Name = "btnDil";
            this.btnDil.UseVisualStyleBackColor = true;
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // StudentList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.btn_PrintStudentList);
            this.Controls.Add(this.dgvListaStudenteve);
            this.Controls.Add(this.btnFshijStudent);
            this.Controls.Add(this.btnEditoStudent);
            this.Controls.Add(this.btnRifreskoStudent);
            this.Controls.Add(this.lblListaStudenteve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentList";
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
        private System.Windows.Forms.Button btnDil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}