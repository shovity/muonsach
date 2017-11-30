using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class TacGia
    {
        private string maTacGia;
        private string tenTacGia;

        public string MaTacGia
        {
            get
            {
                return maTacGia;
            }

            set
            {
                maTacGia = value;
            }
        }

        public string TenTacGia
        {
            get
            {
                return tenTacGia;
            }

            set
            {
                tenTacGia = value;
            }
        }
    }
}
