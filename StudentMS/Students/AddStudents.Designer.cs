
namespace StudentMS.Students
{
    partial class AddStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudents));
            this.lblShtimiStudent = new System.Windows.Forms.Label();
            this.lblEmri = new System.Windows.Forms.Label();
            this.lblMbiemri = new System.Windows.Forms.Label();
            this.lblDataLindjes = new System.Windows.Forms.Label();
            this.lblGjinia = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumriTell = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.btnRuajStudent = new System.Windows.Forms.Button();
            this.btnDilStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShtimiStudent
            // 
            resources.ApplyResources(this.lblShtimiStudent, "lblShtimiStudent");
            this.lblShtimiStudent.Name = "lblShtimiStudent";
            // 
            // lblEmri
            // 
            resources.ApplyResources(this.lblEmri, "lblEmri");
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMbiemri
            // 
            resources.ApplyResources(this.lblMbiemri, "lblMbiemri");
            this.lblMbiemri.Name = "lblMbiemri";
            // 
            // lblDataLindjes
            // 
            resources.ApplyResources(this.lblDataLindjes, "lblDataLindjes");
            this.lblDataLindjes.Name = "lblDataLindjes";
            // 
            // lblGjinia
            // 
            resources.ApplyResources(this.lblGjinia, "lblGjinia");
            this.lblGjinia.Name = "lblGjinia";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // lblNumriTell
            // 
            resources.ApplyResources(this.lblNumriTell, "lblNumriTell");
            this.lblNumriTell.Name = "lblNumriTell";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // rbtnF
            // 
            resources.ApplyResources(this.rbtnF, "rbtnF");
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.TabStop = true;
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // rbtnM
            // 
            resources.ApplyResources(this.rbtnM, "rbtnM");
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.TabStop = true;
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // btnRuajStudent
            // 
            resources.ApplyResources(this.btnRuajStudent, "btnRuajStudent");
            this.btnRuajStudent.Name = "btnRuajStudent";
            this.btnRuajStudent.UseVisualStyleBackColor = true;
            this.btnRuajStudent.Click += new System.EventHandler(this.btnRuajStudent_Click);
            // 
            // btnDilStudent
            // 
            resources.ApplyResources(this.btnDilStudent, "btnDilStudent");
            this.btnDilStudent.Name = "btnDilStudent";
            this.btnDilStudent.UseVisualStyleBackColor = true;
            this.btnDilStudent.Click += new System.EventHandler(this.btnDilStudent_Click);
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
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AddStudents
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDilStudent);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRuajStudent);
            this.Controls.Add(this.rbtnM);
            this.Controls.Add(this.rbtnF);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblNumriTell);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGjinia);
            this.Controls.Add(this.lblDataLindjes);
            this.Controls.Add(this.lblMbiemri);
            this.Controls.Add(this.lblEmri);
            this.Controls.Add(this.lblShtimiStudent);
            this.Name = "AddStudents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShtimiStudent;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.Label lblMbiemri;
        private System.Windows.Forms.Label lblDataLindjes;
        private System.Windows.Forms.Label lblGjinia;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumriTell;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.Button btnRuajStudent;
        private System.Windows.Forms.Button btnDilStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEdit;
    }
}