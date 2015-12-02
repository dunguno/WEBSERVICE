<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Website.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="our_product">
    <h2>Giỏ hàng</h2>
        <table>
            </table>
    <asp:Panel ID="pnGioHang" runat="server">

        <asp:GridView ID="gridGioHang" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="black" GridLines="Horizontal" Width="100%" OnSelectedIndexChanged="gridGioHang_SelectedIndexChanged" OnRowCommand="gridGioHang_RowCommand" Height="30px">
            <Columns>
                <asp:TemplateField HeaderText="Mã SP">
                    <ItemTemplate>

                        <asp:Label ID="LabelMaSP" runat="server" Text='<%# Eval("ma_sp") %>'></asp:Label>

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tên SP">
                    <ItemTemplate>
                        <asp:Label ID="LabelTenSP" runat="server" Text='<%# Eval("ten_sp") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Giá">
                    <ItemTemplate>
                        <asp:Label ID="LabelGia" runat="server" Text='<%# Eval("gia") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Số lượng">
                    <ItemTemplate>
                        <asp:Label ID="txtSoLuong" Width="30" runat="server" Text='<%# Eval("soluong") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Hình SP">
                    <ItemTemplate>
                        <asp:Image ID="ImageSP" runat="server" Height="130px" ImageUrl='<%# Eval("hinh", "~/Images/SanPham/{0}") %>' Width="100px" />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Chức năng">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkbtnXoa" runat="server" CommandArgument='<%#Eval("ma_sp") %>' CommandName="Delete" ToolTip="Xóa" OnClientClick="return confirm(&quot;Bạn muốn xóa ?&quot;)">Xóa</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="gray" Font-Bold="True" ForeColor="Black" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Justify" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
  
        </asp:GridView>
        <table>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td>
                    <asp:Label ID="lbphantramgiam" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td colspan="2"><asp:Label ID="LabelTotalText" runat="server" ForeColor="Red" Font-Bold="true"  Text="Tổng tiền giỏ hàng : "></asp:Label>
                    <asp:Label ID="lbtongtien" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td style="text-align: right">
                    <asp:Button ID="btnTiepTuc" runat="server" Text="Tiếp tục mua hàng" Height="22px" Width="120px" Style="margin-left: 156px;" OnClick="btnTiepTuc_Click" /></td>
                <td></td>
                <td>
                    <asp:Button ID="btnHuyGioHang" runat="server" OnClick="btnHuyGioHang_Click" Text="Hủy giỏ hàng" Height="22px" Width="100px"  />
                <td>
                        <asp:Button ID="btnDatHang" runat="server" OnClick="btnDatHang_Click" Text="Đặt hàng" Width="94px" />
                </td>
                </td>
            </tr>
            
        </table>
    </asp:Panel>
    <asp:Panel ID="pnTongTien" runat="server" Visible="false">
        <table>
            <tr>
                <td colspan="2" style="text-align:center"><strong>
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp; Chúc mừng bạn đã đặt hàng thành công!</h1>
                </strong></td>
            </tr>
        </table>

    </asp:Panel>

    <asp:Panel ID="pnMhChuaDangNhap" runat="server" Visible="false">
        <table style="width: 70%">
            <tr>
                <td style="text-align: right">Họ tên người nhận:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtTenKH" runat="server" Width="270px" Height="22px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: right">Địa chỉ:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDiaChi" runat="server" Width="270px" Height="50px" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: right">Số điện thoại:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtSDT" runat="server" Width="270px" Height="22px"></asp:TextBox></td>
            </tr>
            <caption>
                <tr>
                    <td style="text-align: right">Email:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtEmail" runat="server" Width="270px" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnMuaHang" runat="server" Height="22px" Text="Mua hàng" Width="90px"/>
                        <asp:Button ID="btnQuayLai" runat="server" Height="22px" OnClick="btnQuayLai_Click" Text="Quay lại" Width="90px" />
                    </td>
                </tr>
            </caption>

        </table>
    </asp:Panel>
    </div>
</asp:Content>
