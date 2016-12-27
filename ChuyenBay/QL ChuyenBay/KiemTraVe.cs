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
    public partial class KiemTraVe : Form
    {
        string cnstr;
        SqlConnection cn;
        DataTable db;
        DataSet ds;
        
        public KiemTraVe()
        {
            InitializeComponent();
        }

        private void KiemTraVe_Load(object sender, EventArgs e)
        {
            cnstr = "Server = .\\TRUONGHUY; Database= QLChuyenBayVaVeMayBay; Integrated security = true";
            cn = new SqlConnection(cnstr);
            string sql = " select ChuyenBay.MaCB, MayBay.MaMB, HangTrinh.DiemDi, HangTrinh.DiemDen, ChuyenBay.NgayGioCatCanh, ChuyenBay.NgayGioHaCanh,  MayBay.SoGheDaDat, MayBay.SoGheTG, MayBay.TongSoGhe from ChuyenBay, HangTrinh, MayBay where MayBay.MaMB=ChuyenBay.MaMB and HangTrinh.MaHT=ChuyenBay.MaHT ";
            db = GetDataset(sql).Tables[0];
            dgvkiemtra.DataSource = GetDataset(sql).Tables[0];

            //cbbdiemdi.DataSource = db;
            //cbbdiemdi.DisplayMember = "DiemDi";
            //cbbdiemdi.ValueMember= "DiemDi";
            
            cbbdiemden.DataSource = db;
            cbbdiemden.DisplayMember = "DiemDen";
            cbbdiemden.ValueMember = "DiemDen";
            
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

        private void cbbdiemden_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            string sql = "select ChuyenBay.MaCB, MayBay.MaMB, HangTrinh.DiemDi, HangTrinh.DiemDen, ChuyenBay.NgayGioCatCanh, ChuyenBay.NgayGioHaCanh,  MayBay.SoGheDaDat, MayBay.SoGheTG, MayBay.TongSoGhe from ChuyenBay, HangTrinh, MayBay where MayBay.MaMB=ChuyenBay.MaMB and HangTrinh.MaHT=ChuyenBay.MaHT and DiemDen= '" + cbbdiemden.Text + "'";
            dgvkiemtra.DataSource = GetDataset(sql).Tables[0];
        }

        private void dgvkiemtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

       
    }
}
