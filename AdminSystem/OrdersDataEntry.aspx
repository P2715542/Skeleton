<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtOrderId" runat="server" height="19px" style="z-index: 1; left: 155px; top: 37px; position: absolute; bottom: 614px"></asp:TextBox>
            <asp:TextBox ID="txtCustomerId" runat="server" height="19px" style="z-index: 1; left: 155px; top: 161px; position: absolute"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 44px; top: 38px; position: absolute; bottom: 619px" Text="Order Id" width="85px"></asp:Label>
        </p>
        <asp:Label ID="lblOrderName" runat="server" height="19px" style="z-index: 1; left: 44px; top: 78px; position: absolute; bottom: 577px" Text="Order Name" width="85px"></asp:Label>
        <asp:Label ID="lblSofaId" runat="server" style="z-index: 1; left: 44px; top: 120px; position: absolute; height: 19px" Text="Sofa Id" width="85px"></asp:Label>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 44px; top: 162px; position: absolute; height: 19px" Text="Customer Id" width="85px"></asp:Label>
        <asp:Label ID="lblDateOrdered" runat="server" height="19px" style="z-index: 1; left: 44px; top: 250px; position: absolute" Text="Date Ordered" width="85px"></asp:Label>
        <asp:Label ID="lblStaffId" runat="server" height="19px" style="z-index: 1; left: 44px; top: 211px; position: absolute" Text="Staff Id" width="85px"></asp:Label>
        <asp:TextBox ID="txtOrderName" runat="server" height="19px" style="z-index: 1; left: 155px; top: 78px; position: absolute; bottom: 573px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtSofaId" runat="server" height="19px" style="z-index: 1; left: 155px; top: 119px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtStaffId" runat="server" height="19px" style="z-index: 1; left: 155px; top: 208px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateOrdered" runat="server" height="19px" style="z-index: 1; left: 155px; top: 247px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkOrderDispatched" runat="server" height="19px" style="z-index: 1; left: 155px; top: 296px; position: absolute" Text="Order Dispatched" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 44px; top: 332px; position: absolute; margin-top: 0px" width="85px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 44px; top: 369px; position: absolute" Text="OK" width="60px" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 155px; top: 368px; position: absolute" Text="Cancel" />
        </p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 313px; top: 37px; position: absolute" Text="Find" />
    </form>
</body>
</html>
