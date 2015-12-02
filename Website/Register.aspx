<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Website.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .Label{
            text-align:left;
            padding-left:25px;
            padding-bottom:7px;
        }
        .Textbox{
            padding-left: 15px;
            padding-bottom:7px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="our_product">
        <h2>Đăng ký tài khoản</h2>
        <table class="style2">
        
        <tr>
            <td class="style4">
                <table class="style2">
                    <tr>
                        <td class="style8">
                        </td>
                        <td class="style26">
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                        </td>
                        <td class="style26">
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td class="Label">
                            <asp:Label ID="Label1" runat="server" Text="Họ và Tên  "></asp:Label>
                        </td>
                        <td class="Textbox">
                            <asp:TextBox ID="txtName" runat="server" Width="200px" Height="22px"></asp:TextBox>
                        </td>
                        <td class="style41">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator_Hoten" runat="server" 
                                ControlToValidate="txtName" CssClass="style24" ErrorMessage="Chưa nhập Họ Tên"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="Label">
                            <asp:Label ID="Label2" runat="server" Text="Tên đăng nhập  "></asp:Label>
                        </td>
                        <td class="Textbox">
                            <asp:TextBox ID="txtID" runat="server" Width="200px" Height="22px"></asp:TextBox>
                        </td>
                        <td class="style32">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator_Username" runat="server" 
                                ControlToValidate="txtID" CssClass="style24" 
                                ErrorMessage="Chưa nhập Tên đăng nhập"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="Label">
                            <asp:Label ID="Label3" runat="server" Text="Password  "></asp:Label>
                        </td>
                        <td class="Textbox">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="200px" Height="22px"></asp:TextBox>
                        </td>
                        <td class="style38">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator_Pass" runat="server" 
                                ControlToValidate="txtPassword" CssClass="style24" 
                                ErrorMessage="Chưa nhập Password"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="Label">
                            <asp:Label ID="Label4" runat="server" Text="Nhập lại Password  "></asp:Label>
                        </td>
                        <td class="Textbox">
                            <asp:TextBox ID="txtRePass" runat="server" TextMode="Password" Width="200px" Height="22px"></asp:TextBox>
                        </td>
                        <td class="style18">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator_RePass" runat="server" 
                                ControlToValidate="txtRePass" CssClass="style24" 
                                ErrorMessage="Chưa xác nhận Password"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator_RePass" runat="server" 
                                ControlToCompare="txtPassword" ControlToValidate="txtRePass" CssClass="style24" 
                                ErrorMessage="Password không khớp"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="Label">
                            <asp:Label ID="Label5" runat="server" Text="Số điện thoại  "></asp:Label>
                        </td>
                        <td class="Textbox">
                            <asp:TextBox ID="txtMobile" runat="server" Width="200px" Height="22px"></asp:TextBox>
                        </td>
                        <td>
                            
                        </td>

                    </tr>
                     <tr>
                        <td class="Label">
                            <asp:Label ID="Label7" runat="server" Text="Email  "></asp:Label>
                        </td>
                        <td class="Textbox">
                            <asp:TextBox ID="txtEmail" runat="server" Width="200px" Height="22px"></asp:TextBox>
                        </td>
                         <td>
                             <asp:RegularExpressionValidator ID="EmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" ErrorMessage="Email không hợp lệ"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="Label">
                            <asp:Label ID="Label6" runat="server" Text="Địa chỉ  "></asp:Label>
                        </td>
                        <td class="Textbox">
                            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="200px" Height="85px"></asp:TextBox>
                        </td>
                        <td class="style32">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator_Diachi" runat="server" 
                                ControlToValidate="txtAddress" CssClass="style24" 
                                ErrorMessage="Chưa nhập Địa chỉ"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style22">
                            &nbsp;</td>
                        <td class="style26">
                            &nbsp;</td>
                        <td class="style23">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style8">
                            &nbsp;</td>
                        <td class="style26">
                            <asp:Button ID="Button2" runat="server" Text="Xác nhận" Width="62px" OnClick="Button2_Click" />
                            
                            <asp:Button ID="Button3" runat="server" Text="Xóa"  Width="64px" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
         
        </tr>
        
     
    </table>
    </div>
</asp:Content>
