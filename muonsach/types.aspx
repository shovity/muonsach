<%@ Page Title="" Language="C#" MasterPageFile="~/masterLayouts/layout.Master" AutoEventWireup="true" CodeBehind="types.aspx.cs" Inherits="muonsach.types" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title><asp:Literal runat="server" ID="literalTitle"></asp:Literal></title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPlaceHolder" runat="server">
    <h1><asp:Literal ID="test" runat="server"></asp:Literal></h1>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
        <ItemTemplate>
            <table>
                <tr>
                    <td>
                        <img src="/statics/img/covers/<%# Eval("anh") %>" />
                    </td>
                    <td>
                        <h2><asp:Literal runat="server" ID="literalName" Text='<%# Eval("ten") %>'></asp:Literal></h2>
                        <p><asp:Literal runat="server" ID="literalCost" Text='<%# Eval("gia") %>'></asp:Literal></p>
                        <p><asp:Literal runat="server" ID="literalTypes" Text='<%# Eval("loai") %>'></asp:Literal></p>
                        <a href="/bookDetail.aspx?id=<%# Eval("ma_sach") %>">chi tiet</a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
