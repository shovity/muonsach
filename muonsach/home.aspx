<%@ Page Title="" Language="C#" MasterPageFile="~/masterLayouts/layout.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="muonsach.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Trang Chủ</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPlaceHolder" runat="server">
    home
    <a href="bookDetail.aspx">bookDetail.aspx</a>
    <a href="login.aspx">login.aspx</a>
    <a href="register.aspx">register.aspx</a>
    <asp:Label ID="LabelCountCustomes" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="test" runat="server" ></asp:Label>

</asp:Content>
