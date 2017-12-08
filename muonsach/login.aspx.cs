using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace muonsach
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private NguoiDung user = new NguoiDung();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (user.auth(username.Value, password.Value))
            {
                Session["username"] = username.Value;
                Response.Redirect("/home.aspx");
            }
            else
            {
                err.InnerHtml = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
        }
    }
}