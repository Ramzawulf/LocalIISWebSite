<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <strong>Log in </strong>
        <br />
        Username
        <asp:TextBox ID="UserNameTextBox" runat="server" ></asp:TextBox>
    </p>
    <p>
        Password <asp:TextBox ID="PasswordButton" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="LogInButton" runat="server" OnClick="LogInButton_Click" Text="Log in" />
    </p>
    <p>
        <asp:HyperLink ID="CreateAccountLink" runat="server" NavigateUrl="~/AccountCreation.aspx" OnDataBinding="Page_Load">Create an account</asp:HyperLink>
    </p>
</asp:Content>
