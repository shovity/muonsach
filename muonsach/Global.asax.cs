using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using BLL;

namespace muonsach
{
    public class Global : System.Web.HttpApplication
    {
        TruyCap truyCap = new TruyCap();

        protected void Application_Start(object sender, EventArgs e)
        {
            //khoi tao bien luu so truy cap ngay thang nam va tong
            //khoi tao bien luu ngay thang nam
            int[] tong = truyCap.path("/home.aspx");
            Application.Add("truyCapNgayTuanThangNamTong", "" + tong[4] + "/" + tong[0] + 
                "/" + tong[1] + "/" + tong[2] + "/" + tong[3]);

            DateTime dt = DateTime.Parse(truyCap.getNgayHienTai("/home.aspx"));
            Application.Add("ngayTuanThangNam", "" + dt.Day + "/" +
            dt.DayOfWeek + "/" + dt.Month + "/" + dt.Year);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            int check = 0;
            string path = HttpContext.Current.Request.Url.AbsoluteUri;
            string pathcheck = "";
            for (int i = 8, length = path.Length; i < length; i++)
            {
                if (check == 0 && path[i].Equals('/')) check = 1;
                if (check == 1) pathcheck += path[i];
            }
            path = pathcheck;

            string[] date = Application.Contents["ngayTuanThangNam"].ToString().Split('/'),
                truycap = Application.Contents["truyCapNgayTuanThangNamTong"].ToString().Split('/');

            //kiem tra tuan moi, rs so truy cap tuan
            if (date[1].Equals(DayOfWeek.Sunday.ToString()) &&
                DateTime.Now.DayOfWeek.ToString().Equals(DayOfWeek.Monday.ToString()))
            {
                Application.Contents["ngayTuanThangNam"] = date[0] + "/" + DateTime.Now.DayOfWeek +
                    "/" + date[2] + "/" + date[3];
                date[1] = DateTime.Now.DayOfWeek.ToString();
            }
            //kiem tra nam, thang, ngay moi, rs so truy cap ngay, thang, nam
            if (!date[3].Equals(DateTime.Now.Year.ToString()))
            {
                Application.Contents["ngayTuanThangNam"] = "1/" + date[1] + "/1/" + DateTime.Now.Year;
                truycap[0] = "0";
                truycap[2] = "0";
                truycap[3] = "0";
            }
            else if (!date[2].Equals(DateTime.Now.Month.ToString()))
            {
                Application.Contents["ngayTuanThangNam"] = "1/" + date[1] + "/" + DateTime.Now.Month +
                    "/" + date[3];
                truycap[0] = "0";
                truycap[2] = "0";
            }
            else if (!date[0].Equals(DateTime.Now.Day.ToString()))
            {
                Application.Contents["ngayTuanThangNam"] = "" + DateTime.Now.Day + "/" + date[1] +
                    "/" + date[2] + "/" + date[3];
            }

            //tang so truy cap
            int test = Int32.Parse(truycap[0]) + 1;
            truycap[0] = "" + test;
            test = Int32.Parse(truycap[1]) + 1;
            truycap[1] = "" + test;
            test = Int32.Parse(truycap[2]) + 1;
            truycap[2] = "" + test;
            test = Int32.Parse(truycap[3]) + 1;
            truycap[3] = "" + test;
            test = Int32.Parse(truycap[4]) + 1;
            truycap[4] = "" + test;
            Application.Contents["truyCapNgayTuanThangNamTong"] = truycap[0] + "/" + truycap[1] +
                "/" + truycap[2] + "/" + truycap[3] + "/" + truycap[4];

            truyCap.saveToDatabase(path, truycap[0] + "/" + truycap[1] + "/" + truycap[2] +
                "/" + truycap[3] + "/" + truycap[4]);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}