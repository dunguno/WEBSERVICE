<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Website.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="our_product">
        <h2>Sản phẩm</h2>
        <%--<form id="formSanPham" runat="server">--%>
        <asp:DataList ID="DataListSP" runat="server" DataKeyField="ma_sp" RepeatColumns="3" Width="100%" Height="100%" OnItemCommand="DataListSP_ItemCommand">
                    <ItemTemplate>
                        <br />
                        <asp:Image ID="ImageSP" runat="server" ImageUrl='<%# Eval("hinh", "~/Images/SanPham/{0}") %>' Height="150px" Width="150px" />
                        <br />
                        <asp:Label ID="TenSPLabel" runat="server" Font-Bold="true" ForeColor="#727FB6" Text='<%# Eval("ten_sp") %>' />
                        <br />
                        <asp:LinkButton ID="btnMuaHang" Text="Mua" runat="server" CommandArgument='<%#Eval("ma_sp") %>' CommandName="muahang"></asp:LinkButton>
                        <br />
                        Giá:
                        <asp:Label ID="GiaLabel" runat="server" ForeColor="Red" Text='<%# Eval("gia") %>' />
                        VNĐ
                                &nbsp;
                        <br />
                        <a href="ProductDetail.aspx?ma_sp=<%# Eval("ma_sp") %>">Chi tiết sản phẩm</a>
                        &nbsp;
                    </ItemTemplate>
                </asp:DataList>
        <br />
        <table>
           <tr>
               <td></td>
               <td></td>
               <td>&nbsp;</td>
               <td><asp:Button runat="server" ID ="btnDau" Text="Đầu" Height="22px" Width="50px" OnClick="btnDau_Click" /></td>
               <td><asp:Button runat="server" ID ="btnTruoc" Text="Trước" Height="22px" Width="50px" OnClick="btnTruoc_Click" /></td>
               <td><asp:TextBox ID="txtsoTrang" runat="server" Width="29px"></asp:TextBox></td>
               <td><asp:Button runat="server" ID ="btnSau" Text="Sau" Height="22px" Width="50px" OnClick="btnSau_Click" /></td>
               <td><asp:Button runat="server" ID ="btnCuoi" Text="Cuối" Height="22px" Width="50px" OnClick="btnCuoi_Click" /></td>
           </tr>
       </table>
            <%--</form>--%>
    </div>
</asp:Content>
