<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersLogin.aspx.cs" Inherits="OrdersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Orders Login Page"></asp:Label>
        </p>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 76px; top: 129px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 77px; top: 173px; position: absolute" Text="Password: "></asp:Label>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 351px; top: 174px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 163px; top: 129px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 163px; top: 171px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 161px; top: 237px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 229px; top: 238px; position: absolute; height: 26px;" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
