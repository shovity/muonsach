using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class NhanVien
    {
        private string maNhanVien;
        private string tenDangNhap;
        private string matKhau;
        private string maNhanDang;

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
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
