<%@ Page Title="" Language="C#" MasterPageFile="~/masterLayouts/layout.Master" AutoEventWireup="true" CodeBehind="bookDetail.aspx.cs" Inherits="muonsach.WebForm4" %>

<%@ Register Src="~/userControls/review.ascx" TagPrefix="uc1" TagName="review" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Chi tiết sách</title>
    <link href="statics/css/bookDetail.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPlaceHolder" runat="server">
    <div class="preview">
        <img src="/statics/img/covers/<%= book["anh"] %>" alt="" class="img-pre" />
        <div class="text-pre">
            <ul>
                <li>
                    <span>Tên sách: </span><%= book["ten"] %>
                </li>
                <li>
                    <span>Tác giả: </span><%= book["ten_tac_gia"] %>
                </li>
                <li>
                    <span>Nhà xuất bản: </span><%= book["ten_nxb"] %>
                </li>
                 <li>
                    <span>Năm xuất bản: </span><%= book["nam_xb"] %>
                </li>
                 <li>
                    <span>Loại: </span><%= book["loai"] %>
                </li>
                <li>
                    <span>Giá mua: </span><%= book["gia"] %>₫
                </li>
                <li>
                    <span>Giá thuê: </span><%= book["gia_thue"] %>/tuần
                </li>
                <li>
                    <span>Mô tả: </span><%= book["mo_ta"] %>
                </li>
                <li>
                    <a href="" class="btn btn-mua">MUA NGAY</a>
                </li>
                <li>
                    <a href="" class="btn btn-thue">THUÊ NGAY</a>
                </li>
            </ul>
        </div>
    </div>

    <uc1:review runat="server" id="review" />

    
</asp:Content>
