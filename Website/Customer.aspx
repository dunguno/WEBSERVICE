<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Website.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .form{
            margin-left:50px;
            margin-top: 20px;
        }
        .text{
            text-align:left;
            padding-left:10px;
            padding:7px;
        }
        .textbox{
            padding-left:1px;
            padding:7px;
            margin-left:0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="our_product">
        <h2>Thông tin khách hàng</h2>
        <table class="form">
                <tr>
                    <td class="text">Mã KH</td>
                    <td class="textbox">
                        <asp:TextBox ID="txtMaKH" runat="server" Width="200px" Height="23px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text">Tên KH</td>
                    <td class="textbox">
                        <asp:TextBox ID="txtTenKH" runat="server" Width="200px" Height="23px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text">Địa chỉ</td>
                    <td class="textbox">
                        <asp:TextBox ID="txtDiaChi" runat="server" Width="200px" Height="50px" TextMode="MultiLine" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text">Số điện thoại</td>
                    <td class="textbox">
                        <asp:TextBox ID="txtSoDienThoai" runat="server" Width="200px" Height="23px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text">Email:</td>
                    <td class="textbox">
                        <asp:TextBox ID="txtEmail" runat="server" Width="200px" Height="23px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text">Tên đăng nhập</td>
                    <td class="textbox">
                        <asp:TextBox ID="txtTenDangNhap" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td><asp:LinkButton runat="server" ID="linkbtnDoiMK" OnClick="linkbtnDoiMK_Click">Đổi mật khẩu</asp:LinkButton></td>
                </tr>
                <tr>
                    <td class="text"><asp:Label id="lbPass_old" runat="server" text="Mật khẩu:" Visible="False"></asp:Label></td>
                    <td class="textbox">
                        <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password" Width="200px" Height="23px" Visible="False"></asp:TextBox>
                    </td>
                    
                </tr>
                 <tr>
                    <td class="text"><asp:Label id="lbPass" runat="server" text="Mật khẩu mới:" Visible="False"></asp:Label></td>
                    <td class="textbox">
                        <asp:TextBox ID="txtMatKhauMoi" runat="server" TextMode="Password" Width="200px" Height="23px" Visible="False"></asp:TextBox>
                    </td>
                  </tr>
                  <tr>
                    <td class="text"><asp:Label id="lbRePass" runat="server" text="Nhập lại mật khẩu:" Visible="False"></asp:Label></td>
                    <td class="textbox">
                        <asp:TextBox ID="txtNhapLaiMK" runat="server" TextMode="Password" Width="200px" Height="23px" Visible="False"></asp:TextBox>
                    </td>
                  </tr>
                <tr>
                    <td style="text-align:right">
                       <asp:Button runat="server" ID ="btnCapNhat" Text="Cập nhật" OnClick="btnCapNhat_Click"/>
                    </td>
                    <td><asp:Button runat="server" ID ="btnQuayLai" Text="Quay lại" OnClick="btnQuayLai_Click" /></td>
                </tr>
            </table>
    </div>
</asp:Content>
