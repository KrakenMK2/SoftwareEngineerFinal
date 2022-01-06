<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Receipt.aspx.cs" Inherits="Final2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body
        {
            background-image: url('bg2.jpg');
            background-repeat: no-repeat;
            background-size: cover;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">

            <asp:Button ID="Button1" runat="server" Text="Print" OnClientClick="javascript:window.print();" />

            <asp:GridView ID="Receipt" runat="server" Width="618px">
            </asp:GridView>

        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
