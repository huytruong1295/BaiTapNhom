using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace QL_ChuyenBay
{
    public partial class Form1 : Form
    {
        string cnstr;
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cnstr = "Server = .\\TRUONGHUY; Database= QLChuyenBayVaVeMayBay; Integrated security = true"; 
            cn = new SqlConnection(cnstr);
            dgvkhachhang.DataSource = GetKhachHang();

        }

        private void Connect()
        {
            try
            {
                if(cn != null && cn.State == ConnectionState.Closed)
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
                if(cn != null && cn.State == ConnectionState.Open)
                    cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public List<KhachHang> GetKhachHang()
        {
            Connect();
            List<KhachHang> list = new List<KhachHang>();
            try
            {
                
                string sql = "SELECT * FROM HanhKhach";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                
                string id, lastName, firstName, address, phone, MaVe;
                while (dr.Read())
                {
                    id = dr.GetString(0);
                    lastName = dr.GetString(1);
                    firstName = dr.GetString(2);
                    address = dr.GetString(3);
                    phone = dr.GetString(4);
                    MaVe = dr.GetString(5);
                    KhachHang kh = new KhachHang(id, lastName, firstName, address, phone, MaVe);
                    list.Add(kh);
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
             ("Bạn có chắc muốn thoát không?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }


    }
}
