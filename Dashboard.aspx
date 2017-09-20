<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Hello <asp:Label ID="UserNameLabel" runat="server"></asp:Label>
        <br />
        <br />
        Funds:<br />
        Available Funds:
        <asp:Label ID="FundsAvailable" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="WithdrawFundTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="WithdrawFundButton" runat="server" OnClick="WithdrawFundButton_Click" Text="Withdraw Funds" />
        <br />
        <asp:TextBox ID="AddFundTextBox" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="AddFundButton" runat="server" OnClick="AddFundButton_Click" Text="Add Funds" />
&nbsp;<br />
        <br />
        Account:<br />
        <br />
        <asp:Button ID="LogOutButton" runat="server" OnClick="LogOutButton_Click" Text="Log Out" />
        <br />
        <br />
        <asp:Button ID="CloseAccountButton" runat="server" OnClick="CloseAccountButton_Click" Text="Close Account" />
        <br />
    
    </div>
    </form>
</body>
</html>
