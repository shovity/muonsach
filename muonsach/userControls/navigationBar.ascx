<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="navigationBar.ascx.cs" Inherits="muonsach.userControls.navigationBar" %>
<div id="navBarContent">
    <ul>
        <li><a href="/home.aspx">TRANG CHỦ</a></li>
        <li><a href="">YÊU THÍCH</a></li>
        <li><a href="">TÀI KHOẢN</a></li>
        <li><a href="">THÔNG TIN</a></li>
        <li><a href="">QUẢN TRỊ</a></li>
    </ul>

    <div class="userBox">

        <%if (Session["username"] != null)
          {
              %>
            
            <div class="username" runat="server" id="username"></div> / 
            <asp:Button CssClass="btn-logout" ID="ButtonLogout" runat="server" Text="Đăng xuất" OnClick="ButtonLogout_Click" />
                    
        <%
          }
          else { 
          %>
        <a href="/login.aspx">Đăng nhập</a> / <a href="/register.aspx">Đăng ký</a>
        <%
          }%>


        

    </div>
</div>
