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
            dataGridView1.DataSource = GetEmployee();
            

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

      
        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
             ("Bạn có chắc muốn thoát không?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }

        private void btnin_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspAddHanhKhach";
                cmd.CommandText = "uspAddVe";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHK", txtmahk.Text));
                cmd.Parameters.Add(new SqlParameter("@firstname", txttenhk.Text));
                cmd.Parameters.Add(new SqlParameter("@lastname", txthohk.Text));
                cmd.Parameters.Add(new SqlParameter("@sodt", txtdienthoai.Text));
                cmd.Parameters.Add(new SqlParameter("@diachi", txtdiachi.Text));
                cmd.Parameters.Add(new SqlParameter("@MaVe", txtmave.Text));
                cmd.Parameters.Add(new SqlParameter("@MaCB", txtchuyenbay.Text));
               
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = GetEmployee();
                MessageBox.Show("Thêm thành công !!", "Thông Báo");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public List<KhachHang> GetEmployee()
        {
            Connect();
            List<KhachHang> list = new List<KhachHang>();
            try
            {
                string sql = "SELECT * FROM HanhKhach";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();

                
                string MaHK, MaVe, HoHK, TenHK, SoDT, DiaChi;
                while (dr.Read())
                {
                    MaHK = dr.GetString(0);
                    MaVe = dr.GetString(1);
                    HoHK = dr.GetString(2);
                    TenHK = dr.GetString(3);
                    SoDT = dr.GetString(4);
                    DiaChi = dr.GetString(5);
                    KhachHang hk = new KhachHang (MaHK, MaVe, HoHK, TenHK, SoDT, DiaChi);
                    list.Add(hk);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            {
                Connect();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "uspDelHanhKhach";
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaHK", txtmahk.Text));
                    cmd.ExecuteNonQuery();
                    dataGridView1.DataSource = GetEmployee();
                    MessageBox.Show("Xóa thành công !!", "Thông Báo");
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Disconnect();
                }

            }


        }

    }
}

