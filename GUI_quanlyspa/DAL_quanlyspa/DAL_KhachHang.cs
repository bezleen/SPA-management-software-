using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_KhachHang
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_KhachHang val)
        {

        }
        // ham update
        public void _updateData(DTO_KhachHang val)
        {

        }
        // ham delete
        public void _deleteData(DTO_KhachHang val)
        {

        }
        // ham select
        public DataTable _selectData(string str)
        {
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
