<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ListOrder.aspx.cs" Inherits="Website.ListOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="our_product">
    <h2>Lịch sử đặt hàng</h2>
        <asp:GridView ID="gridGioHang" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="black" GridLines="Horizontal" Width="100%" Height="30px">
            <Columns>
                <asp:TemplateField HeaderText="Mã ĐH">
                    <ItemTemplate>

                        <asp:Label ID="LabelMaDH" runat="server" Text='<%# Eval("ma_donhang") %>'></asp:Label>

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ngày ĐH">
                    <ItemTemplate>
                        <asp:Label ID="LabelNgay" runat="server" Text='<%# Eval("ngay_dat") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tình trạng">
                    <ItemTemplate>
                        <asp:Label ID="LabelTinhTrang" runat="server" Text='<%# Eval("tinh_trang") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Xem chi tiết">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkbtnChiTiet" runat="server" CommandArgument='<%#Eval("ma_donhang") %>' CommandName="Detail" ToolTip="Chi tiết">Chi tiết</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#cc0000" Font-Bold="True" ForeColor="Black" Height="35px" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Justify" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
  
        </asp:GridView>
    </div>
</asp:Content>
