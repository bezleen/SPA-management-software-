using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_LieuTrinh
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_LieuTrinh val)
        {
            con._insert_update_delete("");
        }
        // ham update
        public void _updateData(DTO_LieuTrinh val)
        {
            con._insert_update_delete("");
        }
        // ham delete
        public void _deleteData(DTO_LieuTrinh val)
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
