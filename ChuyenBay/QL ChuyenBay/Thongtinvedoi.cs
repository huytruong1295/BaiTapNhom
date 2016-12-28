using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Configuration;

namespace QL_ChuyenBay
{
    public partial class Thongtinvedoi : Form
    {
        string cnstr;
        SqlConnection cn;
        DataSet ds;
        DataTable db;
        public Thongtinvedoi()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cnstr = "Server = .\\TRUONGHUY; Database= QLChuyenBayVaVeMayBay; Integrated security = true";

            cn = new SqlConnection(cnstr);

            string sql = "Select * from Ve ";
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
            txtmahk.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtmave.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtchuyenbay.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
           
            txtnoiban.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtgia.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btupd_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                string sql = "select * from Ve ";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspuptVe";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add(new SqlParameter("@MaVe", txtmave.Text));
                cmd.Parameters.Add(new SqlParameter("@MaCB", txtchuyenbay.Text));
                cmd.Parameters.Add(new SqlParameter("@ChoNgoi", txtnoiban.Text));
                cmd.Parameters.Add(new SqlParameter("@GiaVe", txtgia.Text));


                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = GetDataset(sql).Tables[0];
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
         ("Bạn có chắc muốn thoát không?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }


        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            string sql = "select Ve.* from Ve where MaVe = '" + textBox1.Text + "'";
            dataGridView1.DataSource = GetDataset(sql).Tables[0];
        }
    }
}
    

