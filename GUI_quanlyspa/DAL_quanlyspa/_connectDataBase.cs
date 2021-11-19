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
                _connectDataBase._connect = new SqlConnection("Data Source=LAPTOP-A60R360U;Initial Catalog=QuanlySpa;Integrated Security=SSPI;"); //đoi lai cho phu hop
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
                SqlCommand _sqlcmd = new SqlCommand(str,_connect);
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
            try
            {
                _KetnoiDB();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(str, _connect);
                sqlda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine("Someting wrong!" + e);
                return null;
            }
            finally
            {
                _NgatketnoiDB();
            }

        }
        public string _value(string str) // thuc thi cau lenh select bang cach truyen lenh sql vao "str" tra ve 1 ket qua . vs lenh count(*) tra ve 5.
        {
            try
            {
                string kq = null;
                _KetnoiDB();
                SqlCommand sqlcmd = new SqlCommand(str, _connect);
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                    kq = sqldr[0].ToString();
                return kq;
            }
            catch (Exception e)
            {
                Console.WriteLine("Someting wrong!" + e);
                return null;
            }
            finally
            {
                _NgatketnoiDB();
            }
        }
        public string matutang_lieutrinh(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);

            string mlt;
            if (dt.Rows.Count == 0)
                mlt = "LT1";
            else
            {
                string malt = dt.Rows[dt.Rows.Count - 1][0].ToString();
                malt = malt.Substring(2);
                int so = int.Parse(malt) + 1;
                mlt = "LT";
                mlt = mlt + so.ToString();
            }
            return mlt;
        }
        public string matutang_thietbi(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mtb;
            if (dt.Rows.Count == 0)
                mtb = "TB1";
            else
            {
                string matb = dt.Rows[dt.Rows.Count - 1][0].ToString();
                matb = matb.Substring(2);
                int so = int.Parse(matb) + 1;
                mtb = "TB";
                mtb = mtb + so.ToString();
            }
            return mtb;
        }
        public string matutang_hoadon(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mhd;
            if (dt.Rows.Count == 0)
                mhd = "HD1";
            else
            {
                string mahd = dt.Rows[dt.Rows.Count-1][0].ToString();
                mahd = mahd.Substring(2);
                int so = int.Parse(mahd) + 1;
                mhd = "HD";
                mhd = mhd + so.ToString();
            }
            
            return mhd;
        }
    }
}
