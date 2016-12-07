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

        }

        private void Connect()
        {
            cn.Open();

        }
        private void Disconnect()
        {
            cn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // TEST FUNCTION WITH GITHUB
            
        }


    }
}
