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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lbname_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbname.Text = "          Chương Trình Quản Lý Vé Máy Bay.        ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbname.Text = lbname.Text.Substring(1) + lbname.Text.Substring(0, 1);
        }

        private void btnthoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
            ("Bạn có chắc muốn thoát không?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }

        private void btnbanve_Click(object sender, EventArgs e)
        {
            KiemTraVe f = new KiemTraVe();
            f.ShowDialog();
        }

        private void btndoive_Click(object sender, EventArgs e)
        {
            DoiVe h = new DoiVe();
            h.ShowDialog();
        }
    }
}
