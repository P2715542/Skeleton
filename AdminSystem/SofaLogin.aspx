<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SofaLogin.aspx.cs" Inherits="SofaLogin" %>

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
            &nbsp;Sofa Login Page</p>
        <p>
            <asp:TextBox ID="txtUsername" runat="server" height="22px" style="z-index: 1; left: 170px; top: 187px; position: absolute; width: 198px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; top: 189px; position: absolute; height: 21px; width: 101px; left: 49px; bottom: 653px" Text="UserName:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 170px; top: 237px; position: absolute; width: 198px" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" height="21px" style="z-index: 1; left: 49px; top: 239px; position: absolute" Text="Password:" width="101px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 428px; top: 223px; position: absolute"></asp:Label>
            <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; left: 273px; top: 290px; position: absolute" Text="Cancel" OnClick="BtnCancel_Click" />
        </p>
        <asp:Button ID="BtnLogin" runat="server" height="26px" OnClick="BtnLogin_Click" style="z-index: 1; left: 183px; top: 290px; position: absolute" Text="Login" width="60px" />
    </form>
</body>
</html>
