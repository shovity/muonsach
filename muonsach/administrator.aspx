<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="administrator.aspx.cs" Inherits="muonsach.administrator" EnableEventValidation="True" %>

<%@ Register Src="~/userControls/bookItem.ascx" TagPrefix="uc1" TagName="bookItem" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2><a href="/home.aspx">Home</a></h2><asp:literal ID="test" runat="server"></asp:literal>
        <div style="width: 100%">
        <asp:TextBox runat="server" ID="textBoxSearch" Width="512"></asp:TextBox>
        <asp:Button runat="server" ID="butonSearch" Text="tim kiem" OnClick="search" />
        <a href="addnew.aspx">them sach moi</a>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" PageSize="6">
                <Columns>
                    <asp:BoundField DataField="ma_sach" HeaderText="ma sach" />
                    <asp:TemplateField HeaderText="anh">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "/statics/img/covers/" + Eval("anh") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ten" HeaderText="ten" />
                    <asp:BoundField DataField="ten_tac_gia" HeaderText="tac gia" />
                    <asp:BoundField DataField="ten_nxb" HeaderText="nha xuat ban" />
                    <asp:BoundField DataField="so_trang" HeaderText="so trang" />
                    <asp:BoundField DataField="gia" HeaderText="gia" />
                    <asp:BoundField DataField="gia_thue" HeaderText="gia thue" />
                    <asp:BoundField DataField="loai" HeaderText="loai" />
                    <asp:BoundField DataField="mo_ta" HeaderText="mo ta" />
                    <asp:BoundField DataField="nam_xb" HeaderText="nam xuat ban" />
                    <asp:BoundField DataField="ngay_nhap" HeaderText="ngay nhap" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a href='edit.aspx?id=<%# Eval("ma_sach") %>' >sua doi</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField Text="xoa" CommandName="Delete"/>
                </Columns>
            </asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
