using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class NguoiDung
    {
        private string maNguoiDung;
        private string tenDangNhap;
        private string matKhau;
        private string maNhanDang;

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

        public string TenDangNhap
        {
            get
            {
                return tenDangNhap;
            }

            set
            {
                tenDangNhap = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string MaNhanDang
        {
            get
            {
                return maNhanDang;
            }

            set
            {
                maNhanDang = value;
            }
        }
    }
}
