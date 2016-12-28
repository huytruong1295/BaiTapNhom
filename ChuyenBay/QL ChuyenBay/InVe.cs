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
using Microsoft.Reporting.WinForms;


namespace QL_ChuyenBay
{
    public partial class InVe : Form
    {
        string cnstr = "";
        SqlConnection cn;

        public InVe()
        {
            InitializeComponent();
        }

        private void InVe_Load(object sender, EventArgs e)
        {
            cnstr = "Server = .\\TRUONGHUY; Database= QLChuyenBayVaVeMayBay; Integrated security = true";
            cn = new SqlConnection(cnstr);
            string sql = "select HanhKhach.MaHK, Ve.MaVe, MayBay.MaMB, ChuyenBay.MaCB, HanhKhach.HoHK, HanhKhach.TenHK, ChuyenBay.NgayGioCatCanh, Ve.SoChoNgoi from Ve, MayBay, HanhKhach, ChuyenBay where MayBay.MaMB=ChuyenBay.MaMB and Ve.MaCB=ChuyenBay.MaCB and Ve.MaHK=HanhKhach.MaHK";
            DataTable dtInVe = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dtInVe);
            //...
            ReportDataSource rptIn = new ReportDataSource("InVe", dtInVe);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rptIn);
            reportViewer1.LocalReport.ReportPath = @"..\..\..\rpInVe.rdlc";




            //this.reportViewer1.RefreshReport();
        }

       
    }
}
