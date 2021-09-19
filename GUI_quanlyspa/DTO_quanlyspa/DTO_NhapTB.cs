using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    public class DTO_NhapTB
    {
        private string _MATB;
        private string _MANCC;
        private string _DONGIA;
        private string _NGAYNHAP;
        private string _NSX;
        private string _SLNHAP;
        private string _DVT;
        private string _THANHTIENDH;
        private string _MANV;

        public string MATB { get => _MATB; set => _MATB = value; }
        public string MANCC { get => _MANCC; set => _MANCC = value; }
        public string DONGIA { get => _DONGIA; set => _DONGIA = value; }
        public string NGAYNHAP { get => _NGAYNHAP; set => _NGAYNHAP = value; }
        public string NSX { get => _NSX; set => _NSX = value; }
        public string SLNHAP { get => _SLNHAP; set => _SLNHAP = value; }
        public string DVT { get => _DVT; set => _DVT = value; }
        public string THANHTIENDH { get => _THANHTIENDH; set => _THANHTIENDH = value; }
        public string MANV { get => _MANV; set => _MANV = value; }
    }
}
