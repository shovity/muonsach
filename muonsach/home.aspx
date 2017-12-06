<%@ Page Title="" Language="C#" MasterPageFile="~/masterLayouts/layout.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="muonsach.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Trang Chủ</title>
    <link href="statics/css/home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPlaceHolder" runat="server">

    
    <h3>SÁCH MỚI NHẤT</h3>
    <div class="list-item">
        <asp:ListView ID="ListViewNews" runat="server">
            <ItemTemplate>
                <div class="item">
                    <img src="/statics/img/covers/<%# Eval("anh") %>" />
                    <div class="index"><%# Eval("ma_sach") %></div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>

    <h3>SÁCH ĐƯỢC MƯỢN NHIỀU NHẤT</h3>
    <div class="list-item">
        <asp:ListView ID="ListViewHot" runat="server">
            <ItemTemplate>
                <div class="item">
                    <img src="/statics/img/covers/<%# Eval("anh") %>" />
                    <div class="index"><%# Eval("ma_sach") %></div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>

 
</asp:Content>
