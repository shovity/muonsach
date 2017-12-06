using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace muonsach
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TruyCap truycap = new TruyCap();

        protected void Page_Load(object sender, EventArgs e)
        {
            testSomeThing();
        }

        public void testSomeThing()
        {
            //lay so truy cap tu global. cai nay ko can dung database nhung chi dung dc
            //o muonsach
            string[] demtruycap = Application.Contents["truyCapNgayTuanThangNamTong"].ToString().Split('/');
            string[] date = Application.Contents["ngayTuanThangNam"].ToString().Split('/');

            LabelCountCustomes.Text = "ngay: " + demtruycap[0] + "; tuan: " + demtruycap[1] +
                "; thang: " + demtruycap[2] + "; nam: " + demtruycap[3] + "; tong: " + 
                demtruycap[4];
            
            //lay so truy cap tu class TruyCap trong bll, thang nao co bll la dung dc
            test.Text = truycap.truyCapNgay().ToString();
        }
    }
}