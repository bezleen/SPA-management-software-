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
        DAL_QLNCC sql = new DAL_QLNCC();
        // ham insert
        public void _insertData(DTO_QLNCC val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DTO_QLNCC val)
        {
            sql._updateData(val);
        }
        // ham delete
        public void _deleteData(DTO_QLNCC val)
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
