namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputDataPetugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bokingLapanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.inputDataPetugasToolStripMenuItem,
            this.bokingLapanganToolStripMenuItem,
            this.transaksiMemberToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputDataPetugasToolStripMenuItem
            // 
            this.inputDataPetugasToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDataPetugasToolStripMenuItem.Name = "inputDataPetugasToolStripMenuItem";
            this.inputDataPetugasToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.inputDataPetugasToolStripMenuItem.Text = "Input Data Petugas";
            this.inputDataPetugasToolStripMenuItem.Click += new System.EventHandler(this.inputDataPetugasToolStripMenuItem_Click);
            // 
            // bokingLapanganToolStripMenuItem
            // 
            this.bokingLapanganToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bokingLapanganToolStripMenuItem.Name = "bokingLapanganToolStripMenuItem";
            this.bokingLapanganToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.bokingLapanganToolStripMenuItem.Text = "Boking Lapangan";
            this.bokingLapanganToolStripMenuItem.Click += new System.EventHandler(this.bokingLapanganToolStripMenuItem_Click);
            // 
            // transaksiMemberToolStripMenuItem
            // 
            this.transaksiMemberToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaksiMemberToolStripMenuItem.Name = "transaksiMemberToolStripMenuItem";
            this.transaksiMemberToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.transaksiMemberToolStripMenuItem.Text = "Transaksi Member";
            this.transaksiMemberToolStripMenuItem.Click += new System.EventHandler(this.transaksiMemberToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem1.Text = "Log Out";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(89, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 58);
            this.label3.TabIndex = 7;
            this.label3.Text = "CYBER FUTSAL";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.futsal_2;
            this.ClientSize = new System.Drawing.Size(556, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputDataPetugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bokingLapanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}