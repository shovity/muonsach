<%@ Page Title="" Language="C#" MasterPageFile="~/masterLayouts/layout.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="muonsach.WebForm1" %>

<%@ Register Src="~/userControls/bookItem.ascx" TagPrefix="uc1" TagName="bookItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Trang Chủ</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPlaceHolder" runat="server">

    
    <h3>SÁCH MỚI NHẤT</h3>
    <div class="list-item">
        <asp:ListView ID="ListViewNews" runat="server">
            <ItemTemplate>
                <uc1:bookItem runat="server" id="bookItem" />
            </ItemTemplate>
        </asp:ListView>
    </div>

    <h3>SÁCH ĐƯỢC MƯỢN NHIỀU NHẤT</h3>
    <div class="list-item">
        <asp:ListView ID="ListViewHot" runat="server">
            <ItemTemplate>
                <uc1:bookItem runat="server" id="bookItem" />
            </ItemTemplate>
        </asp:ListView>
    </div>

 
</asp:Content>
