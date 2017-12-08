using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace muonsach.userControls
{
    public partial class footer : System.Web.UI.UserControl
    {
        TruyCap truyCap = new TruyCap();

        protected void Page_Load(object sender, EventArgs e)
        {
            showTruyCap();
        }

        private void showTruyCap()
        {
            string path = Request.Url.AbsolutePath;
            int[] truycap = truyCap.path(path);
            labelTruycap.Text = "Tổng số truy cập: " + truycap[0] + 
                "; Số truy cập trong ngày: " + truycap[1] + "; Số truy cập trong tuần: " +
                truycap[2];
            labelTruycap2.Text = "Số truy cập trong tháng: " + truycap[3] +
                "; Số truy cập trong năm: " + truycap[4];
        }
    }
}