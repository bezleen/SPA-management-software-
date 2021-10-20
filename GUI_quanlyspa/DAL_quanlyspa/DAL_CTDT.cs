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
            con._insert_update_delete(@"INSERT INTO CTDT (MABS, MAKH, MALT, TIENTRINH, PHANTRAMDT, DATHANHTOAN) VALUES ('"+val.MABS+"','"+val.MAKH+"','"+val.MALT+"','"+val.TIENTRINH+"','"+val.PHANTRAMDT+"','"+val.DATHANHTOAN+"')");
        }
        // ham update
        public void _updateData(DTO_CTDT val)
        {
            con._insert_update_delete(@"UPDATE CTDT SET TIENTRINH ='" + val.TIENTRINH + "', PHANTRAMDT ='" + val.PHANTRAMDT + "', DATHANHTOAN ='" + val.DATHANHTOAN + "' WHERE MALT='" + val.MALT+"'");
        }
        // ham delete
        public void _deleteData(DTO_CTDT val)
        {
            con._insert_update_delete(@"DELETE FROM CTDT WHERE MALT='" + val.MALT + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM CTDT "+str);
        }
    }
}
