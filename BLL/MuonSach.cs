using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class MuonSach
    {
        private string ma;
        private string maSach;
        private string maNguoiDung;
        private string ngayMuon;
        private string ngayTra;
        private string trangThai;
        private int tien;

        public MuonSach ()
        {
            setTrangThaiMacDinh();
        }

        public void setTrangThaiMacDinh ()
        {
            string[] date = ngayTra.Split('/');
            int day = Int32.Parse(date[3]),
                month = Int32.Parse(date[2]),
                year = Int32.Parse(date[1]);
            if (DateTime.Now.Year - year > 0)
            {
                trangThai = "free";
                return;
            }
            else if (DateTime.Now.Month - month > 0)
            {
                trangThai = "free";
                return;
            }
            else if (DateTime.Now.Day - day > 0)
            {
                trangThai = "free";
                return;
            }
            else
            {
                trangThai = "busy";
            }
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

        public string NgayMuon
        {
            get
            {
                return ngayMuon;
            }

            set
            {
                ngayMuon = value;
            }
        }

        public string NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public int Tien
        {
            get
            {
                return tien;
            }

            set
            {
                tien = value;
            }
        }
    }
}
