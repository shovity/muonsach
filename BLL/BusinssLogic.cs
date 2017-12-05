using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BusinssLogic
    {
        private Data data = new Data();

        public void updateTruyCap(string trang, int tong, int ngay, int tuan, int thang, int nam, 
            int hientai)
        {
            string command = "update TruyCap set 'tong' = " + tong + ", 'ngay' = " + ngay + 
                ", 'thang' = " + thang + ", 'nam' = " + nam + ", 'hien_tai' = " + hientai + 
                " where 'trang' = " + trang;
            data.excuseNonQuery(command);
        }
    }
}
