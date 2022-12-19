﻿using P9_1214078.controller;
using P9_1214078.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P9_1214078.view
{
    public partial class FormNilai : Form
    {

        Koneksi koneksi = new Koneksi();
        M_Nilai m_nilai = new M_Nilai();
        string id;


        public void Tampil()
        {
            //QueryDB
            DataNilai.DataSource = koneksi.ShowData("select * from t_nilai");

            //Mengubah Nama Kolom Table
            DataNilai.Columns[1].HeaderText = "Matkul";
            DataNilai.Columns[2].HeaderText = "Kategori";
            DataNilai.Columns[3].HeaderText = "npm";
            DataNilai.Columns[4].HeaderText = "Nilai";

        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        public FormNilai()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (Matkul.Text == "" || Kategori.Text == "" || npm.SelectedIndex == -1 || Nilai.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = Matkul.Text;
                m_nilai.Kategori = Kategori.Text;
                m_nilai.Npm = npm.Text;
                m_nilai.Nilai = Nilai.Text;
                

                nilai.Insert(m_nilai);

                Matkul.Text = "";
                Kategori.Text = "";
                npm.SelectedIndex = -1;
                Nilai.Text = "";

                Tampil();
            }
        }
      

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (Matkul.Text == "" || Kategori.Text == "" || npm.SelectedIndex == -1 || Nilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = Matkul.Text;
                m_nilai.Kategori = Kategori.Text;
                m_nilai.Npm = npm.Text;
                m_nilai.Nilai = Nilai.Text;


                nilai.Update(m_nilai,id);

                Matkul.Text = "";
                Kategori.Text = "";
                npm.SelectedIndex = -1;
                Nilai.Text = "";

                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Matkul.Text = "";
            Kategori.Text = "";
            npm.SelectedIndex = -1;
            Nilai.Text = "";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

            DialogResult pesan = MessageBox.Show("Apakah Yakin Ingin Menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id);
                Tampil();
            }
            
        }

        private void DataNilai_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = DataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            Matkul.Text = DataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kategori.Text = DataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            npm.Text = DataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            Nilai.Text = DataNilai.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search Data
            DataNilai.DataSource = koneksi.ShowData("SELECT * FROM t_nilai WHERE id_nilai LIKE '%' '" + tbCariData.Text + "' '%' " +
                "OR matkul LIKE '%' '" + tbCariData.Text + "' '%' " +
                "OR kategori LIKE '%' '" + tbCariData.Text + "' '%' " +
                "OR npm LIKE '%' '" + tbCariData.Text + "' '%' " +
                "OR nilai LIKE '%' '" + tbCariData.Text + "' '%' " );
        }
    }
}
