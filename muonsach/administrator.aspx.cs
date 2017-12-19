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
    public partial class administrator : System.Web.UI.Page
    {
        private Sach sach = new Sach();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setGridView();
            }
        }

        protected void search(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                GridView1.DataSource = sach.LookUpSach(textBoxSearch.Text);
                GridView1.DataBind();
            } else
            {
                setGridView();
            }
        }

        protected void buton1_Click(object sender, EventArgs e)
        {
            test.Text = "ggwp!";
        }

        private void setGridView()
        {
            GridView1.DataSource = sach.getAllSach();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            setGridView();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int rowSel = Int32.Parse(e.CommandArgument.ToString());
                string cellSel = GridView1.Rows[rowSel].Cells[0].Text;
                sach.deleteOne(cellSel);
                setGridView();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }


    }
}