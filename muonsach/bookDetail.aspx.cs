using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace muonsach
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public DataRow book;
        private Sach sach = new Sach();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable books = sach.getById(Request.QueryString.Get("id"));
            book = books.Rows[0];
            //Response.Write(book["ma_sach"]);
        }
    }
}