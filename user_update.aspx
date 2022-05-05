<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_update.aspx.cs" Inherits="ShoppingWebsite_ASP_NET.user_update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>信息修改</title>
    <style type="text/css">
        .auto-style1 {
            width: 92px;
        }
        .auto-style2 {
            width: 92px;
            height: 24px;
        }
        .auto-style3 {
            height: 24px;
        }
    </style>
    <style>
        body{background:url(Images/back1.jpg) top left;
        background-size:100%;}
        .auto-style4 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">用户名：</td>
                    <td>
                        <asp:TextBox ID="tb1" runat="server" CssClass="auto-style4" Height="64px" Width="287px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">密码：</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tb2" runat="server" Height="64px" Width="287px"></asp:TextBox>
                    </td>
                </tr>
                    <td class="auto-style1">邮箱：</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tb3" runat="server" Height="64px" Width="287px"></asp:TextBox>
                </td>
            </table>
        </div>
        <asp:Button ID="bt1" runat="server" OnClick="bt1_Click" Text="确定修改信息" BackColor="#DDA7A5" Height="62px" Width="192px" />
        <asp:Button ID="bt2" runat="server" OnClick="bt2_Click" Text="返回用户中心" BackColor="#DDA7A5" Height="63px" Width="191px" />
        <p>
            <asp:Label ID="lb1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
