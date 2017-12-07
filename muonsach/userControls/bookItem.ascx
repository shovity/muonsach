<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="bookItem.ascx.cs" Inherits="muonsach.userControls.bookItem" %>
<div class="item">
    <a href="/bookDetail.aspx?id=<%# Eval("ma_sach") %>">
        <img src="/statics/img/covers/<%# Eval("anh") %>" />
        <div class="overlay">
            
        </div>
        <div class="index"><%# Eval("so_trang") %></div>
        <div class="bookName"><%# Eval("ten") %></div>
        <div class="cost"><%# Eval("gia")%>₫</div>
    </a>
</div>