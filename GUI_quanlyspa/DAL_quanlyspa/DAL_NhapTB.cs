using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_NhapTB
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_NhapTB val)
        {
            con._insert_update_delete(@"INSERT INTO NHAPTB (MATB, MANCC, DONGIA, NGAYNHAP, NSX, SLNHAP, DVT, THANHTIENDH, MANV) VALUES (N'" + val.MATB + "',N'" + val.MANCC + "',N'" + val.DONGIA + "',N'" + val.NGAYNHAP + "',N'" + val.NSX + "',N'" + val.SLNHAP + "',N'" + val.DVT + "',N'" + val.THANHTIENDH + "',N'" + val.MANV + "')");
        }
        // ham update
        public void _updateData(DTO_NhapTB val)
        {
            con._insert_update_delete(@"UPDATE NHAPTB SET MANCC = N'" + val.MANCC + "', DONGIA = N'" + val.DONGIA + "', NGAYNHAP = N'" + val.NGAYNHAP + "', NSX = N'" + val.NSX + "', SLNHAP = N'" + val.SLNHAP + "', DVT = N'" + val.DVT + "', THANHTIENDH = N'" + val.THANHTIENDH + "', MANV = N'" + val.MANV + "' WHERE MATB = N'" + val.MATB + "'");
        }
        // ham delete
        public void _deleteData(DTO_NhapTB val)
        {
            con._insert_update_delete(@"DELETE FROM NHAPTB WHERE MATB = N'" + val.MATB + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM NHAPTB" + str);
        }
    }
}