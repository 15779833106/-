<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_bu.aspx.cs" Inherits="ShoppingWebsite_ASP_NET.admin_bu" %>

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
        <div>
            <br />

        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="幼圆" Font-Overline="True" Font-Size="XX-Large" ForeColor="#333300" Text="商品详细信息"></asp:Label>
            欢迎<asp:Label ID="lb1" runat="server" Font-Bold="True" Font-Names="幼圆" Font-Size="Large" ForeColor="#FF0066"></asp:Label>
            商家<asp:DataList ID="DataList1" runat="server" CssClass="auto-style1" CellPadding="4" OnDeleteCommand="DataList1_DeleteCommand" ForeColor="#333333" Height="648px" Width="100%" OnUpdateCommand="DataList1_UpdateCommand" OnCancelCommand="DataList1_CancelCommand" OnEditCommand="DataList1_EditCommand">
             <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <EditItemTemplate>
                  <table style="width: 100%; height: 180px;">
              
                
                    <tr>
                        <td class="style4">
                            商品数量：</td>
                        <td class="style2">
                            <asp:TextBox ID="txtNum" runat="server" Text='<%# Eval("product_buy_num") %>'></asp:TextBox>
                        </td>
                    </tr>
                        <tr>
                        <td class="style4">
                            商品名称：</td>
                        <td class="style2">
                            <asp:TextBox ID="name" runat="server" Text='<%# Eval("product_name") %>'></asp:TextBox>
                        </td>
                    </tr>
                        <tr>
                        <td class="style4">
                            商品价格：</td>
                        <td class="style2">
                            <asp:TextBox ID="price" runat="server" Text='<%# Eval("product_price") %>'></asp:TextBox>
                        </td>
                    </tr>
                        <tr>
                        <td class="style4">
                            商品类型：</td>
                        <td class="style2">
                            <asp:TextBox ID="kinds" runat="server" Text='<%# Eval("product_kinds") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            <asp:Button ID="btnUpdate" runat="server" CommandArgument='<%# Eval("product_id") %>'
                                CommandName="update" Height="21px" Text="更新" />
                        </td>
                        <td class="style2">
                            <asp:Button ID="btnCancel" runat="server" CommandName="cancel" Text="取消" />
                        </td>
                    </tr>
                </table>
            </EditItemTemplate>
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                 <table class="style1">
                    <tr>
                        
                        <td>
                            商品编号
                        </td>
                        <td>
                            商品名称
                        </td>
                           <td>
                            商品图片
                        </td>
                        <td>
                            商品类型
                        </td>
                        <td>
                            商品价格
                        </td>
                          <td>
                            商品数量
                        </td>

                        <td>
                            修改
                        </td>
                        <td>
                            删除
                        </td>
                   
                        
                    </tr>
            
      
            </HeaderTemplate>
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <ItemTemplate>
                  <tr>
               
                   <td>
                       <asp:Label ID="lblProductId" runat="server" height="100" width="160" 
                    Text='<%# Eval("product_id") %>'></asp:Label>
                   </td>

                    <td>
                        <asp:Label ID="lblProductName" runat="server"  height="100" width="160" 
                    Text='<%# Eval("product_name") %>'></asp:Label>

                   </td>
                      <td>
                <asp:Image ID="image" border="0" height="100" width="135"  runat="server" ImageUrl='<%#Eval("product_img_url" )%>'  />

                      </td>
              
                      <td>
    
                          <asp:Label ID="lblProductKinds" runat="server"  height="100" width="160" 
                    Text='<%# Eval("product_kinds") %>'></asp:Label>
                      </td>

                    <td>
                      <asp:Label ID="lblPrice" runat="server"  height="100" width="160"  Text='<%# Eval("product_price") %>'></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lbNum" runat="server" height="100" width="135"  Text='<%#Eval("product_buy_num") %>'></asp:Label>
                     

                   </td>
                      

                   <td>  
                       <asp:Button ID="btnEdit" runat="server" height="100" width="135" Text="修改" CommandName="Edit" />
                   </td>
                    <td>
                       <asp:Button ID="btnDelete" runat="server" height="100" width="135" Text="删除"
                    CommandArgument='<%# Eval("product_id") %>' CommandName="delete" />

                   </td>
   

               </tr>
              
            </ItemTemplate>
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="bt1" runat="server" OnClick="bt1_Click" Text="添加商品" BackColor="#C8EAF4" BorderStyle="Double" Height="56px" Width="164px" />
        <asp:Button ID="bt2" runat="server" OnClick="bt2_Click" Text="修改个人信息" BackColor="#C8EAF4" BorderStyle="Double" Height="56px" Width="203px" />
        <asp:Button ID="back_shop" runat="server" OnClick="back_shop_Click" Text="返回商城" BackColor="#C8EAF4" BorderStyle="Double" Height="56px" Width="141px" />
        </p>
    </form>
</body>
</html>
