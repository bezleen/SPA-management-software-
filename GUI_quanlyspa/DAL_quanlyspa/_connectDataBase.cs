using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class _connectDataBase
    {
        public static SqlConnection _connect; // default constructor

        public void _KetnoiDB()  // mo ket noi toi database
        {

        }
        public void _NgatketnoiDB() // dong ket noi toi database
        {

        }
        public void _insert_update_delete(string str) // thuc thi cau lenh them xoa sua bang cach truyen lenh sql vao "str"
        {

        }
        public DataTable _select(string str) // thuc thi cau lenh select bang cach truyen lenh sql vao "str" tra ve 1 bang du lieu
        {
            DataTable dt=new DataTable();
            return dt;
        }
        public string _value(string str) // thuc thi cau lenh select bang cach truyen lenh sql vao "str" tra ve 1 ket qua . vs lenh count(*) tra ve 5.
        {
            string kq = null;
            return kq;
        }
    }
}
