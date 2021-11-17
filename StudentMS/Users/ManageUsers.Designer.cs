
namespace StudentMS.Users
{
    partial class ManageUsers
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRifreskoManage = new System.Windows.Forms.Button();
            this.btnFshij = new System.Windows.Forms.Button();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(107, 202);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Fjalkalimi ";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Perdoruesi";
            // 
            // btnRifreskoManage
            // 
            this.btnRifreskoManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRifreskoManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnRifreskoManage.Location = new System.Drawing.Point(414, 48);
            this.btnRifreskoManage.Name = "btnRifreskoManage";
            this.btnRifreskoManage.Size = new System.Drawing.Size(133, 47);
            this.btnRifreskoManage.TabIndex = 3;
            this.btnRifreskoManage.Text = "Rifresko";
            this.btnRifreskoManage.UseVisualStyleBackColor = true;
            this.btnRifreskoManage.Click += new System.EventHandler(this.btnRifreskoManage_Click);
            // 
            // btnFshij
            // 
            this.btnFshij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFshij.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnFshij.Location = new System.Drawing.Point(566, 48);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(133, 47);
            this.btnFshij.TabIndex = 4;
            this.btnFshij.Text = "Fshij";
            this.btnFshij.UseVisualStyleBackColor = true;
            this.btnFshij.Click += new System.EventHandler(this.btnFshij_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnRuaj.Location = new System.Drawing.Point(75, 376);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(120, 28);
            this.btnRuaj.TabIndex = 2;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(265, 123);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(434, 344);
            this.dgvUsers.TabIndex = 9;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(47, 296);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 23);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Roli:";
            this.label3.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(726, 519);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.btnRifreskoManage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.Text = "AddUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRifreskoManage;
        private System.Windows.Forms.Button btnFshij;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}