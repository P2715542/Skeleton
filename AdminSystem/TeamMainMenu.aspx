<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sofalux Main Menu (Staff)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 184px; top: 84px; position: absolute" Text="Sofalux Main Menu"></asp:Label>
        <asp:Button ID="btnOrders" runat="server" OnClick="btnOrders_Click" style="z-index: 1; left: 45px; top: 135px; position: absolute" Text="Orders" />
        <p>
            <asp:Button ID="btnSofas" runat="server" OnClick="btnSofas_Click" style="z-index: 1; left: 163px; top: 135px; position: absolute" Text="Sofas" />
        </p>
        <p>
            <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="z-index: 1; left: 281px; top: 135px; position: absolute" Text="Customer" />
        </p>
        <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" style="z-index: 1; left: 405px; top: 135px; position: absolute; height: 26px" Text="Staff" />
    </form>
</body>
</html>
