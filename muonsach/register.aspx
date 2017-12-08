<%@ Page Title="" Language="C#" MasterPageFile="~/masterLayouts/account.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="muonsach.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Đăng ký</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPlaceHolder" runat="server">
    <p class="err" id="err" runat="server"> </p>
    <h3>Đăng kí tài khoản</h3>
    <p>Tên đăng nhập</p>
    <input name="username" id="username" runat="server" />
    <br />
    <p>Mật khẩu</p>
    <input type="password" name="password" id="password" runat="server" />
    <br />
    <p>Nhập lại mật khẩu</p>
    <input type="password" name="repassword" id="repassword" runat="server" />

    <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Đăng ký" OnClick="Button1_Click" />
</asp:Content>
