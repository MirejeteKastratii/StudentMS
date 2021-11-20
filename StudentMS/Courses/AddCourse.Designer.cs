
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulli
            // 
            resources.ApplyResources(this.lblTitulli, "lblTitulli");
            this.lblTitulli.Name = "lblTitulli";
            // 
            // txtCourseTitle
            // 
            resources.ApplyResources(this.txtCourseTitle, "txtCourseTitle");
            this.txtCourseTitle.Name = "txtCourseTitle";
            // 
            // lblPershkrimi
            // 
            resources.ApplyResources(this.lblPershkrimi, "lblPershkrimi");
            this.lblPershkrimi.Name = "lblPershkrimi";
            // 
            // lblSyllabusi
            // 
            resources.ApplyResources(this.lblSyllabusi, "lblSyllabusi");
            this.lblSyllabusi.Name = "lblSyllabusi";
            // 
            // lblSesionet
            // 
            resources.ApplyResources(this.lblSesionet, "lblSesionet");
            this.lblSesionet.Name = "lblSesionet";
            // 
            // txtSyllabusi
            // 
            resources.ApplyResources(this.txtSyllabusi, "txtSyllabusi");
            this.txtSyllabusi.Name = "txtSyllabusi";
            // 
            // txtSessions
            // 
            resources.ApplyResources(this.txtSessions, "txtSessions");
            this.txtSessions.Name = "txtSessions";
            // 
            // txtCourseDescription
            // 
            resources.ApplyResources(this.txtCourseDescription, "txtCourseDescription");
            this.txtCourseDescription.Name = "txtCourseDescription";
            // 
            // lblShtimiKurseve
            // 
            resources.ApplyResources(this.lblShtimiKurseve, "lblShtimiKurseve");
            this.lblShtimiKurseve.Name = "lblShtimiKurseve";
            // 
            // btnRuaj
            // 
            resources.ApplyResources(this.btnRuaj, "btnRuaj");
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // btnDil
            // 
            resources.ApplyResources(this.btnDil, "btnDil");
            this.btnDil.Name = "btnDil";
            this.btnDil.UseVisualStyleBackColor = true;
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnEdito
            // 
            resources.ApplyResources(this.btnEdito, "btnEdito");
            this.btnEdito.Name = "btnEdito";
            this.btnEdito.UseVisualStyleBackColor = true;
            this.btnEdito.Click += new System.EventHandler(this.btnEdito_Click);
            // 
            // AddCourse
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.btnEdito);
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
            this.Name = "AddCourse";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdito;
    }
}