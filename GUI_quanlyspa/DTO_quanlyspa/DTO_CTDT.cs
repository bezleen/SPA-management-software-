using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    public class DTO_CTDT
    {
        private string _MABS;
        private string _MAKH;
        private string _MALT;
        private string _TIENTRINH;
        private string _PHANTRAMDT;
        private string _DATHANHTOAN;

        public string MABS { get => _MABS; set => _MABS = value; }
        public string MAKH { get => _MAKH; set => _MAKH = value; }
        public string MALT { get => _MALT; set => _MALT = value; }
        public string TIENTRINH { get => _TIENTRINH; set => _TIENTRINH = value; }
        public string PHANTRAMDT { get => _PHANTRAMDT; set => _PHANTRAMDT = value; }
        public string DATHANHTOAN { get => _DATHANHTOAN; set => _DATHANHTOAN = value; }
    }
}
