
namespace StudentMS.Courses
{
    partial class CourseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseList));
            this.dgvListaKurseve = new System.Windows.Forms.DataGridView();
            this.lblListaKurseve = new System.Windows.Forms.Label();
            this.btnRifreskoKurset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrinto = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDil = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.txtCourseDescription = new System.Windows.Forms.RichTextBox();
            this.txtSyllabusi = new System.Windows.Forms.RichTextBox();
            this.txtSessions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKurseve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaKurseve
            // 
            resources.ApplyResources(this.dgvListaKurseve, "dgvListaKurseve");
            this.dgvListaKurseve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKurseve.Name = "dgvListaKurseve";
            this.dgvListaKurseve.RowTemplate.Height = 24;
            this.dgvListaKurseve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaKurseve_CellClick);
            // 
            // lblListaKurseve
            // 
            resources.ApplyResources(this.lblListaKurseve, "lblListaKurseve");
            this.lblListaKurseve.Name = "lblListaKurseve";
            // 
            // btnRifreskoKurset
            // 
            resources.ApplyResources(this.btnRifreskoKurset, "btnRifreskoKurset");
            this.btnRifreskoKurset.Name = "btnRifreskoKurset";
            this.btnRifreskoKurset.UseVisualStyleBackColor = true;
            this.btnRifreskoKurset.Click += new System.EventHandler(this.btnRifreskoKurset_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrinto
            // 
            resources.ApplyResources(this.btnPrinto, "btnPrinto");
            this.btnPrinto.Name = "btnPrinto";
            this.btnPrinto.UseVisualStyleBackColor = true;
            this.btnPrinto.Click += new System.EventHandler(this.btnPrinto_Click);
            // 
            // btnExcel
            // 
            resources.ApplyResources(this.btnExcel, "btnExcel");
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
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
            // pbHelp
            // 
            resources.ApplyResources(this.pbHelp, "pbHelp");
            this.pbHelp.Image = global::StudentMS.Properties.Resources.help_question_icon_13201613888629608821;
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtCourseTitle
            // 
            resources.ApplyResources(this.txtCourseTitle, "txtCourseTitle");
            this.txtCourseTitle.Name = "txtCourseTitle";
            // 
            // txtCourseDescription
            // 
            resources.ApplyResources(this.txtCourseDescription, "txtCourseDescription");
            this.txtCourseDescription.Name = "txtCourseDescription";
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnADD
            // 
            resources.ApplyResources(this.btnADD, "btnADD");
            this.btnADD.Name = "btnADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // CourseList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSyllabusi);
            this.Controls.Add(this.txtCourseDescription);
            this.Controls.Add(this.txtSessions);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPrinto);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRifreskoKurset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblListaKurseve);
            this.Controls.Add(this.dgvListaKurseve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseList";
            this.Load += new System.EventHandler(this.CourseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKurseve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaKurseve;
        private System.Windows.Forms.Label lblListaKurseve;
        private System.Windows.Forms.Button btnRifreskoKurset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrinto;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnDil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.RichTextBox txtCourseDescription;
        private System.Windows.Forms.RichTextBox txtSyllabusi;
        private System.Windows.Forms.TextBox txtSessions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}