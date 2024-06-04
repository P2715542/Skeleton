<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="419px" Width="487px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" Height="36px" OnClick="btnAdd_Click" Text="Add" Width="69px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" Height="34px" OnClick="btnEdit_Click" style="margin-left: 0px" Text="Edit" Width="64px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Height="34px" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" ClientIDMode="AutoID"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
