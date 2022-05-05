<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update_product.aspx.cs" Inherits="ShoppingWebsite_ASP_NET.update_product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">产品名称：</td>
                    <td>
                        <asp:TextBox ID="pro_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">价格：</td>
                    <td>
                        <asp:TextBox ID="pro_price" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">产品数量：</td>
                    <td>
                        <asp:TextBox ID="pro_num" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">图片路径：</td>
                    <td>
                        <asp:TextBox ID="img_url" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">产品类型：</td>
                    <td>
                        <asp:TextBox ID="pro_kinds" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" Text="确定修改" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="返回个人中心" />
    </form>
</body>
</html>
