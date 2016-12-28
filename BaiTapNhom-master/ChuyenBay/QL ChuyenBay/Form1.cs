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
            dataGridView1.DataSource = Ticket();
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
            fmrptHanhKhach = new rptHanhKhach;
            rptHanhKhach.Show();
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
                cmd.Parameters.Add(new SqlParameter("@TenHK", txttenhk.Text));
                cmd.Parameters.Add(new SqlParameter("@HoHK", txthohk.Text));
                cmd.Parameters.Add(new SqlParameter("@SoCMND", txtsocmnd));
                cmd.Parameters.Add(new SqlParameter("@SoDT", txtdienthoai.Text));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtdiachi.Text));
                cmd.Parameters.Add(new SqlParameter("@Email", txtemail));
                cmd.Parameters.Add(new SqlParameter("@MaVe", txtmave.Text));
                cmd.Parameters.Add(new SqlParameter("@MaCB", txtchuyenbay.Text));
                cmd.Parameters.Add(new SqlParameter("@GiaVe", txtgiave.Text));
                cmd.Parameters.Add(new SqlParameter("@GioBay", txtgiobay.Text));
                cmd.Parameters.Add(new SqlParameter("@GioBan", txtgioban.Text));
                cmd.Parameters.Add(new SqlParameter("@NgayBan", dtpngayban.Text));
                cmd.Parameters.Add(new SqlParameter("@NgayBay", dtpngaybay.Text));

                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = GetEmployee();
                dataGridView1.DataSource = Ticket();
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
                
                string MaHK, MaVe, HoHK, TenHK, SoCMND, SoDT, DiaChi, Email;
                while (dr.Read())
                {
                    MaHK = dr.GetString(0);
                    MaVe = dr.GetString(1);
                    HoHK = dr.GetString(2);
                    TenHK = dr.GetString(3);
                    SoCMND = dr.GetString(4);
                    SoDT = dr.GetString(5);
                    DiaChi = dr.GetString(6);
                    Email = dr.GetString(7);
                    KhachHang hk = new KhachHang (MaHK, MaVe, HoHK, TenHK,SoCMND, SoDT, DiaChi, Email);
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
        public List<Ve> Ticket()
        {
            Connect();
            List<Ve> list = new List<Ve>();
            try
            {
                string sql1 = "SELECT * FROM Ve";
                SqlCommand cmd = new SqlCommand(sql1, cn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();

                string MaVe, MaHK, MaCB, HangVe, LoaiVe, GioBay, NgayBay, GioBan, NgayBan, NoiBan, Gia;
                while (dr.Read())
                {
                    MaVe = dr.GetString(0);
                    MaHK = dr.GetString(1);
                    MaCB = dr.GetString(2);
                    HangVe = dr.GetString(3);
                    LoaiVe = dr.GetString(4);
                    GioBay = dr.GetString(5);
                    NgayBay = dr.GetString(6);
                    GioBan = dr.GetString(7);
                    NgayBan = dr.GetString(8);
                    NoiBan = dr.GetString(9);
                    Gia = dr.GetString(10);

                    Ve v = new Ve (MaVe, MaHK, MaCB, HangVe, LoaiVe, GioBay, NgayBay, GioBan, NgayBan, NoiBan, Gia);
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspUpdHanhKhach";
                cmd.CommandText = "uspUpdVe";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHK", txtmahk.Text));
                cmd.Parameters.Add(new SqlParameter("@TenHK", txttenhk.Text));
                cmd.Parameters.Add(new SqlParameter("@HoHK", txthohk.Text));
                cmd.Parameters.Add(new SqlParameter("@SoCMND", txtsocmnd));
                cmd.Parameters.Add(new SqlParameter("@Sodt", txtdienthoai.Text));
                cmd.Parameters.Add(new SqlParameter("@Diachi", txtdiachi.Text));
                cmd.Parameters.Add(new SqlParameter("@Email", txtemail));
                cmd.Parameters.Add(new SqlParameter("@MaVe", txtmave.Text));
                cmd.Parameters.Add(new SqlParameter("@MaCB", txtchuyenbay.Text));
                cmd.Parameters.Add(new SqlParameter("@Giave", txtgiave.Text));
                cmd.Parameters.Add(new SqlParameter("@GioBay", txtgiobay.Text));
                cmd.Parameters.Add(new SqlParameter("@GioBan", txtgioban.Text));
                cmd.Parameters.Add(new SqlParameter("@NgayBan", dtpngayban.Text));
                cmd.Parameters.Add(new SqlParameter("@NgayBay", dtpngaybay.Text));
               
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = GetEmployee();
                dataGridView1.DataSource = Ticket();
                MessageBox.Show("Sửa thành công !!", "Thông Báo");
                
                
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}

