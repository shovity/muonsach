using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class NXB
    {
        private string maNxb;
        private string tenNxb;

        public string MaNxb
        {
            get
            {
                return maNxb;
            }

            set
            {
                maNxb = value;
            }
        }

        public string TenNxb
        {
            get
            {
                return tenNxb;
            }

            set
            {
                tenNxb = value;
            }
        }
    }
}
