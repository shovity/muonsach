using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class ThongTinNhanVien
    {
        private string ma;
        private string maNhanVien;
        private string soDienThoai;
        private string diaChi;
        private string chucVu;
        private string ngayVaoLam;

        public ThongTinNhanVien()
        {
            setNgayVaoLamMacDinh();
        }

        public void setNgayVaoLamMacDinh ()
        {
            ngayVaoLam = "" + DateTime.Now.Date;
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

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }

        public string NgayVaoLam
        {
            get
            {
                return ngayVaoLam;
            }

            set
            {
                ngayVaoLam = value;
            }
        }
    }
}
