
namespace StudentMS.Courses
{
    partial class AddCourse
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
            this.lblTitulli = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.lblSyllabusi = new System.Windows.Forms.Label();
            this.lblSesionet = new System.Windows.Forms.Label();
            this.txtSyllabusi = new System.Windows.Forms.TextBox();
            this.txtSessions = new System.Windows.Forms.TextBox();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.lblShtimiKurseve = new System.Windows.Forms.Label();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.btnDil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulli
            // 
            this.lblTitulli.AutoSize = true;
            this.lblTitulli.Location = new System.Drawing.Point(124, 151);
            this.lblTitulli.Name = "lblTitulli";
            this.lblTitulli.Size = new System.Drawing.Size(49, 17);
            this.lblTitulli.TabIndex = 0;
            this.lblTitulli.Text = "Titulli :";
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(266, 151);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(319, 23);
            this.txtCourseTitle.TabIndex = 0;
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.AutoSize = true;
            this.lblPershkrimi.Location = new System.Drawing.Point(124, 213);
            this.lblPershkrimi.Name = "lblPershkrimi";
            this.lblPershkrimi.Size = new System.Drawing.Size(82, 17);
            this.lblPershkrimi.TabIndex = 2;
            this.lblPershkrimi.Text = "Pershkrimi :";
            // 
            // lblSyllabusi
            // 
            this.lblSyllabusi.AutoSize = true;
            this.lblSyllabusi.Location = new System.Drawing.Point(124, 292);
            this.lblSyllabusi.Name = "lblSyllabusi";
            this.lblSyllabusi.Size = new System.Drawing.Size(72, 17);
            this.lblSyllabusi.TabIndex = 3;
            this.lblSyllabusi.Text = "Syllabusi :";
            // 
            // lblSesionet
            // 
            this.lblSesionet.AutoSize = true;
            this.lblSesionet.Location = new System.Drawing.Point(124, 387);
            this.lblSesionet.Name = "lblSesionet";
            this.lblSesionet.Size = new System.Drawing.Size(71, 17);
            this.lblSesionet.TabIndex = 4;
            this.lblSesionet.Text = "Sesionet :";
            // 
            // txtSyllabusi
            // 
            this.txtSyllabusi.Location = new System.Drawing.Point(266, 292);
            this.txtSyllabusi.Multiline = true;
            this.txtSyllabusi.Name = "txtSyllabusi";
            this.txtSyllabusi.Size = new System.Drawing.Size(319, 61);
            this.txtSyllabusi.TabIndex = 2;
            // 
            // txtSessions
            // 
            this.txtSessions.Location = new System.Drawing.Point(266, 387);
            this.txtSessions.Name = "txtSessions";
            this.txtSessions.Size = new System.Drawing.Size(319, 23);
            this.txtSessions.TabIndex = 3;
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(266, 213);
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(319, 57);
            this.txtCourseDescription.TabIndex = 1;
            // 
            // lblShtimiKurseve
            // 
            this.lblShtimiKurseve.AutoSize = true;
            this.lblShtimiKurseve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblShtimiKurseve.Location = new System.Drawing.Point(261, 69);
            this.lblShtimiKurseve.Name = "lblShtimiKurseve";
            this.lblShtimiKurseve.Size = new System.Drawing.Size(179, 26);
            this.lblShtimiKurseve.TabIndex = 8;
            this.lblShtimiKurseve.Text = "Shtimi i kurseve :";
            // 
            // btnRuaj
            // 
            this.btnRuaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuaj.Location = new System.Drawing.Point(442, 437);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(113, 42);
            this.btnRuaj.TabIndex = 4;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // btnDil
            // 
            this.btnDil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDil.Location = new System.Drawing.Point(582, 437);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(113, 42);
            this.btnDil.TabIndex = 5;
            this.btnDil.Text = "Dil";
            this.btnDil.UseVisualStyleBackColor = true;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(726, 519);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.lblShtimiKurseve);
            this.Controls.Add(this.txtCourseDescription);
            this.Controls.Add(this.txtSessions);
            this.Controls.Add(this.txtSyllabusi);
            this.Controls.Add(this.lblSesionet);
            this.Controls.Add(this.lblSyllabusi);
            this.Controls.Add(this.lblPershkrimi);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.lblTitulli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulli;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.Label lblSyllabusi;
        private System.Windows.Forms.Label lblSesionet;
        private System.Windows.Forms.TextBox txtSyllabusi;
        private System.Windows.Forms.TextBox txtSessions;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.Label lblShtimiKurseve;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.Button btnDil;
    }
}