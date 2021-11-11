using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using quanlyspa_DTO;
using DAL_quanlyspa;

namespace BUS_quanlyspa
{
    public class BUS_NhapTB
    {
        DAL_NhapTB sql = new DAL_NhapTB();
        // ham insert
        public void _insertData(DTO_NhapTB val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DTO_NhapTB val)
        {
            sql._updateData(val);
        }
        // ham delete
        public void _deleteData(DTO_NhapTB val)
        {
            sql._deleteData(val);
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return sql._selectData(str);
        }
        public string matutang_thietbi(string str)
        {
            return sql.matutang_thietbi(str);
        }
    }
}

