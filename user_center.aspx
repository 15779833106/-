<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_center.aspx.cs" Inherits="ShoppingWebsite_ASP_NET.user_center" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>个人订单中心</title>
         <style>
            body{background:url(Images/back1.jpg) top left;
            background-size:100%;}
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>   
                欢迎 
                <asp:Label ID="lb1" runat="server"></asp:Label>
                用户！<br />
                您的订单信息：
                 
                <br />
                <asp:GridView ID="GV1" runat="server" AutoGenerateColumns="False" CellPadding="3" GridLines="None" Height="200px" Width="80%" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellSpacing="1" >
                    <Columns>
                        

                        <asp:BoundField DataField="userid" HeaderText="用户id" ReadOnly="True" />
                         <asp:TemplateField HeaderText="商品图片">
                    <ItemTemplate>
                       <asp:Image ID="img1" border="0" Height="97" Width="135" ImageUrl='<%#Eval("product_img_url") %>'
                                  runat="server"/>
                    </ItemTemplate>
                </asp:TemplateField>
                        <asp:BoundField DataField="product_name" HeaderText="商品名称"  />
                          <asp:BoundField DataField="product_kinds" HeaderText="类型" />
                        <asp:BoundField DataField="product_price" HeaderText="价格" />
                        <asp:BoundField DataField="product_buy_num" HeaderText="数目" />
                      
                    </Columns >
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <PagerTemplate>
                        你好
                    </PagerTemplate>
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
                <div>
                    <br />
                    <asp:Button ID="bt1" runat="server" Text="修改个人信息" OnClick="bt1_Click1" BackColor="#DCA9A6" Height="53px" Width="241px" />
                    
                    <asp:Button ID="bt3" runat="server" Text="返回商场" OnClick="bt3_Click" BackColor="#DCA9A6" Height="53px" Width="241px" />
                    <asp:Button ID="center1" runat="server" OnClick="center1_Click" Text="返回商品信息中心" BackColor="#DCA9A6" Height="53px" Width="241px" />
                    <asp:Button ID="car" runat="server" OnClick="car_Click" Text="进入我的购物车" BackColor="#DCA9A6" Height="53px" Width="241px"/>
                </div>
                <br/>
            </div>
        </div>
    </form>
</body>
</html>
