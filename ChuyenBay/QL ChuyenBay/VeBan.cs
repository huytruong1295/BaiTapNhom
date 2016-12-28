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
    public partial class VeBan : Form
    {
        string cnstr;
        SqlConnection cn;
        DataSet ds;
        DataTable db;
        public VeBan()
        {
            InitializeComponent();
        }

        private void VeBan_Load(object sender, EventArgs e)
        {
            cnstr = "Server = .\\TRUONGHUY; Database= QLChuyenBayVaVeMayBay; Integrated security = true";

            cn = new SqlConnection(cnstr);

            string sql = "Select * from Ve ";
            db = GetDataset(sql).Tables[0];
            dgvve.DataSource = GetDataset(sql).Tables[0];
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

      

        private void btnthem_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string sql = "select * from Ve ";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspAddVe";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVe", txtmave.Text));
                cmd.Parameters.Add(new SqlParameter("@MaHK", txtmahk.Text));
                cmd.Parameters.Add(new SqlParameter("@MaCB", txtchuyenbay.Text));
                cmd.Parameters.Add(new SqlParameter("@ChoNgoi", txtnoiban.Text));
                cmd.Parameters.Add(new SqlParameter("@GiaVe", txtgia.Text));

                cmd.ExecuteNonQuery();
                dgvve.DataSource = GetDataset(sql).Tables[0];
                MessageBox.Show("Thêm thành công !!", "Thông Báo");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }

        private void dgvve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             int index = e.RowIndex;
             txtmave.Text = dgvve.Rows[index].Cells[0].Value.ToString();
             txtmahk.Text = dgvve.Rows[index].Cells[1].Value.ToString();
             txtchuyenbay.Text = dgvve.Rows[index].Cells[2].Value.ToString();
             txtnoiban.Text = dgvve.Rows[index].Cells[3].Value.ToString();
             txtgia.Text = dgvve.Rows[index].Cells[4].Value.ToString();
   

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnoiban_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmahk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtchuyenbay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            InVe f = new InVe();
            f.Show();
           
            
        }
    }
}
