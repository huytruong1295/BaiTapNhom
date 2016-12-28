using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_ChuyenBay
{
    public class Ve
    {
        public string MaVe { get; set; }
        public string MaHK { get; set; }
        public string MaCB { get; set; }
        public string HangVe { get; set; }
        public string LoaiVe { get; set; }
        public string NgayBay { get; set; }
        public string NgayBan { get; set; }
        public string GioBay { get; set; }
        public string GioBan { get; set; }
        public string NoiBan { get; set; }
        public string GiaVe { get; set; }

        public Ve(string MaVe, string MaHK, string MaCB, string HangVe, string LoaiVe, string NgayBay, string NgayBan, string GioBay, string GioBan, string NoiBan, string GiaVe)
        {
            this.MaVe = MaVe;
            this.MaHK = MaHK;
            this.MaCB = MaCB;
            this.HangVe = HangVe;
            this.LoaiVe = LoaiVe;
            this.NgayBay = NgayBay;
            this.NgayBan = NgayBan;
            this.GioBay = GioBay;
            this.GioBan = GioBan;
            this.NoiBan = NoiBan;
            this.GiaVe = GiaVe;
 
        }


    }
}
