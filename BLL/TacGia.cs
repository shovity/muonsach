using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class TacGia
    {
        private Data data = new Data();

        public void checkExist(string tentacgia)
        {
            DataTable dataTable = data.getDataTable(
                "select * from tac_gia where " +
                "ten_tac_gia = N'" + tentacgia + "'"
                );

            if (dataTable.Rows.Count == 0)
            {
                insertNew(tentacgia);
            }
        }

        public void insertNew(string tentacgia)
        {
            data.executeNonQuery(
                "insert into tac_gia(ten_tac_gia) values('" + tentacgia + "')"
                );
        }

        public DataTable getByName(string tentacgia)
        {
            return data.getDataTable(
                "select * from tac_gia where " +
                "ten_tac_gia = N'" + tentacgia + "'"
                );
        }
    }
}
