using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_ChuyenBay
{
    //Lớp Hành Khách
    public class KhachHang 
    {
        //
        public string MaHK { get; set; }
        public string MaVe { get; set; }
        public string HoHK { get; set; }
        public string TenHK { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        
        //
        public KhachHang(string MaHK, string MaVe, string HoHK, string TenHK, string sodt, string dc)
        {
            this.MaHK = MaHK;
            this.MaVe = MaVe;
            this.HoHK = HoHK;
            this.TenHK = TenHK;
            this.SoDT = sodt;
            this.DiaChi = dc;           
        }
    }
}
