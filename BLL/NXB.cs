using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class NXB
    {
        private Data data = new Data();

        public void checkNXB(string tennxb)
        {
            DataTable dataTable = data.getDataTable(
                "select * from nxb where " +
                "ten_nxb = N'" + tennxb + "'"
                );

            if (dataTable.Rows.Count == 0)
            {
                insertNew(tennxb);
            }
        }

        public void insertNew(string tennxb)
        {
            data.executeNonQuery(
                "insert into nxb(ten_nxb) values('" + tennxb + "')"
                );
        }

        public DataTable getByName(string tennxb)
        {
            return data.getDataTable(
                "select * from nxb where " +
                "ten_nxb = N'" + tennxb + "'"
                );
        }
    }
}
