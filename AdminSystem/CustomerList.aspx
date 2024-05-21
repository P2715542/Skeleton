<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 35px; top: 35px; position: absolute; height: 396px; width: 529px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 48px; top: 456px; position: absolute" Text="Add" OnClick="btnAdd_Click1" />
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 131px; top: 456px; position: absolute" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 47px; top: 503px; position: absolute"></asp:Label>
    </form>
</body>
</html>
