<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry Form</title>
</head>

<body style="margin-inline: auto; height: auto; width: auto">

    <div id="form-container" style="position: relative; background-color: black; color: white; margin-inline: auto; width: 576px; height: 368px;">
        <form id="form1" runat="server" style="margin-inline: auto; width: auto; height: auto;">
            <div id="form-elements" style="position: absolute;">
                <asp:Label ID="lblCustomerID" runat="server" Style="z-index: 1; left: 15px; top: 41px; position: absolute; height: 19px; width: 117px; right: 444px;" Text="Customer ID"></asp:Label>
                <asp:TextBox ID="txtCustomerID" runat="server" Style="z-index: 1; left: 167px; top: 35px; position: absolute; width: 165px;" Height="25px" Width="168px"></asp:TextBox>

                <asp:Label ID="lblFirstName" runat="server" Style="z-index: 1; left: 15px; top: 74px; position: absolute; right: 469px" Text="First Name" Height="19px" Width="92px"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" Style="z-index: 1; left: 167px; top: 69px; position: absolute" Height="25px" Width="165px"></asp:TextBox>

                <asp:Label ID="lblLastName" runat="server" Style="z-index: 1; left: 14px; top: 109px; position: absolute; right: 470px;" Text="Last Name" Height="19px" Width="92px"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" Style="z-index: 1; left: 167px; top: 103px; position: absolute; width: 165px;" Height="25px"></asp:TextBox>

                <asp:Label ID="lblEmail" runat="server" Style="z-index: 1; left: 16px; top: 145px; position: absolute; width: 64px; bottom: 204px;" Text="Email" Height="19px"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" Style="z-index: 1; left: 167px; top: 139px; position: absolute" Height="25px" Width="165px"></asp:TextBox>

                <asp:Label ID="lblPassword" runat="server" Style="z-index: 1; left: 14px; top: 185px; position: absolute; right: 470px;" Text="Password" Height="19px" Width="92px"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" Style="z-index: 1; left: 167px; top: 179px; position: absolute" Height="25px" Width="165px"></asp:TextBox>

                <asp:Label ID="lblAccountCreated" runat="server" Style="z-index: 1; left: 14px; top: 225px; position: absolute; width: 130px;" Text="Account Created" Height="19px"></asp:Label>
                <asp:TextBox ID="txtAccountCreated" runat="server" Style="z-index: 1; left: 167px; top: 219px; position: absolute" Height="25px" Width="165px"></asp:TextBox>

                <asp:CheckBox ID="chkActive" runat="server" Style="z-index: 1; left: 162px; top: 258px; position: absolute; width: 78px;" Text="Active" />

                <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 24px; top: 285px; position: absolute; width: 522px; height: 41px;"></asp:Label>

                <asp:Button ID="btnOK" runat="server" Style="z-index: 1; left: 21px; top: 339px; position: absolute" Text="OK" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; left: 79px; top: 339px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
                <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" Style="z-index: 1; left: 171px; top: 339px; position: absolute" Text="Return to Main Menu" />

                <asp:Button ID="btnFind" runat="server" Style="z-index: 1; left: 394px; top: 84px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            </div>
        </form>
    </div>

</body>

</html>
