using System;
using DAL;
using System.Data;

namespace BLL
{
    public class Sach
    {
        private Data data = new Data();

        public DataTable top20News()
        {
            return data.getDataTable("select * from sach order by ngay_nhap desc");
        }

        public DataTable getById(String id)
        {
            return data.getDataTable("select * from sach where ma_sach = '" + id + "'");
        }
    }
}
