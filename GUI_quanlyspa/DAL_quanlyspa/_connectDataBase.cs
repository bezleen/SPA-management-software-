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
            if (_connectDataBase._connect == null)
                _connectDataBase._connect = new SqlConnection("Data Source=myServerAddress;Initial Catalog=myDataBase;Integrated Security=SSPI;"); //đoi lai cho phu hop
            if (_connectDataBase._connect.State != ConnectionState.Open)
                _connectDataBase._connect.Open();
        }
        public void _NgatketnoiDB() // dong ket noi toi database
        {
            if (_connectDataBase._connect != null && _connectDataBase._connect.State == ConnectionState.Open)
                _connectDataBase._connect.Close();
        }
        public void _insert_update_delete(string str) // thuc thi cau lenh them xoa sua bang cach truyen lenh sql vao "str"
        {
            try
            {
                _KetnoiDB();
                SqlCommand _sqlcmd = new SqlCommand(str);
                _sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Someting wrong!" + e);
            }
            finally
            {
                _NgatketnoiDB();
            }
        }
        public DataTable _select(string str) // thuc thi cau lenh select bang cach truyen lenh sql vao "str" tra ve 1 bang du lieu
        {

            // nho xai try-catch-finally
            DataTable dt=new DataTable();
            return dt;
        }
        public string _value(string str) // thuc thi cau lenh select bang cach truyen lenh sql vao "str" tra ve 1 ket qua . vs lenh count(*) tra ve 5.
        {
            // nho xai try-catch-finally
            string kq = null;
            return kq;
        }
    }
}
