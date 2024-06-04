<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        #form1 {
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 300px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        .form-control {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .form-buttons {
            display: flex;
            justify-content: space-between;
        }
        .form-buttons asp:Button {
            width: 48%;
        }
    </style>
</head>
    <body>
    <form id="form2" runat="server">
        <div class="form-group">
            <label for="txtStaffId" class="form-label">Staff ID</label>
            <asp:TextBox ID="txtStaffId" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtFirstName" class="form-label">First Name</label>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtLastName" class="form-label">Last Name</label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtEmail" class="form-label">Email</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDoB" class="form-label">Date of Birth</label>
            <asp:TextBox ID="txtDoB" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtRole" class="form-label">Role</label>
            <asp:TextBox ID="txtRole" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:CheckBox ID="boxActive" runat="server" CssClass="form-control" Text="Active" />
        </div>
        <div class="form-buttons">
            <asp:Button ID="btnSubmit" runat="server" CssClass="form-control" OnClick="btnOK_Click" Text="Submit" />
            <asp:Button ID="btnClear" runat="server" CssClass="form-control" OnClick="btnCancel_Click" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" CssClass="form-control" OnClick="btnFind_Click" Text="Find" />

        </div>
                <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>

    </form>
</body>
</html>



