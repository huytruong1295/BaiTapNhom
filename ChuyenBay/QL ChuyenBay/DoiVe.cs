using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_ChuyenBay
{
    public partial class DoiVe : Form
    {
   
        string cnstr;
        SqlConnection cn;
        DataSet ds;
        DataTable db;

        public DoiVe()
        {
            InitializeComponent();
        }

        private void DoiVe_Load(object sender, EventArgs e)
        {
            
            cnstr = "Server = .\\TRUONGHUY; Database= QLChuyenBayVaVeMayBay; Integrated security = true";
            cn = new SqlConnection(cnstr);
            string sql = "select Ve.*, ChuyenBay.NgayGioCatCanh from Ve, ChuyenBay where ChuyenBay.MaCB=Ve.MaCB";
            db = GetDataset(sql).Tables[0];
            dgvhanhkhach.DataSource = GetDataset(sql).Tables[0];
            
        }
        public DataSet GetDataset(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
        private void btnkiemtra_Click(object sender, EventArgs e)
        {

            if (rdbtnmave.Checked == true)
            {
                string sql = "select Ve.*, ChuyenBay.NgayGioCatCanh from Ve, ChuyenBay where ChuyenBay.MaCB=Ve.MaCB and MaVe = '" + txtmave.Text + "'";
                dgvhanhkhach.DataSource = GetDataset(sql).Tables[0];
            }
            if (rdbtnten.Checked == true)
            {
                string sql = "select * from HanhKhach where SoCMND = '" + txtmave.Text + "'";
                dgvhanhkhach.DataSource = GetDataset(sql).Tables[0];
            }
            if (rdbtnhanhkhach.Checked == true)
            {
                string sql = "select Ve.*, ChuyenBay.NgayGioCatCanh from Ve, ChuyenBay where ChuyenBay.MaCB=Ve.MaCB and MaHK = '" + txtmave.Text + "'";
                dgvhanhkhach.DataSource = GetDataset(sql).Tables[0];
 
            }
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
            ("Bạn có chắc muốn thoát không?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            Thongtinvedoi f = new Thongtinvedoi();
            f.Show();
        }

        private void dgvhanhkhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rdbtnhanhkhach_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
