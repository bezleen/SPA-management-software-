using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL_quanlyspa
{
    public class DAL_QLNV
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_QLNV val)
        {
            con._insert_update_delete(@"INSERT INTO QLNV
                      (MANV, HOTEN, GIOITINH, NHIEMVU, QUEQUAN, DIACHI, SDT, HESOLUONG, NBDHD, NKTHD)
VALUES(N'" + val.MANV + "',N'" + val.HOTEN + "',N'" + val.GIOITINH + "',N'" + val.NHIEMVU + "',N'" + val.QUEQUAN + "',N'" + val.DIACHI + "',N'" + val.SDT + "',N'" + val.HESOLUONG + "',N'" + val.NBDHD + "',N'" + val.NKTHD +  "')");
        }
        // ham update
        public void _updateData(DTO_QLNV val)
        {
            con._insert_update_delete(@"UPDATE  QLNV SET MANV = N '" +val.MANV + "', HOTEN =N '" + val.HOTEN + "', GIOITINH = N '" + val.GIOITINH + "', NHIEMVU = N '" + val.NHIEMVU + "', DIACHI = N '" + val.DIACHI + "', QUEQUAN = N '" + val.QUEQUAN + "', SDT = N '" + val.SDT + "', HESOLUONG = N '" + val.HESOLUONG + "', NBDHD = N '" + val.NBDHD + "', NKTHD = N '" + val.NKTHD + "'WHERE MANV = N'"+val.MANV+"'");
        }
        // ham delete
        public void _deleteData(DTO_QLNV val)
        {
            con._insert_update_delete(@"DELETE FROM QLNV WHERE MANV = N'" + val.MANV + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FORM QLNV" + str);
        }
    }
}
