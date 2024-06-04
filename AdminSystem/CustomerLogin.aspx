<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Login (Staff)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 40px; top: 135px; position: absolute" Text="UserName"></asp:Label>
        <p>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 43px; top: 180px; position: absolute; height: 19px; right: 605px;" Text="Password"></asp:Label>
        </p>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 140px; top: 134px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 139px; top: 181px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 75px; top: 234px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 158px; top: 234px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 373px; top: 168px; position: absolute"></asp:Label>
        <asp:Label ID="lblCustomerLoginPage" runat="server" style="z-index: 1; left: 38px; top: 60px; position: absolute" Text="Customer Login Page"></asp:Label>
        </form>
</html>
