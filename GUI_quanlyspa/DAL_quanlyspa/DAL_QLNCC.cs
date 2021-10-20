using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL_quanlyspa
{
    public class DAL_QLNCC
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_QLNCC val)
        {
            con._insert_update_delete(@"SELECT MANCC TENNCC DIENTHOAI DIACHI) VALUES (N'" + val.MANCC + "',N'" + val.TENNCC + "',N'" + val.DIENTHOAI + "',N'" + val.DIACHI +  "')");
        }
        // ham update
        public void _updateData(DTO_QLNCC val)
        {
            con._insert_update_delete(@"UPDATE  QLNCC SET TENNCC = N'" + val.MANCC + "', DIENTHOAI = N'" + val.DIENTHOAI + "', DIACHI = N'" + val.DIACHI + "' WHERE MANCC = N'"+ val.MANCC + "'");
        }
        // ham delete
        public void _deleteData(DTO_QLNCC val)
        {
            con._insert_update_delete(@"DELETE FROM QLNCC WHERE MANCC = N'" + val.MANCC + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM QLNCC "+str);
        }
    }
}
