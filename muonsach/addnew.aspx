<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addnew.aspx.cs" Inherits="muonsach.addnew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2><a href="home.aspx">home</a> <a href="administrator.aspx">quan tri</a></h2> <br />
        <asp:Literal runat="server" ID="test"></asp:Literal>
        <table>
            <tr>
                <td>ma sach: <asp:TextBox ID="textBoxMaSach" runat="server"></asp:TextBox></td>
            </tr>
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
                    <asp:Button runat="server" ID="buttonAdd" Text="them" OnClick="buttonAdd_Click"/>
                    <asp:Button runat="server" ID="buttonReTake" Text="nhap lai" OnClick="buttonReTake_Click"/>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
