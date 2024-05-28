<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 289px">
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; right: 474px; width: 68px;" Text="Staff ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 119px; top: 19px; position: absolute; width: 249px" height="22px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; width: 87px;" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 117px; top: 54px; position: absolute; width: 249px; margin-top: 0px" height="22px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute; right: 522px; width: 86px;" Text="Last Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; top: 91px; position: absolute; left: 117px; width: 249px" height="22px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Email" width="68px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblDoB" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="DoB" width="68px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 117px; top: 129px; position: absolute; width: 249px" height="22px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDoB" runat="server" style="z-index: 1; left: 115px; top: 167px; position: absolute; width: 249px" height="22px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Role" width="68px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; top: 205px; position: absolute; left: 114px; width: 249px" height="22px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="boxActive" runat="server" style="z-index: 1; left: 154px; top: 271px; position: absolute" Text="Active" />
            <br />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 194px; top: 348px; position: absolute; height: 29px; margin-top: 0px;" Text="CANCEL" width="75px" />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 65px; top: 347px; position: absolute; width: 75px; height: 29px" Text="SAVE" />
        </div>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
