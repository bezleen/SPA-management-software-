using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_CTDT
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_CTDT val)
        {
            con._insert_update_delete(@"INSERT INTO CTDT (MABS, MATT, NGAYTT, TONGTIEN) VALUES (N'" + val.MABS + "',N'" + val.MAKH + "',N'" + val.MALT + "',N'" + val.PHANTRAMDT + "',N'"+ val.TIENTRINH +"')");
        }
        // ham update
        public void _updateData(DTO_CTDT val)
        {
            con._insert_update_delete("");
        }
        // ham delete
        public void _deleteData(DTO_CTDT val)
        {
            con._insert_update_delete("");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("" + str);
        }
    }
}
