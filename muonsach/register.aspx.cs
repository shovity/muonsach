using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace muonsach
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private NguoiDung user = new NguoiDung();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (password.Value != repassword.Value)
            {
                err.InnerHtml = "Nhập lại mật khẩu không khớp";
            }
            else if (!user.isNotExist(username.Value))
            {
                err.InnerHtml = "Tên người dùng đã tồn tại";
            }
            else
            {
                user.addUser(username.Value, password.Value);
                Session["username"] = username.Value;
                Response.Redirect("/home.aspx");
            }
        }
    }
}