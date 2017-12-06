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
        BusinssLogic bll = new BusinssLogic();

        protected void Application_Start(object sender, EventArgs e)
        {
            //khoi tao bien luu so truy cap ngay thang nam va tong
            //khoi tao bien luu ngay thang nam
            Application.Add("truyCapNgayTuanThangNamTong", "0/0/0/0/0");
            Application.Add("ngayTuanThangNam", "" + DateTime.Now.Day + "/" + 
                DateTime.Now.DayOfWeek + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            string[] date = Application.Contents["ngayTuanThangNam"].ToString().Split('/'),
                truyCap = Application.Contents["truyCapNgayTuanThangNamTong"].ToString().Split('/');
            
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
                truyCap[0] = "0";
                truyCap[2] = "0";
                truyCap[3] = "0";
            } else if (!date[2].Equals(DateTime.Now.Month.ToString()))
            {
                Application.Contents["ngayTuanThangNam"] = "1/" + date[1] + "/" + DateTime.Now.Month +
                    "/" + date[3];
                truyCap[0] = "0";
                truyCap[2] = "0";
            } else if (!date[0].Equals(DateTime.Now.Day.ToString()))
            {
                Application.Contents["ngayTuanThangNam"] = "" + DateTime.Now.Day + "/" + date[1] +
                    "/" + date[2] + "/" + date[3];
            }

            //tang so truy cap
            int test = Int32.Parse(truyCap[0]) + 1;
            truyCap[0] = "" + test;
            test = Int32.Parse(truyCap[1]) + 1;
            truyCap[1] = "" + test;
            test = Int32.Parse(truyCap[2]) + 1;
            truyCap[2] = "" + test;
            test = Int32.Parse(truyCap[3]) + 1;
            truyCap[3] = "" + test;
            test = Int32.Parse(truyCap[4]) + 1;
            truyCap[4] = "" + test;
            Application.Contents["truyCapNgayTuanThangNamTong"] = truyCap[0] + "/" + truyCap[1] + "/" +
                truyCap[2] + "/" + truyCap[3] + "/" + truyCap[4];

            //luu vao csdl
            bll.updateTruyCap("home", Int32.Parse(truyCap[4]), Int32.Parse(truyCap[0]), 
                Int32.Parse(truyCap[1]), Int32.Parse(truyCap[2]), Int32.Parse(truyCap[3]),
                date[3] + "/" + date[2] + "/" + date[0]);
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