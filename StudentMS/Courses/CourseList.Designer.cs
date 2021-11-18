
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
            this.dgvListaKurseve = new System.Windows.Forms.DataGridView();
            this.lblListaKurseve = new System.Windows.Forms.Label();
            this.btnRifreskoKurset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPrinto = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKurseve)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaKurseve
            // 
            this.dgvListaKurseve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKurseve.Location = new System.Drawing.Point(14, 103);
            this.dgvListaKurseve.Name = "dgvListaKurseve";
            this.dgvListaKurseve.RowHeadersWidth = 51;
            this.dgvListaKurseve.RowTemplate.Height = 24;
            this.dgvListaKurseve.Size = new System.Drawing.Size(700, 353);
            this.dgvListaKurseve.TabIndex = 0;
            // 
            // lblListaKurseve
            // 
            this.lblListaKurseve.AutoSize = true;
            this.lblListaKurseve.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblListaKurseve.Location = new System.Drawing.Point(38, 48);
            this.lblListaKurseve.Name = "lblListaKurseve";
            this.lblListaKurseve.Size = new System.Drawing.Size(136, 22);
            this.lblListaKurseve.TabIndex = 1;
            this.lblListaKurseve.Text = "Lista e kurseve :";
            // 
            // btnRifreskoKurset
            // 
            this.btnRifreskoKurset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRifreskoKurset.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnRifreskoKurset.Location = new System.Drawing.Point(303, 40);
            this.btnRifreskoKurset.Name = "btnRifreskoKurset";
            this.btnRifreskoKurset.Size = new System.Drawing.Size(133, 47);
            this.btnRifreskoKurset.TabIndex = 0;
            this.btnRifreskoKurset.Text = "Rifresko";
            this.btnRifreskoKurset.UseVisualStyleBackColor = true;
            this.btnRifreskoKurset.Click += new System.EventHandler(this.btnRifreskoKurset_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button2.Location = new System.Drawing.Point(442, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edito rekordin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button3.Location = new System.Drawing.Point(581, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Fshij rekordin";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnPrinto
            // 
            this.btnPrinto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinto.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnPrinto.Location = new System.Drawing.Point(14, 462);
            this.btnPrinto.Name = "btnPrinto";
            this.btnPrinto.Size = new System.Drawing.Size(133, 47);
            this.btnPrinto.TabIndex = 0;
            this.btnPrinto.Text = "Printo";
            this.btnPrinto.UseVisualStyleBackColor = true;
            this.btnPrinto.Click += new System.EventHandler(this.btnPrinto_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExcel.Location = new System.Drawing.Point(153, 462);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(133, 47);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnDil
            // 
            this.btnDil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDil.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnDil.Location = new System.Drawing.Point(292, 462);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(133, 47);
            this.btnDil.TabIndex = 0;
            this.btnDil.Text = "Dil";
            this.btnDil.UseVisualStyleBackColor = true;
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // CourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(726, 519);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPrinto);
            this.Controls.Add(this.btnRifreskoKurset);
            this.Controls.Add(this.lblListaKurseve);
            this.Controls.Add(this.dgvListaKurseve);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseList";
            this.Text = "CourseList";
            this.Load += new System.EventHandler(this.CourseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKurseve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaKurseve;
        private System.Windows.Forms.Label lblListaKurseve;
        private System.Windows.Forms.Button btnRifreskoKurset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPrinto;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnDil;
    }
}