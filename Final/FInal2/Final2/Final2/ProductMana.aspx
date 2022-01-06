<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductMana.aspx.cs" Inherits="Final2.UserMana" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 667px;
        }
        .auto-style3 {
            height: 26px;
            width: 667px;
        }
        .auto-style4 {
            width: 124px;
        }
        body
        {
            background-image: url('bg2.jpg');
            background-repeat: no-repeat;
            background-size: cover;
        }
        #container{
            margin: auto;
            width: 50%;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style4">ProductID</td>
                                <td>
                                    <asp:TextBox ID="proid" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">Product Name</td>
                                <td>
                                    <asp:TextBox ID="proname" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">Price</td>
                                <td>
                                    <asp:TextBox ID="price" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style3">
                        <asp:GridView ID="Products" runat="server" Width="858px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
