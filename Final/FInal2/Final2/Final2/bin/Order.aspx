<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Final2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
        .auto-style2 {
            height: 29px;
            width: 111px;
        }
        .auto-style3 {
            width: 111px;
        }
        body
        {
            background-image: url('bg2.jpg');
            background-repeat: no-repeat;
            background-size: cover;
        }
        .auto-style4 {
            width: 29%;
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
            <p>
                <table class="auto-style4">
                    <tr>
                        <td class="auto-style3">OrderID</td>
                        <td><asp:TextBox ID="OrderID" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">ProductID</td>
                        <td><asp:TextBox ID="ProdID" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Quantity</td>
                        <td class="auto-style1"><asp:TextBox ID="Quantity" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
                <asp:GridView ID="OrderDisplay" runat="server">
                </asp:GridView>
                <asp:DropDownList ID="Payment" runat="server">
                    <asp:ListItem>Paypal</asp:ListItem>
                    <asp:ListItem>CreditCard</asp:ListItem>
                    <asp:ListItem>Cash</asp:ListItem>
                    <asp:ListItem>Momo</asp:ListItem>
                </asp:DropDownList>
            </p>
            <asp:Button ID="printButton" runat="server" Text="Print" OnClick="printButton_Click" />
            <asp:Button ID="Button2" runat="server" Text="ProductMana" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
