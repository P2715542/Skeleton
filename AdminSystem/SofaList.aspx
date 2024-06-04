<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SofaList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 625px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSofaList" runat="server" Height="345px" Width="449px"></asp:ListBox>
        <p>
        <asp:Button ID="BtnAdd" runat="server" OnClick="Button1_Click" Text="Add" height="26px" width="55px" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="z-index: 1; top: 397px; position: absolute; left: 210px" Text="Delete" />
        <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" Text="Edit" height="26px" width="55px" />
        </p>
        <p>
            <asp:Label ID="lblEnter" runat="server" style="z-index: 1; left: 6px; top: 451px; position: absolute" Text="Enter a Sofa Description"></asp:Label>
            <asp:TextBox ID="txtEnteredColour" runat="server" style="z-index: 1; left: 200px; top: 447px; position: absolute; width: 224px"></asp:TextBox>
        </p>
        <p style="margin-left: 640px">
            <asp:Button ID="BtnApplyFilter" runat="server" OnClick="BtnApplyFilter_Click" style="z-index: 1; left: 22px; top: 490px; position: absolute; margin-bottom: 11px" Text="Apply Filter" />
            <asp:Button ID="BtnClearFilter" runat="server" OnClick="BtnClearFilter_Click" style="z-index: 1; left: 194px; top: 490px; position: absolute" Text="Clear Filter" />
            <asp:Button ID="BtnReturn" runat="server" OnClick="BtnReturn_Click1" style="z-index: 1; left: 344px; top: 490px; position: absolute" Text="Return to Main Menu" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 569px; position: absolute" Text="lblError"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
