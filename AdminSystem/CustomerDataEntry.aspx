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
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 15px; top: 32px; position: absolute; height: 19px" Text="Customer ID" width="92px"></asp:Label>
        </div>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 115px; top: 32px; position: absolute"></asp:TextBox>
        <div style="margin-left: 40px">
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 15px; top: 62px; position: absolute; right: 1254px" Text="First Name" height="19px" width="92px"></asp:Label>
        </div>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 115px; top: 62px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 14px; top: 98px; position: absolute; right: 1265px;" Text="Last Name" height="19px" width="92px"></asp:Label>
        <div style="margin-left: 40px">
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 107px; top: 98px; position: absolute; width: 128px;" height="22px"></asp:TextBox>
        </div>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 16px; top: 134px; position: absolute" Text="Email" height="19px" width="92px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 115px; top: 134px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 14px; top: 174px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 115px; top: 175px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 14px; top: 212px; position: absolute" Text="Date Of Birth" height="19px" width="92px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 21px; top: 324px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 115px; top: 213px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 108px; top: 248px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 285px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 79px; top: 324px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
