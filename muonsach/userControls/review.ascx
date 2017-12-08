<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="review.ascx.cs" Inherits="muonsach.userControls.review" %>
<div class="review">
    <h3>Bình luận - Nhận xét</h3>
    <textarea class="inputMesg" id="mes" runat="server"></textarea>
    <asp:Button ID="Button1" CssClass="btn btn-send" runat="server" Text="Gửi" OnClick="Button1_Click" />

    <ul class="reviews">
        <asp:ListView ID="ListViewReviews" runat="server">
            <ItemTemplate>
                <li>
                    <h4><%# Eval("ten_dang_nhap") %></h4>
                    <p class="mes"><%# Eval("binh_luan") %></p>
                </li>
            </ItemTemplate>
        </asp:ListView>
   
    </ul>
</div>