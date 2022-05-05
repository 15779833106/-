<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_pru.aspx.cs" Inherits="ShoppingWebsite_ASP_NET.add_pru" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加商品</title>
    <style type="text/css">
        .auto-style2 {
            width: 139px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 139px;
            height: 24px;
        }
        .auto-style5 {
            height: 24px;
        }
        
       
        body{background:url(Images/back1.jpg) top left;
        background-size:100%;}


        .auto-style6 {
            width: 139px;
        }


        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table style="width:100%;">
                 <tr>
                     <td class="auto-style6">产品编号：
                     </td>
                     <td>
                         <asp:TextBox ID="tx1" runat="server" Height="41px" Width="318px"></asp:TextBox>
                     </td>
                 </tr>
            
                <tr>
                    <td class="auto-style2">产品名称：</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tx2" runat="server" Height="41px" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">价格：</td>
                    <td>
                        <asp:TextBox ID="tx3" runat="server" Height="41px" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">数量：</td>
                    <td>
                        <asp:TextBox ID="tx4" runat="server" Height="41px" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">图片地址：</td>
                    <td>
                        <asp:TextBox ID="tx5" runat="server" Height="41px" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">商品类型：</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tx6" runat="server" Height="41px" Width="318px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确定添加" BackColor="#E6AEB1" BorderStyle="Double" Height="81px" Width="204px" Font-Size="Large" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回商品信息中心" BackColor="#E3B0AD" BorderStyle="Double" Height="81px" Width="252px" Font-Size="Large" />
    </form>
</body>
</html>
