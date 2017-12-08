using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class NguoiDung
    {
        private Data data = new Data();

        public Boolean isNotExist(String username)
        { 
            DataTable users = data.getDataTable(
                "select * from nguoi_dung where ten_dang_nhap = '"+username+"'"
            );
            return users.Rows.Count == 0;
        }

        public void addUser(String username, String password)
        {
            data.executeNonQuery(
                "insert into nguoi_dung(ten_dang_nhap, mat_khau) " +
                "values('"+username+"', '"+password+"')"
            );
        }

        public Boolean auth(String username, String password)
        {
            DataTable users = data.getDataTable(
                "select * from nguoi_dung " +
                "where ten_dang_nhap = '" + username + "' and mat_khau = '"+password+"'"
            );
            return users.Rows.Count != 0;
        }

        public int getIdByUsername(String username)
        {
            return Int32.Parse(data.getDataTable(
                "select * from nguoi_dung where ten_dang_nhap = '" + username + "'"
            ).Rows[0]["ma_nguoi_dung"].ToString());
        }
    }
}
