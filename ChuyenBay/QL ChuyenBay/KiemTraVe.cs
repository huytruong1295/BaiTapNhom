using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_ChuyenBay
{
    public partial class KiemTraVe : Form
    {
        public KiemTraVe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnbanve_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.ShowDialog();
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
            ("Bạn có chắc muốn thoát không?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }

        private void KiemTraVe_Load(object sender, EventArgs e)
        {

        }
    }
}
