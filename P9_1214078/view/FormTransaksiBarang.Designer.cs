namespace P9_1214078.view
{
    partial class FormTransaksiBarang
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
            this.FormTransaksiBarangg = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIDBarang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHargaBarang = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TabelTransaksiBarang = new System.Windows.Forms.GroupBox();
            this.DataTransaksi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.FormTransaksiBarangg.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TabelTransaksiBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.CariData);
            this.groupBox1.Location = new System.Drawing.Point(669, 443);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 78);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(89, 36);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(4);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(369, 22);
            this.tbCariData.TabIndex = 14;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // CariData
            // 
            this.CariData.AutoSize = true;
            this.CariData.Location = new System.Drawing.Point(18, 39);
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
            this.groupBox3.Location = new System.Drawing.Point(669, 538);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(484, 226);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(121, 183);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(232, 28);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(121, 42);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(232, 28);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(121, 89);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(232, 28);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(121, 139);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(232, 28);
            this.btnUbah.TabIndex = 16;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // FormTransaksiBarangg
            // 
            this.FormTransaksiBarangg.Controls.Add(this.groupBox2);
            this.FormTransaksiBarangg.Controls.Add(this.tbTotal);
            this.FormTransaksiBarangg.Controls.Add(this.label6);
            this.FormTransaksiBarangg.Controls.Add(this.label3);
            this.FormTransaksiBarangg.Controls.Add(this.tbQuantity);
            this.FormTransaksiBarangg.Controls.Add(this.label1);
            this.FormTransaksiBarangg.Controls.Add(this.label2);
            this.FormTransaksiBarangg.Location = new System.Drawing.Point(13, 442);
            this.FormTransaksiBarangg.Margin = new System.Windows.Forms.Padding(4);
            this.FormTransaksiBarangg.Name = "FormTransaksiBarangg";
            this.FormTransaksiBarangg.Padding = new System.Windows.Forms.Padding(4);
            this.FormTransaksiBarangg.Size = new System.Drawing.Size(635, 322);
            this.FormTransaksiBarangg.TabIndex = 29;
            this.FormTransaksiBarangg.TabStop = false;
            this.FormTransaksiBarangg.Text = "Form Transaksi Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbIDBarang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbNamaBarang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbHargaBarang);
            this.groupBox2.Location = new System.Drawing.Point(126, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nama Barang";
            // 
            // cbIDBarang
            // 
            this.cbIDBarang.FormattingEnabled = true;
            this.cbIDBarang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbIDBarang.Location = new System.Drawing.Point(18, 25);
            this.cbIDBarang.Name = "cbIDBarang";
            this.cbIDBarang.Size = new System.Drawing.Size(219, 24);
            this.cbIDBarang.TabIndex = 19;
            this.cbIDBarang.SelectedIndexChanged += new System.EventHandler(this.cbIDBarang_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rp";
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(18, 93);
            this.tbNamaBarang.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(219, 22);
            this.tbNamaBarang.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Harga Barang";
            // 
            // tbHargaBarang
            // 
            this.tbHargaBarang.Location = new System.Drawing.Point(275, 93);
            this.tbHargaBarang.Margin = new System.Windows.Forms.Padding(4);
            this.tbHargaBarang.Name = "tbHargaBarang";
            this.tbHargaBarang.Size = new System.Drawing.Size(185, 22);
            this.tbHargaBarang.TabIndex = 20;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(126, 219);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(405, 22);
            this.tbTotal.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(126, 182);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(405, 22);
            this.tbQuantity.TabIndex = 16;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total";
            // 
            // TabelTransaksiBarang
            // 
            this.TabelTransaksiBarang.Controls.Add(this.DataTransaksi);
            this.TabelTransaksiBarang.Location = new System.Drawing.Point(13, 13);
            this.TabelTransaksiBarang.Margin = new System.Windows.Forms.Padding(4);
            this.TabelTransaksiBarang.Name = "TabelTransaksiBarang";
            this.TabelTransaksiBarang.Padding = new System.Windows.Forms.Padding(4);
            this.TabelTransaksiBarang.Size = new System.Drawing.Size(1140, 422);
            this.TabelTransaksiBarang.TabIndex = 27;
            this.TabelTransaksiBarang.TabStop = false;
            this.TabelTransaksiBarang.Text = "TabelTransaksiBarang";
            // 
            // DataTransaksi
            // 
            this.DataTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksi.Location = new System.Drawing.Point(16, 41);
            this.DataTransaksi.Margin = new System.Windows.Forms.Padding(4);
            this.DataTransaksi.Name = "DataTransaksi";
            this.DataTransaksi.RowHeadersWidth = 51;
            this.DataTransaksi.Size = new System.Drawing.Size(1116, 391);
            this.DataTransaksi.TabIndex = 0;
            this.DataTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksi_CellClick);
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1185, 777);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FormTransaksiBarangg);
            this.Controls.Add(this.TabelTransaksiBarang);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.FormTransaksiBarangg.ResumeLayout(false);
            this.FormTransaksiBarangg.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TabelTransaksiBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).EndInit();
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
        private System.Windows.Forms.GroupBox FormTransaksiBarangg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHargaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox TabelTransaksiBarang;
        private System.Windows.Forms.DataGridView DataTransaksi;
        private System.Windows.Forms.ComboBox cbIDBarang;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}