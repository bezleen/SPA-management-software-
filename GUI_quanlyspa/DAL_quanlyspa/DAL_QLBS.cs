using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL_quanlyspa
{
   public class DAL_QLBS
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_QLBS val)
        {
            con._insert_update_delete(@"INSERT INTO QLBS (MABS, HOTEN, GIOITINH, CHUCVU, CHUYENMON, QUEQUAN, DIACHI, SDT, NBDHD, NKTHD, LUONG) VALUES (N'" + val.MABS + "',N'" + val.HOTEN + "',N'" + val.GIOITINH + "',N'" + val.CHUCVU + "',N'" + val.CHUYENMON + "',N'" + val.QUEQUAN + "',N'" + val.DIACHI + "',N'" + val.SDT + "',N'" + val.NBDHD + "',N'" + val.NKTHD + "',N'" + val.LUONG + "')");
        }
        // ham update
        public void _updateData(DTO_QLBS val)
        {
            con._insert_update_delete(@"UPDATE QLBS SET HOTEN =N'" + val.MABS + "', GIOITINH =N'" + val.GIOITINH + "', CHUCVU =N'" + val.CHUCVU + "', CHUYENMON =N'" + val.CHUYENMON + "', QUEQUAN =N'" + val.QUEQUAN + "', DIACHI =N'" + val.DIACHI + "', SDT =N'" + val.SDT + "', LUONG =N'" + val.LUONG + "', NBDHD =N'" + val.NBDHD + "', NKTHD =N'" + val.NKTHD + "' WHERE MABS= N'" + val.MABS + "'");
        }
        // ham delete
        public void _deleteData(DTO_QLBS val)
        {
            con._insert_update_delete(@"DELETE FROM QLBS WHERE MABS= N'" + val.MABS + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM QLBS " + str);
        }

    }
}
