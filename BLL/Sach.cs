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
            return data.getDataTable(
                "select * from sach order by ngay_nhap desc "
            );
        }

        public DataTable getById(String id)
        {
            return data.getDataTable(
                "select * from sach " +
                "inner join tac_gia on tac_gia.ma_tac_gia = sach.ma_tac_gia " +
                "inner join nxb on nxb.ma_nxb = sach.ma_nxb " +
                "where ma_sach = '" + id + "' "
            );
        }
    }
}
