<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 266px;
        }
    </style>
</head>
<body style="height: 392px">
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 15px; top: 37px; position: absolute; height: 19px; width: 117px;" Text="Customer ID"></asp:Label>
        </div>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 168px; top: 35px; position: absolute; width: 165px;" Height="25px" Width="168px"></asp:TextBox>
        <div style="margin-left: 40px">
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 15px; top: 72px; position: absolute; right: 544px" Text="First Name" height="19px" width="92px"></asp:Label>
        </div>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 167px; top: 68px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 14px; top: 108px; position: absolute; right: 545px;" Text="Last Name" height="19px" width="92px"></asp:Label>
        <div style="margin-left: 40px">
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 166px; top: 102px; position: absolute; width: 168px;" height="25px" Width="168px"></asp:TextBox>
        </div>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 16px; top: 144px; position: absolute; width: 64px;" Text="Email" height="19px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 165px; top: 139px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 14px; top: 184px; position: absolute; right: 1494px;" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 164px; top: 179px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblAccountCreated" runat="server" style="z-index: 1; left: 14px; top: 223px; position: absolute; width: 138px;" Text="Account Created" height="19px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 21px; top: 339px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:TextBox ID="txtAccountCreated" runat="server" style="z-index: 1; left: 163px; top: 219px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 110px; top: 259px; position: absolute; width: 78px;" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 295px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 79px; top: 339px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 394px; top: 84px; position: absolute" Text="Find" OnClick="btnFind_Click" />
    </form>
</body>
</html>
