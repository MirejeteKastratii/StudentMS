
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPrinto = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDil = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKurseve)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaKurseve
            // 
            resources.ApplyResources(this.dgvListaKurseve, "dgvListaKurseve");
            this.dgvListaKurseve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKurseve.Name = "dgvListaKurseve";
            this.dgvListaKurseve.RowTemplate.Height = 24;
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
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CourseList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPrinto);
            this.Controls.Add(this.btnRifreskoKurset);
            this.Controls.Add(this.lblListaKurseve);
            this.Controls.Add(this.dgvListaKurseve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseList";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}