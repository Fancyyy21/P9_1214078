namespace P9_1214078.view
{
    partial class FormNilai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.CariData = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.FormInputNilai = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabelDataNilai = new System.Windows.Forms.GroupBox();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.Nilai = new System.Windows.Forms.TextBox();
            this.Kategori = new System.Windows.Forms.ComboBox();
            this.Matkul = new System.Windows.Forms.ComboBox();
            this.npm = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.FormInputNilai.SuspendLayout();
            this.TabelDataNilai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.CariData);
            this.groupBox1.Location = new System.Drawing.Point(443, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 63);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(62, 32);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(131, 20);
            this.tbCariData.TabIndex = 14;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // CariData
            // 
            this.CariData.AutoSize = true;
            this.CariData.Location = new System.Drawing.Point(6, 34);
            this.CariData.Name = "CariData";
            this.CariData.Size = new System.Drawing.Size(51, 13);
            this.CariData.TabIndex = 14;
            this.CariData.Text = "Cari Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Location = new System.Drawing.Point(443, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 190);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(18, 149);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(174, 23);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(18, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(174, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(18, 72);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(174, 23);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(18, 113);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(174, 23);
            this.btnUbah.TabIndex = 16;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // FormInputNilai
            // 
            this.FormInputNilai.Controls.Add(this.npm);
            this.FormInputNilai.Controls.Add(this.Matkul);
            this.FormInputNilai.Controls.Add(this.Kategori);
            this.FormInputNilai.Controls.Add(this.label1);
            this.FormInputNilai.Controls.Add(this.label2);
            this.FormInputNilai.Controls.Add(this.label3);
            this.FormInputNilai.Controls.Add(this.label4);
            this.FormInputNilai.Controls.Add(this.Nilai);
            this.FormInputNilai.Location = new System.Drawing.Point(12, 361);
            this.FormInputNilai.Name = "FormInputNilai";
            this.FormInputNilai.Size = new System.Drawing.Size(413, 262);
            this.FormInputNilai.TabIndex = 21;
            this.FormInputNilai.TabStop = false;
            this.FormInputNilai.Text = "Form Input Nilai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matkul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NPM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nilai";
            // 
            // TabelDataNilai
            // 
            this.TabelDataNilai.Controls.Add(this.DataNilai);
            this.TabelDataNilai.Location = new System.Drawing.Point(12, 12);
            this.TabelDataNilai.Name = "TabelDataNilai";
            this.TabelDataNilai.Size = new System.Drawing.Size(726, 343);
            this.TabelDataNilai.TabIndex = 19;
            this.TabelDataNilai.TabStop = false;
            this.TabelDataNilai.Text = "TabelDataNilai";
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(12, 33);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.RowHeadersWidth = 51;
            this.DataNilai.Size = new System.Drawing.Size(714, 318);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick_1);
            // 
            // Nilai
            // 
            this.Nilai.Location = new System.Drawing.Point(112, 157);
            this.Nilai.Name = "Nilai";
            this.Nilai.Size = new System.Drawing.Size(295, 20);
            this.Nilai.TabIndex = 8;
            // 
            // Kategori
            // 
            this.Kategori.FormattingEnabled = true;
            this.Kategori.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.Kategori.Location = new System.Drawing.Point(112, 78);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(295, 21);
            this.Kategori.TabIndex = 14;
            // 
            // Matkul
            // 
            this.Matkul.FormattingEnabled = true;
            this.Matkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Literasi Data",
            "PKN",
            "Sistem ERP",
            "General English I",
            "General English II"});
            this.Matkul.Location = new System.Drawing.Point(112, 45);
            this.Matkul.Name = "Matkul";
            this.Matkul.Size = new System.Drawing.Size(295, 21);
            this.Matkul.TabIndex = 15;
            // 
            // npm
            // 
            this.npm.FormattingEnabled = true;
            this.npm.Items.AddRange(new object[] {
            "1214001",
            "1214002",
            "1214003",
            "1212",
            "1313"});
            this.npm.Location = new System.Drawing.Point(112, 116);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(295, 21);
            this.npm.TabIndex = 16;
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 656);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FormInputNilai);
            this.Controls.Add(this.TabelDataNilai);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.FormInputNilai.ResumeLayout(false);
            this.FormInputNilai.PerformLayout();
            this.TabelDataNilai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label CariData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.GroupBox FormInputNilai;
        private System.Windows.Forms.ComboBox Matkul;
        private System.Windows.Forms.ComboBox Kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nilai;
        private System.Windows.Forms.GroupBox TabelDataNilai;
        private System.Windows.Forms.DataGridView DataNilai;
        private System.Windows.Forms.ComboBox npm;
    }
}