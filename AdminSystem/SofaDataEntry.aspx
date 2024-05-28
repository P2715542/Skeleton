<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SofaDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtSofaId" runat="server" style="z-index: 1; left: 128px; top: 49px; position: absolute; width: 304px; height: 25px"></asp:TextBox>
        <p>
            <asp:Label ID="lblSofaId" runat="server" style="z-index: 1; left: 14px; top: 57px; position: absolute" Text="Sofa ID" width="97px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblSofaDescription" runat="server" style="z-index: 1; left: 14px; top: 120px; position: absolute" Text="SofaDescription"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblSofaColour" runat="server" style="z-index: 1; left: 14px; top: 167px; position: absolute" Text="SofaColour" width="97px"></asp:Label>
            <asp:TextBox ID="txtSofaDescription" runat="server" style="z-index: 1; left: 128px; top: 113px; position: absolute; width: 304px; height: 25px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtSofaColour" runat="server" OnTextChanged="TextBox3_TextChanged" style="z-index: 1; left: 128px; top: 165px; position: absolute; width: 304px; height: 25px; margin-bottom: 0px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 14px; top: 217px; position: absolute; margin-bottom: 0px" Text="Supplier ID" width="97px"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 536px; top: 111px; position: absolute" Text="Find" />
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 128px; top: 213px; position: absolute; width: 304px; height: 25px"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 14px; top: 270px; position: absolute" Text="Price" width="97px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 128px; top: 265px; position: absolute; width: 304px; height: 25px; margin-bottom: 0px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 128px; top: 322px; position: absolute; width: 304px; height: 25px"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 14px; top: 326px; position: absolute" Text="DateAdded" width="97px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 480px">
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 3px; top: 437px; position: absolute; height: 20px; width: 986px; right: 521px"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 245px; top: 449px; position: absolute; margin-bottom: 80px" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 159px; top: 456px; position: absolute; width: 58px" Text="OK" />
            <asp:Button ID="BtnReturn" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 490px; top: 452px; position: absolute" Text="Return to Main Menu" />
        </p>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 135px; top: 382px; position: absolute" Text="Available" />
        <p style="margin-left: 360px">
            &nbsp;</p>
        <p style="margin-left: 360px">
            &nbsp;</p>
    </form>
</body>
</html>
