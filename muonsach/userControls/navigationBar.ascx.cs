using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace muonsach.userControls
{
    public partial class navigationBar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null) username.InnerHtml = Session["username"].ToString();
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Contents.Remove("username");
        }
    }
}