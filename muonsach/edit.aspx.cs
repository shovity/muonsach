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
    public partial class edit : System.Web.UI.Page
    {
        private Sach sach = new Sach();
        private TacGia tacGia = new TacGia();
        private NXB nxb = new NXB();
        private string id;
        private string[,] typesEX = {
            { "vanhoc", "kinhte", "thieunhi", "kynangsongdep", "bameembe", "hocngoaingu"},
            { "Sách văn học", "Sách kinh tế", "Sách thiếu nhi", "Sách kỹ năng - Sống đẹp", "Sách Bà mẹ - Em bé", "Sách Học Ngoại Ngữ"}
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString.Get("id");
            loadDropDownList();
            if (!IsPostBack)
            {
                loadInfo(id);
            }
        }

        public void loadDropDownList()
        {
            for (int i = 0; i < 6; i++)
            {
                dropDownListLoai.Items.Add(typesEX[1,i]);
            }
        }

        public void loadInfo(string masach)
        {
            DataTable dataTable = sach.getById(masach);
            textBoxTen.Text = dataTable.Rows[0]["ten"].ToString();
            imageAnh.ImageUrl = "/statics/img/covers/" + dataTable.Rows[0]["anh"].ToString();
            textBoxTacGia.Text = dataTable.Rows[0]["ten_tac_gia"].ToString();
            textBoxNhaXB.Text = dataTable.Rows[0]["ten_nxb"].ToString();
            textBoxSoTrang.Text = dataTable.Rows[0]["so_trang"].ToString();
            textBoxGia.Text = dataTable.Rows[0]["gia"].ToString();
            textBoxGiaThue.Text = dataTable.Rows[0]["gia_thue"].ToString();
            dropDownListLoai.Text = dataTable.Rows[0]["loai"].ToString();
            textBoxMoTa.Text = dataTable.Rows[0]["mo_ta"].ToString();
            textBoxNamXB.Text = DateTime.Parse(dataTable.Rows[0]["nam_xb"].ToString()).Year.ToString();
            DateTime ngaynhap = DateTime.Parse(dataTable.Rows[0]["ngay_nhap"].ToString());
            textBoxNgayNhap.Text = "" + ngaynhap.Year + "/" + ngaynhap.Month + "/" + ngaynhap.Day;
        }

        public void saveUploadImage()
        {
            if(fileUploadAnh.FileName != "")
            {
                fileUploadAnh.PostedFile.SaveAs(Server.MapPath("/statics/img/covers/" + fileUploadAnh.FileName));
            }
        }

        protected void buttonEdit_Click(object sender, EventArgs e)
        {
            tacGia.checkExist(textBoxTacGia.Text);
            nxb.checkNXB(textBoxNhaXB.Text);
            sach.editOne(
                id, 
                textBoxTen.Text, 
                tacGia.getByName(textBoxTacGia.Text).Rows[0]["ma_tac_gia"].ToString(),
                nxb.getByName(textBoxNhaXB.Text).Rows[0]["ma_nxb"].ToString(), 
                textBoxSoTrang.Text,
                textBoxGia.Text, 
                textBoxGiaThue.Text, 
                dropDownListLoai.Text, 
                textBoxMoTa.Text,
                textBoxNamXB.Text, 
                textBoxNgayNhap.Text, 
                fileUploadAnh.FileName
                );
            saveUploadImage();
            loadInfo(id);
            test.Text = "sua thanh cong!";
        }

        protected void buttonReTake_Click(object sender, EventArgs e)
        {
            loadInfo(id);
        }
    }
}