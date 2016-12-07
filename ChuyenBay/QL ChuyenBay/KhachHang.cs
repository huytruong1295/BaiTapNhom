using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_ChuyenBay
{
    public class KhachHang //Lop Nhan vien
    {
        //
        public string ID { get; set; }
        public string LastName { get; set; }
        public string Firstname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MaVe { get; set; }

        //
        public KhachHang(string id, string lastName, string firstName, string address, string phone, string MaVe)
        {
            this.ID = id;
            this.LastName = lastName;
            this.Firstname = firstName;
            this.Address = address;
            this.Phone = phone;
            this.MaVe = MaVe;
        }
    }
}
