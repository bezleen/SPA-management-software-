using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_NhapMP
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_NhapMP val)
        {
            con._insert_update_delete(@"INSERT INTO NHAPMP (MAMP, MANCC, NGAYGIAO, DONGIA, NGAYNHAP, SLNHAP, THANHTIENDH, MADH, DVT, MANV) VALUES (N'" + val.MAMP + "',N'" + val.MANCC + "',N'" + val.NGAYGIAO + "',N'" + val.DONGIA + "',N'" + val.NGAYNHAP + "',N'" + val.SLNHAP + "',N'" + val.THANHTIENDH + "',N'" + val.MADH + "',N'" + val.DVT + "',N'" + val.MANV + "')");
        }
        // ham update
        public void _updateData(DTO_NhapMP val)
        {
            con._insert_update_delete(@"UPDATE NHAPMP SET MANCC = N'" + val.MANCC + "', NGAYGIAO = N'" + val.NGAYGIAO + "', DONGIA = N'" + val.DONGIA + "', NGAYNHAP = N'" + val.NGAYNHAP + "', SLNHAP = N'" + val.SLNHAP + "', THANHTIENDH = N'" + val.THANHTIENDH + "', MADH = N'" + val.MADH + "', DVT = N'" + val.DVT + "', MANV = N'" + val.MANV + "' WHERE MAMP = N'" + val.MAMP + "'");
        }
        // ham delete
        public void _deleteData(DTO_NhapMP val)
        {
            con._insert_update_delete(@"DELETE FROM NHAPMP WHERE MAMP = N'" + val.MAMP + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM NHAPMP" + str);
        }
    }
}
