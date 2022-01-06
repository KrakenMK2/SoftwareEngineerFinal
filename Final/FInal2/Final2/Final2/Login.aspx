<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Final2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #container{
            margin: auto;
            width: 50%;
            padding: 10px;
        }
        .auto-style1 {
            height: 181px;
        }
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
        <div id="container" class="auto-style1">
            <div>
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox Type="password" ID="Password" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
                <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" />
            </div>
        </div>
    </form>
</body>
</html>
