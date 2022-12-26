using P9_1214078.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214078
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe newAboutMe = new AboutMe();
            newAboutMe.MdiParent = this;
            newAboutMe.Show();
        }

        private void inputNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNilai FormNilai = new FormNilai();
            FormNilai.MdiParent = this;
            FormNilai.Show();
        }

        private void dataMahasiswaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDataMahasiswa newUlbi = new FormDataMahasiswa();
            newUlbi.MdiParent = this;
            newUlbi.Show();
        }

        private void tugasPraktikum11ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataMasterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterBarang MasterBarang = new FormMasterBarang();
            MasterBarang.MdiParent = this;
            MasterBarang.Show();
        }

        private void dataTransaksiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTransaksiBarang TransaksiBarang = new FormTransaksiBarang();
            TransaksiBarang.MdiParent = this;
            TransaksiBarang.Show();
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
