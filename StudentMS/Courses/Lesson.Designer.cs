namespace StudentMS.Courses
{
    partial class Lesson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNumriOres = new System.Windows.Forms.TextBox();
            this.cmbLenda = new System.Windows.Forms.ComboBox();
            this.cmbMesuesi = new System.Windows.Forms.ComboBox();
            this.txtTemaMesimore = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRifresko = new System.Windows.Forms.Button();
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label1.Location = new System.Drawing.Point(74, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label2.Location = new System.Drawing.Point(22, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numri i orës :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label3.Location = new System.Drawing.Point(67, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lënda :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label4.Location = new System.Drawing.Point(54, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mësuesi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label5.Location = new System.Drawing.Point(0, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tema mësimore :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 142);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtNumriOres
            // 
            this.txtNumriOres.Location = new System.Drawing.Point(134, 188);
            this.txtNumriOres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumriOres.Name = "txtNumriOres";
            this.txtNumriOres.Size = new System.Drawing.Size(144, 20);
            this.txtNumriOres.TabIndex = 1;
            // 
            // cmbLenda
            // 
            this.cmbLenda.FormattingEnabled = true;
            this.cmbLenda.Location = new System.Drawing.Point(134, 235);
            this.cmbLenda.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLenda.Name = "cmbLenda";
            this.cmbLenda.Size = new System.Drawing.Size(144, 21);
            this.cmbLenda.TabIndex = 2;
            this.cmbLenda.SelectedIndexChanged += new System.EventHandler(this.cmbLenda_SelectedIndexChanged);
            // 
            // cmbMesuesi
            // 
            this.cmbMesuesi.FormattingEnabled = true;
            this.cmbMesuesi.Location = new System.Drawing.Point(134, 289);
            this.cmbMesuesi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMesuesi.Name = "cmbMesuesi";
            this.cmbMesuesi.Size = new System.Drawing.Size(144, 21);
            this.cmbMesuesi.TabIndex = 3;
            // 
            // txtTemaMesimore
            // 
            this.txtTemaMesimore.Location = new System.Drawing.Point(134, 333);
            this.txtTemaMesimore.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemaMesimore.Name = "txtTemaMesimore";
            this.txtTemaMesimore.Size = new System.Drawing.Size(144, 20);
            this.txtTemaMesimore.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(614, 466);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Dil";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrint.Location = new System.Drawing.Point(396, 466);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 36);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Printo";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRifresko
            // 
            this.btnRifresko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRifresko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRifresko.Location = new System.Drawing.Point(506, 40);
            this.btnRifresko.Margin = new System.Windows.Forms.Padding(2);
            this.btnRifresko.Name = "btnRifresko";
            this.btnRifresko.Size = new System.Drawing.Size(104, 36);
            this.btnRifresko.TabIndex = 7;
            this.btnRifresko.Text = "Rifresko";
            this.btnRifresko.UseVisualStyleBackColor = true;
            this.btnRifresko.Click += new System.EventHandler(this.btnRifresko_Click);
            // 
            // dgvLessons
            // 
            this.dgvLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessons.Location = new System.Drawing.Point(307, 90);
            this.dgvLessons.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLessons.Name = "dgvLessons";
            this.dgvLessons.RowHeadersWidth = 51;
            this.dgvLessons.RowTemplate.Height = 24;
            this.dgvLessons.Size = new System.Drawing.Size(411, 353);
            this.dgvLessons.TabIndex = 14;
            this.dgvLessons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLessons_CellClick);
            this.dgvLessons.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLessons_CellContentDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(59, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Regjistro orën :";
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcel.Location = new System.Drawing.Point(506, 466);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(104, 36);
            this.btnExcel.TabIndex = 10;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(313, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lista e orëve:";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Location = new System.Drawing.Point(614, 40);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Fshij rekordin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInsert.Location = new System.Drawing.Point(64, 387);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(104, 36);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Inserto";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.Location = new System.Drawing.Point(174, 387);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edito";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 466);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label6.Location = new System.Drawing.Point(67, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Zgjidh gjuhën:";
            // 
            // Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 519);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvLessons);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRifresko);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTemaMesimore);
            this.Controls.Add(this.cmbMesuesi);
            this.Controls.Add(this.cmbLenda);
            this.Controls.Add(this.txtNumriOres);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lesson";
            this.Text = "Lesson";
            this.Load += new System.EventHandler(this.Lesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNumriOres;
        private System.Windows.Forms.ComboBox cmbLenda;
        private System.Windows.Forms.ComboBox cmbMesuesi;
        private System.Windows.Forms.TextBox txtTemaMesimore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRifresko;
        private System.Windows.Forms.DataGridView dgvLessons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}