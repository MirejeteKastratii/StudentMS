
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
            this.dgvListaKurseve.Size = new System.Drawing.Size(700, 404);
            this.dgvListaKurseve.TabIndex = 0;
            // 
            // lblListaKurseve
            // 
            this.lblListaKurseve.AutoSize = true;
            this.lblListaKurseve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblListaKurseve.Location = new System.Drawing.Point(38, 48);
            this.lblListaKurseve.Name = "lblListaKurseve";
            this.lblListaKurseve.Size = new System.Drawing.Size(170, 26);
            this.lblListaKurseve.TabIndex = 1;
            this.lblListaKurseve.Text = "Lista e kurseve :";
            // 
            // btnRifreskoKurset
            // 
            this.btnRifreskoKurset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRifreskoKurset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
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
            this.button3.Location = new System.Drawing.Point(581, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Fshij rekordin";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(726, 519);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
    }
}