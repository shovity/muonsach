using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BinhLuan
    {
        private Data data = new Data();

        public DataTable getReviews(String path)
        {
            return data.getDataTable(
                "select * from binh_luan " +
                "inner join nguoi_dung on binh_luan.ma_nguoi_dung = nguoi_dung.ma_nguoi_dung" +
                " where path = '" + path + "' order by ma desc"
            );
        }

        public void addComment(String path, int userID, String mesg)
        {
            data.executeNonQuery(
                "insert into binh_luan(path, ma_nguoi_dung, binh_luan)" +
                "values('"+path+"', "+userID+", '"+mesg+"')"
            );
        }
    }
}
