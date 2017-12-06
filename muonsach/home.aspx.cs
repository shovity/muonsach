using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace muonsach
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Sach sach = new Sach();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Initial top 20 news
            DataTable newBooks = sach.top20News();
            for (int i = 0; i < newBooks.Rows.Count; i++) newBooks.Rows[i]["ma_sach"] = i + 1;
            ListViewNews.DataSource = newBooks;
            ListViewNews.DataBind();

            // Initial top 20 hot
            DataTable hotBooks = sach.top20News(); // ---FIX ME
            for (int i = 0; i < hotBooks.Rows.Count; i++) hotBooks.Rows[i]["ma_sach"] = i + 1;
            ListViewHot.DataSource = hotBooks;
            ListViewHot.DataBind();
        }
    }
}