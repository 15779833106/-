<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_busi.aspx.cs" Inherits="ShoppingWebsite_ASP_NET.admin_busi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>管理商品信息中心</title>
     <style type="text/css">
        .auto-style1 {
            margin-top: 3px;
        }
    </style>
       <style>
         body{background:url(Images/back1.jpg) top left;
        background-size:100%;}
        </style>
</head>
<body>
    <form id="form1" runat="server">
       <p>
            欢迎<asp:Label ID="lb1" runat="server" Font-Bold="True" Font-Names="幼圆" Font-Size="Large" ForeColor="#FF0066"></asp:Label>
        &nbsp;商家！</p>
            <asp:Button ID="bt1" runat="server" OnClick="bt1_Click" Text="添加商品" BackColor="#C8EAF4" BorderStyle="Double" Height="56px" Width="164px" />
        <asp:Button ID="bt2" runat="server" OnClick="bt2_Click" Text="修改个人信息" BackColor="#C8EAF4" BorderStyle="Double" Height="56px" Width="203px" />
        <asp:Button ID="back_shop" runat="server" OnClick="back_shop_Click" Text="返回商城" BackColor="#C8EAF4" BorderStyle="Double" Height="56px" Width="141px" />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="幼圆" Font-Overline="True" Font-Size="XX-Large" ForeColor="#333300" Text="商品详细信息"></asp:Label>
        <p id="GV1">
            <asp:GridView ID="GV2" runat="server" AutoGenerateColumns="False" CssClass="auto-style1" Height="242px" Width="100%" CellPadding="4" DataKeyNames="product_num" GridLines="None" OnRowDeleting="GV2_RowDeleting"  ForeColor="#333333" OnRowCommand="GV2_RowCommand" OnRowUpdating="GV2_RowUpdating" >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField HeaderText="管理id" DataField="product_num" Visible="False" />
                       <asp:TemplateField HeaderText="商品id">
                        <ItemTemplate>
                         <asp:TextBox ID="pronum" runat="server" Text='<%# Eval("product_num") %>'></asp:TextBox>

                        </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="商品图片">
                    <ItemTemplate>
                       <asp:Image ID="img1" border="0" Height="97" Width="135" ImageUrl='<%#Eval("product_img_url") %>'
                                  runat="server"/>
                    </ItemTemplate>
   </asp:TemplateField>
                    <asp:TemplateField HeaderText="商品名称">
                        <ItemTemplate>
                         <asp:TextBox ID="name" runat="server" Text='<%# Eval("product_name") %>'></asp:TextBox>

                        </ItemTemplate>
                        </asp:TemplateField>
                      <asp:TemplateField HeaderText="商品价格">
                          <ItemTemplate>
                               <asp:TextBox ID="price" runat="server" Text='<%# Eval("product_price") %>'></asp:TextBox>
                          </ItemTemplate>
                             
                        </asp:TemplateField>
                      <asp:TemplateField HeaderText="商品数量">
                          <ItemTemplate>
                              <asp:TextBox ID="num" runat="server" Text='<%# Eval("product_buy_num") %>'></asp:TextBox>
                          </ItemTemplate>
                              
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="商品类型">
                              <ItemTemplate>
 
                                  <asp:TextBox ID="kinds" runat="server" Text='<%# Eval("product_kinds") %>'></asp:TextBox>
                              </ItemTemplate>
                             
                        </asp:TemplateField>
            
            
                                              
                 
                    <asp:CommandField ShowDeleteButton="True" HeaderText="删除" />
                     <asp:ButtonField ButtonType="button" HeaderText="修改功能" Text="修改" CommandName="Update"  CausesValidation="false"/>

                   
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </p>
    
    </form>
</body>
</html>
