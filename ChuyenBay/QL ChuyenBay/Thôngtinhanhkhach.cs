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
        DataSet ds;
        DataTable db;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cnstr = "Server = .\\TRUONGHUY; Database= QLChuyenBayVaVeMayBay; Integrated security = true";

            cn = new SqlConnection(cnstr);

            string sql = "select * from HanhKhach ";
            db = GetDataset(sql).Tables[0];
            dataGridView1.DataSource = GetDataset(sql).Tables[0];

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


        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
             ("Bạn có chắc muốn thoát không?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }
        public DataSet GetDataset(string sql)
        {
            try
            {
                //string sql = "Select * from KhachHang";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtmahk.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
         
            txthohk.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txttenhk.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtdienthoai.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
          
          
            

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                string sql = "select * from HanhKhach ";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspAddHanhKhach";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHK", txtmahk.Text));
                cmd.Parameters.Add(new SqlParameter("@HoHK", txthohk.Text));
                cmd.Parameters.Add(new SqlParameter("@TenHK", txttenhk.Text));
                cmd.Parameters.Add(new SqlParameter("@SoDT", txtdienthoai.Text));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtdiachi.Text));

                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = GetDataset(sql).Tables[0];
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

        private void btndel_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                string sql = "select * from HanhKhach ";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspDelHanhKhach";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHK", txtmahk.Text));
      

                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = GetDataset(sql).Tables[0];
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

        private void btnin_Click(object sender, EventArgs e)
        {
            VeBan f = new VeBan();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();   
        }
    }
}


