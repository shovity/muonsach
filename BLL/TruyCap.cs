using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class TruyCap
    {
        Data data = new Data();
        DataTable dataTable = new DataTable();

        public int[] path (string trang)
        {
            string cmd = "select * from truy_cap where trang = N'" + trang + "'";
            dataTable = data.getDataTable(cmd);
            //tra ve so truy cap tong, ngay, thang, nam.
            int[] value = { Int32.Parse(dataTable.Rows[0][1].ToString()),
                Int32.Parse(dataTable.Rows[0][2].ToString()),
                Int32.Parse(dataTable.Rows[0][3].ToString()),
                Int32.Parse(dataTable.Rows[0][4].ToString()),
                Int32.Parse(dataTable.Rows[0][5].ToString()) };
            return value;
        }

        public string getNgayHienTai(string trang)
        {
            string cmd = "select hien_tai from truy_cap where trang = N'" + trang + "'";
            dataTable = data.getDataTable(cmd);
            return dataTable.Rows[0][0].ToString();
        }

        public void saveToDatabase(string path, string ngayTuanThangNamTong)
        {
            dataTable = data.getDataTable("select * from truy_cap");
            int flag = 0;
            string[] truycap = ngayTuanThangNamTong.Split('/');
            string date = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() +
                "/" + DateTime.Now.Day.ToString();

            foreach (DataRow row in dataTable.Rows)
            {
                if (row[0].ToString().Equals(path))
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                string cmd = "insert into truy_cap values(N'" + path + "', " + truycap[4] + ", " +
                    truycap[0] + ", " + truycap[1] + ", " + truycap[2] + ", " + truycap[3] +
                    ", '" + date + "')";
                data.executeNonQuery(cmd);
            } else
            {
                string cmd = "update truy_cap set tong = " + truycap[4] + ", ngay = " + truycap[0] +
                    ", tuan = " + truycap[1] + ", thang = " + truycap[2] + ", nam = " +
                    truycap[3] + ", hien_tai = '" + date + "' where trang = N'" + path + "'";
                data.executeNonQuery(cmd);
            }
        }

        public int truyCapNgay()
        {
            string command = "select * from truy_cap";
            dataTable = data.getDataTable(command);

            return Int32.Parse(dataTable.Rows[0][2].ToString());
        }

        public int truyCapThang()
        {
            dataTable = data.getDataTable("select * from truy_cap");
            return Int32.Parse(dataTable.Rows[0][3].ToString());
        }

        public int truyCapNam()
        {
            dataTable = data.getDataTable("select * from truy_cap");
            return Int32.Parse(dataTable.Rows[0][4].ToString());
        }

        public int truyCapTong()
        {
            dataTable = data.getDataTable("select * from truy_cap");
            return Int32.Parse(dataTable.Rows[0][1].ToString());
        }
    }
}
