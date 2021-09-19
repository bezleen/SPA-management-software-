using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    class DTO_LuongNV
    {
        private string _MANV;
        private string _MATT;
        private string _NGAYTT;
        private string _TIENLUONG;
        private string _TIENTHUONG;
        private string _TONGTIEN;

        public string MANV { get => _MANV; set => _MANV = value; }
        public string MATT { get => _MATT; set => _MATT = value; }
        public string NGAYTT { get => _NGAYTT; set => _NGAYTT = value; }
        public string TIENLUONG { get => _TIENLUONG; set => _TIENLUONG = value; }
        public string TIENTHUONG { get => _TIENTHUONG; set => _TIENTHUONG = value; }
        public string TONGTIEN { get => _TONGTIEN; set => _TONGTIEN = value; }
    }
}
