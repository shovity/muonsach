using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BinhLuan
    {
        private string ma;
        private string maSach;
        private string maNguoiDung;
        private string binhLuanSach;
        private string thoiGian;

        public BinhLuan ()
        {
            setThoiGianMacDinh();
        }

        public void setThoiGianMacDinh ()
        {
            thoiGian = "" + DateTime.Now.Date;
        }

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public string MaNguoiDung
        {
            get
            {
                return maNguoiDung;
            }

            set
            {
                maNguoiDung = value;
            }
        }

        public string BinhLuanSach
        {
            get
            {
                return binhLuanSach;
            }

            set
            {
                binhLuanSach = value;
            }
        }

        public string ThoiGian
        {
            get
            {
                return thoiGian;
            }

            set
            {
                thoiGian = value;
            }
        }
    }
}
