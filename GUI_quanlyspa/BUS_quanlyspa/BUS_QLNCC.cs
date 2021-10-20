using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using quanlyspa_DTO;
using DAL_quanlyspa;

namespace BUS_quanlyspa
{
    public class BUS_QLNCC
    {
        DAL_QLYNCC sql = new DAL_QLYNCC();
        // ham insert
        public void _insertData(DAL_QLYNCC val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DAL_QLYNCC val)
        {
            sql._updateData(val);
        }
        // ham delete
        public void _deleteData(DAL_QLYNCC val)
        {
            sql._deleteData(val);
        }
        // ham selectS
        public DataTable _selectData(string str)
        {
            return sql._selectData(str);
        }
    }
}
