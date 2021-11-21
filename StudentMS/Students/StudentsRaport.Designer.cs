
namespace StudentMS.Students
{
    partial class StudentsRaport
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
            this.btnFemer = new System.Windows.Forms.RadioButton();
            this.btnMashkull = new System.Windows.Forms.RadioButton();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.dgvGender = new System.Windows.Forms.DataGridView();
            this.btnDil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGender)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro sipas gjinisë:";
            // 
            // btnFemer
            // 
            this.btnFemer.AutoSize = true;
            this.btnFemer.Location = new System.Drawing.Point(263, 30);
            this.btnFemer.Name = "btnFemer";
            this.btnFemer.Size = new System.Drawing.Size(31, 17);
            this.btnFemer.TabIndex = 1;
            this.btnFemer.TabStop = true;
            this.btnFemer.Text = "F";
            this.btnFemer.UseVisualStyleBackColor = true;
            // 
            // btnMashkull
            // 
            this.btnMashkull.AutoSize = true;
            this.btnMashkull.Location = new System.Drawing.Point(313, 31);
            this.btnMashkull.Name = "btnMashkull";
            this.btnMashkull.Size = new System.Drawing.Size(34, 17);
            this.btnMashkull.TabIndex = 1;
            this.btnMashkull.TabStop = true;
            this.btnMashkull.Text = "M";
            this.btnMashkull.UseVisualStyleBackColor = true;
            // 
            // btnFiltro
            // 
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFiltro.Location = new System.Drawing.Point(383, 21);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(104, 36);
            this.btnFiltro.TabIndex = 2;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // dgvGender
            // 
            this.dgvGender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGender.Location = new System.Drawing.Point(29, 75);
            this.dgvGender.Name = "dgvGender";
            this.dgvGender.Size = new System.Drawing.Size(458, 274);
            this.dgvGender.TabIndex = 3;
            // 
            // btnDil
            // 
            this.btnDil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDil.Location = new System.Drawing.Point(383, 355);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(104, 36);
            this.btnDil.TabIndex = 2;
            this.btnDil.Text = "Dil";
            this.btnDil.UseVisualStyleBackColor = true;
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // StudentsRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(523, 410);
            this.Controls.Add(this.dgvGender);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.btnMashkull);
            this.Controls.Add(this.btnFemer);
            this.Controls.Add(this.label1);
            this.Name = "StudentsRaport";
            this.Text = "StudentsRaport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnFemer;
        private System.Windows.Forms.RadioButton btnMashkull;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.DataGridView dgvGender;
        private System.Windows.Forms.Button btnDil;
    }
}