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

        public DataTable getByTypes(string types)
        {
            return data.getDataTable(
                "select * from sach where loai = N'" + types + "'"
            );
        }

        public DataTable getAllSach()
        {
            return data.getDataTable(
                "select * from sach " +
                "inner join tac_gia on tac_gia.ma_tac_gia = sach.ma_tac_gia " +
                "inner join nxb on nxb.ma_nxb = sach.ma_nxb "
                );
        }

        public void deleteOne(string masach)
        {
            data.executeNonQuery("Delete from sach where ma_sach = N'" + masach + "'");
        }

        public DataTable LookUpSach(string cost)
        {
            return data.getDataTable(
                "select * from sach " +
                "inner join tac_gia on tac_gia.ma_tac_gia = sach.ma_tac_gia " +
                "inner join nxb on nxb.ma_nxb = sach.ma_nxb where " +
                "ten like N'%" + cost + "%' or " +
                "ten_tac_gia like N'%" + cost + "%'"
                );
        }

        public void editOne(string masach, string ten, string matacgia, string manxb, 
            string sotrang, string gia, string giathue, string loai, string mota, string namxb,
            string ngaynhap, string anh)
        {
            if (anh != "")
            {
                data.executeNonQuery(
                    "update sach set " +
                    "ten = N'" + ten + "', " +
                    "ma_tac_gia = " + matacgia + ", " +
                    "ma_nxb = " + manxb + ", " +
                    "so_trang = " + sotrang + ", " +
                    "gia = " + gia + ", " +
                    "gia_thue = " + giathue + ", " +
                    "loai = N'" + loai + "', " +
                    "mo_ta = N'" + mota + "', " +
                    "nam_xb = '" + namxb + "/01/01', " +
                    "ngay_nhap = '" + ngaynhap + "', " +
                    "anh = N'" + anh + "' " + 
                    "where " +
                    "ma_sach = N'" + masach + "'"
                    );
            } else
            {
                data.executeNonQuery(
                    "update sach set " +
                    "ten = N'" + ten + "', " +
                    "ma_tac_gia = " + matacgia + ", " +
                    "ma_nxb = " + manxb + ", " +
                    "so_trang = " + sotrang + ", " +
                    "gia = " + gia + ", " +
                    "gia_thue = " + giathue + ", " +
                    "loai = N'" + loai + "', " +
                    "mo_ta = N'" + mota + "', " +
                    "nam_xb = '" + namxb + "/01/01', " +
                    "ngay_nhap = '" + ngaynhap + "' " +
                    "where " +
                    "ma_sach = N'" + masach + "'"
                    );
            }
        }

        public void addOne(string masach, string ten, string matacgia, string manxb, string sotrang,
            string gia, string giathue, string loai, string mota, string namxb, string ngaynhap,
            string anh)
        {
            data.executeNonQuery(
                "insert into sach(ma_sach, ten, anh, ma_tac_gia, ma_nxb, so_trang, gia, gia_thue, loai, " +
                "mo_ta, nam_xb, ngay_nhap) " + 
                "values(" + 
                "N'" + masach + "', " +
                "N'" + ten + "', " +
                "N'" + anh + "', " +
                matacgia + ", " +
                manxb + ", " +
                sotrang + ", " +
                gia + ", " + 
                giathue + ", " +
                "N'" + loai + "', " +
                "N'" + mota + "', " +
                "'" + namxb + "/01/01', " +
                "'" + ngaynhap + "'" + 
                ")"
                );
        }
    }
}
