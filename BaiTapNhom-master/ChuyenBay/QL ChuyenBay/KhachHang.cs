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
        public string SoCMND { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        
        
        //
        public KhachHang(string MaHK, string MaVe, string HoHK, string TenHK, string SoCMND, string SoDT, string DC, string Email)
        {
            this.MaHK = MaHK;
            this.MaVe = MaVe;
            this.HoHK = HoHK;
            this.TenHK = TenHK;
            this.SoCMND = SoCMND;
            this.SoDT = SoDT;
            this.DiaChi = DC;
            this.Email = Email;
        }
    }
}
