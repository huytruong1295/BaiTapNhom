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
      
        public DoiVe()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                    cn.Open();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void Disconnect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DoiVe_Load(object sender, EventArgs e)
        {
            
            cnstr = "Server = .\\TRUONGHUY; Database= QLChuyenBayVaVeMayBay; Integrated security = true";
            cn = new SqlConnection(cnstr);
            dgvhanhkhach.DataSource = GetEmployee();
            
        }
        public List<Ve> GetEmployee()
        {
            Connect();
            List<Ve> list = new List<Ve>();
            try
            {
                string sql = "SELECT * FROM Ve";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                
                string MaVe, MaHK, MaCB, LoaiVe, Ngaygiobay, Ngaygioban, NoiBan, GiaVe;
                while (dr.Read())
                {
                    MaVe = dr.GetString(0);
                    MaHK = dr.GetString(1);
                    MaCB = dr.GetString(2);
                    LoaiVe = dr.GetString(3);
                    Ngaygiobay = dr.GetString(4);
                    Ngaygioban = dr.GetString(5);
                    NoiBan = dr.GetString(6);
                    GiaVe = dr.GetString(7);
                    Ve v = new Ve (MaVe, MaHK, MaCB, LoaiVe, Ngaygiobay, Ngaygioban, NoiBan, GiaVe);
                    list.Add(v);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return list;
        }

        private void btnkiemtra_Click(object sender, EventArgs e)
        {
       

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
            Form1 f = new Form1();
            f.ShowDialog();
           
        }

        private void txtmave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
