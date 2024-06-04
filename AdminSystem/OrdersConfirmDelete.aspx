<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 31px; top: 51px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 46px; top: 102px; position: absolute; right: 1713px; height: 20px; width: 80px;" Text="Yes" />
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 165px; top: 102px; position: absolute; width: 80px; height: 20px" Text="No" />
        </p>
    </form>
</body>
</html>
