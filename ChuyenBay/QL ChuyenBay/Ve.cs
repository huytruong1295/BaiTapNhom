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
        public string LoaiVe { get; set; }
        public string Ngaygiobay { get; set; }
        public string Ngaygioban { get; set; }
        public string NoiBan { get; set; }
        public string GiaVe { get; set; }

        public Ve(string MaVe, string MaHK, string MaCB, string LoaiVe, string Ngaygiobay, string Ngaygioban, string NoiBan, string GiaVe)
        {
            this.MaVe = MaVe;
            this.MaHK = MaHK;
            this.MaCB = MaCB;
            this.LoaiVe = LoaiVe;
            this.Ngaygiobay = Ngaygiobay;
            this.Ngaygioban = Ngaygioban;
            this.NoiBan = NoiBan;
            this.GiaVe = GiaVe;
 
        }


    }
}
