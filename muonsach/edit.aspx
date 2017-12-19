<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="muonsach.edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2><a href="home.aspx">Home</a> <a href="administrator.aspx">Quan tri</a> <a href="addnew.aspx">Them sach moi</a></h2>
        <asp:Image runat="server" ID="imageAnh" /> <br />
        <asp:Literal runat="server" ID="test"></asp:Literal>
        <table>
            <tr>
                <td>ten: <asp:TextBox ID="textBoxTen" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>anh bia: <asp:FileUpload runat="server" ID="fileUploadAnh" /></td>
            </tr>
            <tr>
                <td>tac gia: <asp:TextBox ID="textBoxTacGia" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>nha xuat ban: <asp:TextBox ID="textBoxNhaXB" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>So trang: <asp:TextBox ID="textBoxSoTrang" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Gia: <asp:TextBox ID="textBoxGia" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Gia thue: <asp:TextBox ID="textBoxGiaThue" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Loai: <asp:DropDownList runat="server" ID="dropDownListLoai"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>Mo ta: <asp:TextBox ID="textBoxMoTa" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nam xuat ban: <asp:TextBox ID="textBoxNamXB" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Ngay nhap: <asp:TextBox ID="textBoxNgayNhap" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="buttonEdit" Text="sua" OnClick="buttonEdit_Click"/>
                    <asp:Button runat="server" ID="buttonReTake" Text="dat lai" OnClick="buttonReTake_Click"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
