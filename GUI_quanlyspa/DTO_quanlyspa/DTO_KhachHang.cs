using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    class DTO_KhachHang
    {
        private string _MAKH;
        private string _HOTEN;
        private string _GIOITINH;
        private string _NAMSINH;
        private string _TUOI;
        private string _QUEQUAN;
        private string _QUOCTICH;
        private string _DOITUONG;
        private string _DIENTHOAI;

        public string MAKH { get => _MAKH; set => _MAKH = value; }
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }
        public string GIOITINH { get => _GIOITINH; set => _GIOITINH = value; }
        public string NAMSINH { get => _NAMSINH; set => _NAMSINH = value; }
        public string TUOI { get => _TUOI; set => _TUOI = value; }
        public string QUEQUAN { get => _QUEQUAN; set => _QUEQUAN = value; }
        public string QUOCTICH { get => _QUOCTICH; set => _QUOCTICH = value; }
        public string DOITUONG { get => _DOITUONG; set => _DOITUONG = value; }
        public string DIENTHOAI { get => _DIENTHOAI; set => _DIENTHOAI = value; }
    }
}
