<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SofaConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="margin-left: 160px">
            Are you sure you want to delete this record?
        </p>
        <p style="margin-left: 160px">
            &nbsp;</p>
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 171px; top: 123px; position: absolute; width: 92px" Text="Yes" />
        <asp:Button ID="BtnNo" runat="server" height="26px" OnClick="BtnNo_Click" style="z-index: 1; top: 120px; position: absolute; left: 330px" Text="No" width="92px" />
    </form>
</body>
</html>
