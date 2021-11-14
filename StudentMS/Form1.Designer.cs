
namespace StudentMS
{
    partial class Form1
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.btn_kurset = new System.Windows.Forms.Button();
            this.btn_nxenesit = new System.Windows.Forms.Button();
            this.btnMesimdhenesit = new System.Windows.Forms.Button();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnl_menu.Controls.Add(this.btn_kurset);
            this.pnl_menu.Controls.Add(this.btn_nxenesit);
            this.pnl_menu.Controls.Add(this.btnMesimdhenesit);
            this.pnl_menu.Controls.Add(this.pnl_logo);
            this.pnl_menu.Location = new System.Drawing.Point(0, 1);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(220, 581);
            this.pnl_menu.TabIndex = 0;
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(220, 100);
            this.pnl_logo.TabIndex = 1;
            // 
            // btn_kurset
            // 
            this.btn_kurset.BackgroundImage = global::StudentMS.Properties.Resources.book;
            this.btn_kurset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kurset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_kurset.FlatAppearance.BorderSize = 0;
            this.btn_kurset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kurset.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_kurset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kurset.Location = new System.Drawing.Point(0, 220);
            this.btn_kurset.Name = "btn_kurset";
            this.btn_kurset.Size = new System.Drawing.Size(220, 60);
            this.btn_kurset.TabIndex = 1;
            this.btn_kurset.Text = "Kurset";
            this.btn_kurset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kurset.UseVisualStyleBackColor = true;
            // 
            // btn_nxenesit
            // 
            this.btn_nxenesit.BackgroundImage = global::StudentMS.Properties.Resources.write;
            this.btn_nxenesit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_nxenesit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nxenesit.FlatAppearance.BorderSize = 0;
            this.btn_nxenesit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nxenesit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_nxenesit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nxenesit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nxenesit.Location = new System.Drawing.Point(0, 160);
            this.btn_nxenesit.Name = "btn_nxenesit";
            this.btn_nxenesit.Size = new System.Drawing.Size(220, 60);
            this.btn_nxenesit.TabIndex = 1;
            this.btn_nxenesit.Text = "Nxenesit";
            this.btn_nxenesit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nxenesit.UseVisualStyleBackColor = true;
            // 
            // btnMesimdhenesit
            // 
            this.btnMesimdhenesit.BackgroundImage = global::StudentMS.Properties.Resources.KEY0_CC_Vector_Transparent_Library_Svg_Definition_Teacher_Teacher_Icon_Png;
            this.btnMesimdhenesit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMesimdhenesit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesimdhenesit.FlatAppearance.BorderSize = 0;
            this.btnMesimdhenesit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesimdhenesit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesimdhenesit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMesimdhenesit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesimdhenesit.Location = new System.Drawing.Point(0, 100);
            this.btnMesimdhenesit.Name = "btnMesimdhenesit";
            this.btnMesimdhenesit.Size = new System.Drawing.Size(220, 60);
            this.btnMesimdhenesit.TabIndex = 1;
            this.btnMesimdhenesit.Text = "Mesuesit";
            this.btnMesimdhenesit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesimdhenesit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMesimdhenesit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 557);
            this.Controls.Add(this.pnl_menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btnMesimdhenesit;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Button btn_kurset;
        private System.Windows.Forms.Button btn_nxenesit;
    }
}

