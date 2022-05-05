<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="ShoppingWebsite_ASP_NET.Test" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<%--        <div>
            <div id="clock">
                <script type="text/javascript">
                    function changeClock() {
                        var d = new Date();
                        document.getElementById("clock").innerHTML = d.getFullYear() + "-" + (d.getMonth() + 1) + "-" + d.getDate() + " " + d.getHours() + ":" + d.getMinutes() + ":" + d.getSeconds();
                    }
                    setInterval(changeClock, 1000);
                </script>
            </div>
        </div>--%>
<%--        <p>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="上传文件" />
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="454px"></asp:TextBox>
        </p>
        <p>

            <asp:Image ID="Image1" runat="server" Height="297px" Width="624px" />
        </p>
--%>

            <asp:DataList ID="DataListProductList" runat="server" RepeatColumns="4" RepeatDirection="Vertical"
                CellPadding="30" CellSpacing="40" width="100px" onItemDataBound ="DataListProductList_ItemBound" Height="315px">
                <ItemTemplate >
                    <table style="border:1px ; border-style:solid; border-color:#a9a9a9;" CellPadding ="0" CellPacing ="0" width="130px">
                        <tr>
                            <td valign="middle" align="center" height="105px" style="background-color: #D4D0C8">
                                   <asp:ImageButton ID="ImageButton1" runat="server" Height="240px" Width="240px" BorderStyle="None" PostBackUrl="~/HappyShop.aspx"/>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        <asp:TextBox ID="TextBox1" runat="server" Height="155px" TextMode="MultiLine" Width="662px"></asp:TextBox>
        <%--<ajaxToolkit:SlideShowExtender ID="SlideShowExtender1" runat="server" AutoPlay="True" Loop="True" SlideShowServiceMethod="GetSlides" />--%>
        <br />
<%--        <script runat="Server" type="text/C#">
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod]
    public static AjaxControlToolkit.Slide[] GetSlides()
    {
            return new AjaxControlToolkit.Slide[] {
                new AjaxControlToolkit.Slide("Images/roll_img/1.jpg","1","vivo X60"),
                new AjaxControlToolkit.Slide("Images/roll_img/2.jpg","2","Huawei Mate X2"),
                new AjaxControlToolkit.Slide("Images/roll_img/3.jpg","3","3"),
                new AjaxControlToolkit.Slide("Images/roll_img/4.jpg","4","4")
            };
    }
</script>--%>
        <asp:Image runat="server" ID="image1" Height="100" />
        <asp:Button runat="Server" ID="prevButton1" Text="上一张" />
        <asp:Button runat="Server" ID="nextButton1" Text="下一张" />
        <ajaxToolkit:SlideShowExtender runat="Server" ID="slideShowExtender1" TargetControlID="image1"
            NextButtonID="nextButton1" PreviousButtonID="prevButton1" SlideShowServiceMethod="GetSlides"
            Loop="true" AutoPlay="True" PlayInterval="2000" />
    </form>
</body>

</html>
