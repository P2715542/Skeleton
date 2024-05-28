<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 142px; top: 246px; position: absolute" Text="Delete" />
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 188px; width: 329px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 12px; top: 246px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 78px; top: 246px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 398px; position: absolute"></asp:Label>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 10px; top: 350px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 142px; top: 350px; position: absolute" Text="Clear Filter" />
        <asp:Label ID="lblEnterAnOrderName" runat="server" style="z-index: 1; left: 10px; top: 300px; position: absolute" Text="Enter an Order Name"></asp:Label>
        <asp:TextBox ID="txtOrderNameFilter" runat="server" style="z-index: 1; left: 164px; top: 299px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
