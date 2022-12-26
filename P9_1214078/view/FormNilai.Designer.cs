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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.npm = new System.Windows.Forms.ComboBox();
            this.Matkul = new System.Windows.Forms.ComboBox();
            this.Kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nilai = new System.Windows.Forms.TextBox();
            this.TabelDataNilai = new System.Windows.Forms.GroupBox();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.FormInputNilai.SuspendLayout();
            this.TabelDataNilai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.CariData);
            this.groupBox1.Location = new System.Drawing.Point(761, 448);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(395, 131);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(83, 39);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(173, 22);
            this.tbCariData.TabIndex = 14;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // CariData
            // 
            this.CariData.AutoSize = true;
            this.CariData.Location = new System.Drawing.Point(8, 42);
            this.CariData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CariData.Name = "CariData";
            this.CariData.Size = new System.Drawing.Size(63, 16);
            this.CariData.TabIndex = 14;
            this.CariData.Text = "Cari Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Location = new System.Drawing.Point(761, 587);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(395, 234);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(24, 183);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(232, 28);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(24, 42);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(232, 28);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(24, 89);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(232, 28);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(24, 139);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(232, 28);
            this.btnUbah.TabIndex = 16;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // FormInputNilai
            // 
            this.FormInputNilai.Controls.Add(this.tbNama);
            this.FormInputNilai.Controls.Add(this.npm);
            this.FormInputNilai.Controls.Add(this.Matkul);
            this.FormInputNilai.Controls.Add(this.Kategori);
            this.FormInputNilai.Controls.Add(this.label1);
            this.FormInputNilai.Controls.Add(this.label2);
            this.FormInputNilai.Controls.Add(this.label3);
            this.FormInputNilai.Controls.Add(this.label4);
            this.FormInputNilai.Controls.Add(this.Nilai);
            this.FormInputNilai.Location = new System.Drawing.Point(16, 444);
            this.FormInputNilai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FormInputNilai.Name = "FormInputNilai";
            this.FormInputNilai.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FormInputNilai.Size = new System.Drawing.Size(737, 322);
            this.FormInputNilai.TabIndex = 21;
            this.FormInputNilai.TabStop = false;
            this.FormInputNilai.Text = "Form Input Nilai";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(520, 144);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(191, 22);
            this.tbNama.TabIndex = 17;
            // 
            // npm
            // 
            this.npm.FormattingEnabled = true;
            this.npm.Location = new System.Drawing.Point(149, 143);
            this.npm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(343, 24);
            this.npm.TabIndex = 16;
            this.npm.SelectedIndexChanged += new System.EventHandler(this.npm_SelectedIndexChanged);
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
            this.Matkul.Location = new System.Drawing.Point(149, 55);
            this.Matkul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Matkul.Name = "Matkul";
            this.Matkul.Size = new System.Drawing.Size(343, 24);
            this.Matkul.TabIndex = 15;
            // 
            // Kategori
            // 
            this.Kategori.FormattingEnabled = true;
            this.Kategori.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.Kategori.Location = new System.Drawing.Point(149, 96);
            this.Kategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(343, 24);
            this.Kategori.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matkul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "NPM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nilai";
            // 
            // Nilai
            // 
            this.Nilai.Location = new System.Drawing.Point(149, 193);
            this.Nilai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nilai.Name = "Nilai";
            this.Nilai.Size = new System.Drawing.Size(343, 22);
            this.Nilai.TabIndex = 8;
            // 
            // TabelDataNilai
            // 
            this.TabelDataNilai.Controls.Add(this.DataNilai);
            this.TabelDataNilai.Location = new System.Drawing.Point(16, 15);
            this.TabelDataNilai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabelDataNilai.Name = "TabelDataNilai";
            this.TabelDataNilai.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabelDataNilai.Size = new System.Drawing.Size(1140, 422);
            this.TabelDataNilai.TabIndex = 19;
            this.TabelDataNilai.TabStop = false;
            this.TabelDataNilai.Text = "TabelDataNilai";
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(16, 41);
            this.DataNilai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.RowHeadersWidth = 51;
            this.DataNilai.Size = new System.Drawing.Size(1116, 391);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick_1);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(74, 89);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 23);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 964);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FormInputNilai);
            this.Controls.Add(this.TabelDataNilai);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Button btnExport;
    }
}