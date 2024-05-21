<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SofaList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSofaList" runat="server" Height="345px" Width="449px"></asp:ListBox>
        <asp:Button ID="BtnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" Text="Edit" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
