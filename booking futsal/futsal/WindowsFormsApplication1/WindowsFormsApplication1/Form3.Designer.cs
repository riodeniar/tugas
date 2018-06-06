namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.id_petugas = new System.Windows.Forms.Label();
            this.namapetugas = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.noboking = new System.Windows.Forms.Label();
            this.bokingjam = new System.Windows.Forms.Label();
            this.namatim = new System.Windows.Forms.Label();
            this.telepon = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.dp = new System.Windows.Forms.Label();
            this.sisabayar = new System.Windows.Forms.Label();
            this.idpetugas1 = new System.Windows.Forms.TextBox();
            this.namapetugas2 = new System.Windows.Forms.TextBox();
            this.noboking4 = new System.Windows.Forms.TextBox();
            this.namatim6 = new System.Windows.Forms.TextBox();
            this.telepon7 = new System.Windows.Forms.TextBox();
            this.dp9 = new System.Windows.Forms.TextBox();
            this.sisabayar10 = new System.Windows.Forms.TextBox();
            this.bokingjam5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.harga8 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tanggal3 = new System.Windows.Forms.DateTimePicker();
            this.tbhasil = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_petugas
            // 
            this.id_petugas.AutoSize = true;
            this.id_petugas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id_petugas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.id_petugas.Location = new System.Drawing.Point(42, 50);
            this.id_petugas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_petugas.Name = "id_petugas";
            this.id_petugas.Size = new System.Drawing.Size(81, 17);
            this.id_petugas.TabIndex = 0;
            this.id_petugas.Text = "ID Petugas";
            // 
            // namapetugas
            // 
            this.namapetugas.AutoSize = true;
            this.namapetugas.BackColor = System.Drawing.Color.MidnightBlue;
            this.namapetugas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.namapetugas.Location = new System.Drawing.Point(514, 47);
            this.namapetugas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namapetugas.Name = "namapetugas";
            this.namapetugas.Size = new System.Drawing.Size(101, 17);
            this.namapetugas.TabIndex = 1;
            this.namapetugas.Text = "Nama Petugas";
            this.namapetugas.Click += new System.EventHandler(this.label2_Click);
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.BackColor = System.Drawing.SystemColors.ControlText;
            this.tanggal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tanggal.Location = new System.Drawing.Point(44, 111);
            this.tanggal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(59, 17);
            this.tanggal.TabIndex = 2;
            this.tanggal.Text = "Tanggal";
            // 
            // noboking
            // 
            this.noboking.AutoSize = true;
            this.noboking.BackColor = System.Drawing.SystemColors.ControlText;
            this.noboking.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.noboking.Location = new System.Drawing.Point(42, 177);
            this.noboking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noboking.Name = "noboking";
            this.noboking.Size = new System.Drawing.Size(105, 17);
            this.noboking.TabIndex = 3;
            this.noboking.Text = "Nomor Boking";
            // 
            // bokingjam
            // 
            this.bokingjam.AutoSize = true;
            this.bokingjam.BackColor = System.Drawing.SystemColors.ControlText;
            this.bokingjam.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bokingjam.Location = new System.Drawing.Point(44, 242);
            this.bokingjam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bokingjam.Name = "bokingjam";
            this.bokingjam.Size = new System.Drawing.Size(87, 17);
            this.bokingjam.TabIndex = 4;
            this.bokingjam.Text = "Boking Jam";
            // 
            // namatim
            // 
            this.namatim.AutoSize = true;
            this.namatim.BackColor = System.Drawing.SystemColors.MenuText;
            this.namatim.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.namatim.Location = new System.Drawing.Point(44, 297);
            this.namatim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namatim.Name = "namatim";
            this.namatim.Size = new System.Drawing.Size(75, 17);
            this.namatim.TabIndex = 5;
            this.namatim.Text = "Nama Tim";
            // 
            // telepon
            // 
            this.telepon.AutoSize = true;
            this.telepon.BackColor = System.Drawing.SystemColors.MenuText;
            this.telepon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.telepon.Location = new System.Drawing.Point(42, 353);
            this.telepon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telepon.Name = "telepon";
            this.telepon.Size = new System.Drawing.Size(61, 17);
            this.telepon.TabIndex = 6;
            this.telepon.Text = "Telepon";
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.harga.Location = new System.Drawing.Point(24, 39);
            this.harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(48, 17);
            this.harga.TabIndex = 7;
            this.harga.Text = "Harga";
            // 
            // dp
            // 
            this.dp.AutoSize = true;
            this.dp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dp.Location = new System.Drawing.Point(24, 84);
            this.dp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(28, 17);
            this.dp.TabIndex = 8;
            this.dp.Text = "DP";
            // 
            // sisabayar
            // 
            this.sisabayar.AutoSize = true;
            this.sisabayar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sisabayar.Location = new System.Drawing.Point(24, 128);
            this.sisabayar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sisabayar.Name = "sisabayar";
            this.sisabayar.Size = new System.Drawing.Size(76, 17);
            this.sisabayar.TabIndex = 9;
            this.sisabayar.Text = "Sisa Bayar";
            // 
            // idpetugas1
            // 
            this.idpetugas1.BackColor = System.Drawing.Color.White;
            this.idpetugas1.Location = new System.Drawing.Point(214, 50);
            this.idpetugas1.Margin = new System.Windows.Forms.Padding(4);
            this.idpetugas1.Name = "idpetugas1";
            this.idpetugas1.Size = new System.Drawing.Size(148, 25);
            this.idpetugas1.TabIndex = 10;
            this.idpetugas1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // namapetugas2
            // 
            this.namapetugas2.BackColor = System.Drawing.Color.White;
            this.namapetugas2.Location = new System.Drawing.Point(650, 44);
            this.namapetugas2.Margin = new System.Windows.Forms.Padding(4);
            this.namapetugas2.Multiline = true;
            this.namapetugas2.Name = "namapetugas2";
            this.namapetugas2.Size = new System.Drawing.Size(241, 25);
            this.namapetugas2.TabIndex = 11;
            // 
            // noboking4
            // 
            this.noboking4.BackColor = System.Drawing.Color.White;
            this.noboking4.Location = new System.Drawing.Point(213, 177);
            this.noboking4.Margin = new System.Windows.Forms.Padding(4);
            this.noboking4.Name = "noboking4";
            this.noboking4.Size = new System.Drawing.Size(241, 25);
            this.noboking4.TabIndex = 13;
            // 
            // namatim6
            // 
            this.namatim6.BackColor = System.Drawing.Color.White;
            this.namatim6.Location = new System.Drawing.Point(213, 297);
            this.namatim6.Margin = new System.Windows.Forms.Padding(4);
            this.namatim6.Name = "namatim6";
            this.namatim6.Size = new System.Drawing.Size(241, 25);
            this.namatim6.TabIndex = 14;
            this.namatim6.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // telepon7
            // 
            this.telepon7.BackColor = System.Drawing.Color.White;
            this.telepon7.Location = new System.Drawing.Point(213, 353);
            this.telepon7.Margin = new System.Windows.Forms.Padding(4);
            this.telepon7.Name = "telepon7";
            this.telepon7.Size = new System.Drawing.Size(241, 25);
            this.telepon7.TabIndex = 15;
            // 
            // dp9
            // 
            this.dp9.BackColor = System.Drawing.Color.White;
            this.dp9.Location = new System.Drawing.Point(133, 84);
            this.dp9.Margin = new System.Windows.Forms.Padding(4);
            this.dp9.Name = "dp9";
            this.dp9.Size = new System.Drawing.Size(241, 25);
            this.dp9.TabIndex = 17;
            // 
            // sisabayar10
            // 
            this.sisabayar10.Location = new System.Drawing.Point(133, 125);
            this.sisabayar10.Margin = new System.Windows.Forms.Padding(4);
            this.sisabayar10.Name = "sisabayar10";
            this.sisabayar10.ReadOnly = true;
            this.sisabayar10.Size = new System.Drawing.Size(241, 25);
            this.sisabayar10.TabIndex = 18;
            // 
            // bokingjam5
            // 
            this.bokingjam5.BackColor = System.Drawing.Color.White;
            this.bokingjam5.FormattingEnabled = true;
            this.bokingjam5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.bokingjam5.Location = new System.Drawing.Point(213, 239);
            this.bokingjam5.Margin = new System.Windows.Forms.Padding(4);
            this.bokingjam5.Name = "bokingjam5";
            this.bokingjam5.Size = new System.Drawing.Size(55, 25);
            this.bokingjam5.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(288, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 19);
            this.label13.TabIndex = 32;
            this.label13.Text = "Jam";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fallback;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.dp9);
            this.groupBox1.Controls.Add(this.harga8);
            this.groupBox1.Controls.Add(this.sisabayar10);
            this.groupBox1.Controls.Add(this.harga);
            this.groupBox1.Controls.Add(this.sisabayar);
            this.groupBox1.Controls.Add(this.dp);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(42, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 222);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HITUNG";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::WindowsFormsApplication1.Properties.Resources.Accept_icon__1_;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(133, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 30);
            this.button6.TabIndex = 24;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // harga8
            // 
            this.harga8.BackColor = System.Drawing.Color.White;
            this.harga8.Location = new System.Drawing.Point(133, 39);
            this.harga8.Margin = new System.Windows.Forms.Padding(4);
            this.harga8.Name = "harga8";
            this.harga8.ReadOnly = true;
            this.harga8.Size = new System.Drawing.Size(241, 25);
            this.harga8.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.add_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(262, 176);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "HITUNG";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tanggal3
            // 
            this.tanggal3.Location = new System.Drawing.Point(213, 111);
            this.tanggal3.Name = "tanggal3";
            this.tanggal3.Size = new System.Drawing.Size(238, 25);
            this.tanggal3.TabIndex = 36;
            // 
            // tbhasil
            // 
            this.tbhasil.Location = new System.Drawing.Point(514, 111);
            this.tbhasil.Multiline = true;
            this.tbhasil.Name = "tbhasil";
            this.tbhasil.ReadOnly = true;
            this.tbhasil.Size = new System.Drawing.Size(383, 183);
            this.tbhasil.TabIndex = 37;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::WindowsFormsApplication1.Properties.Resources.arrow_back_1_icon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(794, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 32);
            this.button5.TabIndex = 34;
            this.button5.Text = "BACK";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.Ok_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(514, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "TAMPIL";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Image = global::WindowsFormsApplication1.Properties.Resources.Misc_Delete_Database_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(650, 319);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 32);
            this.button4.TabIndex = 25;
            this.button4.Text = "DELETE";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fallback;
            this.ClientSize = new System.Drawing.Size(938, 685);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbhasil);
            this.Controls.Add(this.tanggal3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bokingjam5);
            this.Controls.Add(this.telepon7);
            this.Controls.Add(this.namatim6);
            this.Controls.Add(this.noboking4);
            this.Controls.Add(this.namapetugas2);
            this.Controls.Add(this.idpetugas1);
            this.Controls.Add(this.telepon);
            this.Controls.Add(this.namatim);
            this.Controls.Add(this.bokingjam);
            this.Controls.Add(this.noboking);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.namapetugas);
            this.Controls.Add(this.id_petugas);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "BOKING LAPANGAN";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_petugas;
        private System.Windows.Forms.Label namapetugas;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label noboking;
        private System.Windows.Forms.Label bokingjam;
        private System.Windows.Forms.Label namatim;
        private System.Windows.Forms.Label telepon;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.Label dp;
        private System.Windows.Forms.Label sisabayar;
        private System.Windows.Forms.TextBox idpetugas1;
        private System.Windows.Forms.TextBox namapetugas2;
        private System.Windows.Forms.TextBox noboking4;
        private System.Windows.Forms.TextBox namatim6;
        private System.Windows.Forms.TextBox telepon7;
        private System.Windows.Forms.TextBox dp9;
        private System.Windows.Forms.TextBox sisabayar10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox bokingjam5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker tanggal3;
        private System.Windows.Forms.TextBox harga8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbhasil;
    }
}