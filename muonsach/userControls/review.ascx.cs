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
    public partial class review : System.Web.UI.UserControl
    {
        private BinhLuan bl = new BinhLuan();
        private String path = "";
        private NguoiDung user = new NguoiDung();

        protected void Page_Load(object sender, EventArgs e)
        {
            loadReviews();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = 2;
            if (Session["username"] != null)
            {
                id = user.getIdByUsername(Session["username"].ToString());
            }
            bl.addComment(path, id, mes.Value);
            mes.Value = "";
            loadReviews();
        }

        private void loadReviews()
        {
            // get path
            path = HttpContext.Current.Request.Url.PathAndQuery;
            // get comments
            DataTable reviews = bl.getReviews(path);
            // set data source
            ListViewReviews.DataSource = reviews;
            ListViewReviews.DataBind();
        }
    }
}