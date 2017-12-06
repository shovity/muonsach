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
