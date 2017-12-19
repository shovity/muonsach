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
    public partial class types : System.Web.UI.Page
    {
        private Sach sach = new Sach();
        private string [,] typesEX = {
            { "vanhoc", "kinhte", "thieunhi", "kynangsongdep", "bameembe", "hocngoaingu"},
            { "Sách văn học", "Sách kinh tế", "Sách thiếu nhi", "Sách kỹ năng - Sống đẹp", "Sách Bà mẹ - Em bé", "Sách Học Ngoại Ngữ"}
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            string type = Request.QueryString.Get("loai");
            for (int i = 0; i < 6; i++)
            {
                if (type.Equals(typesEX[0, i].ToString()))
                {
                    type = typesEX[1, i];
                    break;
                }
            }

            literalTitle.Text = type;
            DataTable dataTable = sach.getByTypes(type);
            test.Text = type;
            DataList1.DataSource = dataTable;
            DataList1.DataBind();
        }
    }
}