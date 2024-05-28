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
        <asp:ListBox ID="lstSofaList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 364px; width: 620px"></asp:ListBox>
    </form>
</body>
</html>
