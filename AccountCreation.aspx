<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccountCreation.aspx.cs" Inherits="AccountCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="Home" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
        <br />
        Create an Account<br />
        <br />
        Username<br />
        <asp:TextBox ID="AccountCreationUserName" runat="server"></asp:TextBox>
        <br />
        Password<br />
        <asp:TextBox ID="AccountCreationPassword" runat="server"></asp:TextBox>
        <br />
        email<br />
        <asp:TextBox ID="AccountCreationEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AccountCreationButton" runat="server" OnClick="AccountCreationButton_Click" Text="Create Account" />
        <br />
    
    </div>
    </form>
</body>
</html>
