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
    public partial class addnew : System.Web.UI.Page
    {
        private Sach sach = new Sach();
        private TacGia tacGia = new TacGia();
        private NXB nxb = new NXB();
        private string[,] typesEX = {
            { "vanhoc", "kinhte", "thieunhi", "kynangsongdep", "bameembe", "hocngoaingu"},
            { "Sách văn học", "Sách kinh tế", "Sách thiếu nhi", "Sách kỹ năng - Sống đẹp", "Sách Bà mẹ - Em bé", "Sách Học Ngoại Ngữ"}
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            loadDropDownList();
            if (!IsPostBack)
            {
                setDefault();
            }
        }

        public void loadDropDownList()
        {
            for (int i = 0; i < 6; i++)
            {
                dropDownListLoai.Items.Add(typesEX[1, i]);
            }
        }

        public void setDefault()
        {
            textBoxTen.Text = "";
            textBoxTacGia.Text = "";
            textBoxNhaXB.Text = "";
            textBoxSoTrang.Text = "";
            textBoxGia.Text = "";
            textBoxGiaThue.Text = "";
            textBoxMoTa.Text = "";
            textBoxNamXB.Text = "";
            textBoxNgayNhap.Text = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
            fileUploadAnh = new FileUpload();
        }

        public void saveUploadImage()
        {
            if (fileUploadAnh.FileName != "")
            {
                fileUploadAnh.PostedFile.SaveAs(Server.MapPath("/statics/img/covers/" + fileUploadAnh.FileName));
            }
        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxMaSach.Text != "")
            {
                tacGia.checkExist(textBoxTacGia.Text);
                nxb.checkNXB(textBoxNhaXB.Text);
                sach.addOne(
                    textBoxMaSach.Text,
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
                test.Text = "them thanh cong!";
            } else
            {
                test.Text = "ma sach khong dc trong.";
            }

        }

        protected void buttonReTake_Click(object sender, EventArgs e)
        {
            setDefault();
        }
    }
}