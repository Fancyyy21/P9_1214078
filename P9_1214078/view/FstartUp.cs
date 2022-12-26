using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214078.view
{
    public partial class FstartUp : Form
    {
        public FstartUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            progressBar1.Value += 5;
            if (progressBar1.Value == 100)
            {
                timer1.Dispose();
                Hide();
                frm.Show();
            }
        }
    }
}
