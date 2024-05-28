<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 567px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="margin-left: 160px">
            Are you sure you want to delete this record?
        </p>
        <p>
            <asp:Button ID="BtnNo" runat="server" OnClick="BtnNo_Click" style="z-index: 1; left: 343px; top: 106px; position: absolute; width: 77px; height: 26px" Text="No" />
        </p>
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 178px; top: 108px; position: absolute; right: 662px;" Text="Yes" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
