<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="Website.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .auto-style1 {
            width: 100%;
            height: auto;
        }
        .style1 {
            color:#fff;
            text-align:left;
            font-size:16px;
        }
    .auto-style3 {
        width: 69px;
    }
    .auto-style4 {
        width: 114px;
    }
        .auto-style5 {
            width: 105px;
            padding-left: 20px;
            text-align:left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<form runat="server">--%>
        <table class="auto-style1">
            <tr>
                <td bgcolor="#F9F9F9" class="style1" colspan="3">
                    <strong style="color: #F33636">CHI TIẾT SẢN PHẨM</strong>

                </td>
            </tr>
            <tr>
                <td colspan="9" class="auto-style3" style="align-content: center">
                    <asp:Image ID="ImageSP" runat="server" Height="250px" Width="250px" />
                </td>

            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td></td>
            </tr>
            <tr>
                <td><strong>Tên bánh: </strong></td>
                <td>
                    <asp:Label ID="txtTenSP" runat="server" /></td>
            </tr>

            <tr>

                <td><strong>Loại bánh: </strong></td>
                <td>
                    <asp:Label ID="txtLoaiBanh" runat="server" /></td>

            </tr>

            <tr>
                <td><strong>Mô tả: </strong></td>
                <td>
                    <asp:Label ID="txtMota" runat="server" /></td>

            </tr>
            <tr>
                <td><strong>Giá: </strong></td>
                <td>
                    <asp:Label ID="txtGia" runat="server" />
                </td>

            </tr>
            <tr>
                <td></td>
                <td><strong>
                    <asp:Button ID="btnMuaHang" runat="server" Text="Mua"/></strong></td>
            </tr>

        </table>
    <%--</form>--%>
</asp:Content>
