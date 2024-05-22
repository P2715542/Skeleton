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
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 132px; top: 456px; position: absolute" Text="Edit" />
        </p>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 48px; top: 513px; position: absolute" Text="Enter a Last Name"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 47px; top: 586px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 212px; top: 456px; position: absolute" Text="Delete" />
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 184px; top: 512px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 55px; top: 546px; position: absolute; right: 468px" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 179px; top: 546px; position: absolute" Text="Clear Filter" />
    </form>
</body>
</html>
