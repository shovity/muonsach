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

        public void increatTruyCap(string trang)
        {
            checkExist(trang);
            string cmd = "select * from truy_cap where trang = N'" + trang + "'";
            dataTable = data.getDataTable(cmd);
            DateTime date = DateTime.Parse(dataTable.Rows[0][6].ToString());
            
            //kiem tra tuan moi
            if (date.DayOfWeek.ToString().Equals(DayOfWeek.Sunday.ToString()) && 
                DateTime.Now.DayOfWeek.ToString().Equals(DayOfWeek.Monday.ToString()))
            {
                dataTable.Rows[0][3] = 0;
            }

            //kiem tra ngay thang nam moi
            if(!date.Year.ToString().Equals(DateTime.Now.Year.ToString()))
            {
                dataTable.Rows[0][2] = 0;
                dataTable.Rows[0][4] = 0;
                dataTable.Rows[0][5] = 0;
            } else if(!date.Month.ToString().Equals(DateTime.Now.Month.ToString()))
            {
                dataTable.Rows[0][2] = 0;
                dataTable.Rows[0][4] = 0;
            } else if (!date.Day.ToString().Equals(DateTime.Now.Day.ToString()))
            {
                dataTable.Rows[0][2] = 0;
            }

            dataTable.Rows[0][1] = Int32.Parse(dataTable.Rows[0][1].ToString()) + 1;
            dataTable.Rows[0][2] = Int32.Parse(dataTable.Rows[0][2].ToString()) + 1;
            dataTable.Rows[0][3] = Int32.Parse(dataTable.Rows[0][3].ToString()) + 1;
            dataTable.Rows[0][4] = Int32.Parse(dataTable.Rows[0][4].ToString()) + 1;
            dataTable.Rows[0][5] = Int32.Parse(dataTable.Rows[0][5].ToString()) + 1;

            saveToDatabase(trang, dataTable.Rows[0][2].ToString() + "/" +
                dataTable.Rows[0][3].ToString() + "/" +
                dataTable.Rows[0][4].ToString() + "/" +
                dataTable.Rows[0][5].ToString() + "/" +
                dataTable.Rows[0][1].ToString());
        }

        public string getNgayHienTai(string trang)
        {
            string cmd = "select hien_tai from truy_cap where trang = N'" + trang + "'";
            dataTable = data.getDataTable(cmd);
            return dataTable.Rows[0][0].ToString();
        }

        public void checkExist(string trang)
        {
            string date = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() +
                "/" + DateTime.Now.Day.ToString();
            dataTable = data.getDataTable("select * from truy_cap where trang = N'" + trang + "'");
            
            if (dataTable.Rows.Count == 0)
            {
                string cmd = "insert into truy_cap values(N'" + trang + "', 0, 0, 0, 0, 0, '" + date + "')";
                data.executeNonQuery(cmd);
            }
        }

        public void saveToDatabase(string path, string ngayTuanThangNamTong)
        {
            dataTable = data.getDataTable("select * from truy_cap");
            int flag = 0;
            string[] truycap = ngayTuanThangNamTong.Split('/');
            string date = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() +
                "/" + DateTime.Now.Day.ToString();
            
            string cmd = "update truy_cap set tong = " + truycap[4] + ", ngay = " + truycap[0] +
                ", tuan = " + truycap[1] + ", thang = " + truycap[2] + ", nam = " +
                truycap[3] + ", hien_tai = '" + date + "' where trang = N'" + path + "'";
            data.executeNonQuery(cmd);
            
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
