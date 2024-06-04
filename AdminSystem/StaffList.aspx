<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
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
            width: 400px;
        }
        #form1 div, #form1 p {
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
            margin-bottom: 10px;
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
        .error {
            color: red;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="Form1" runat="server" class="text-center">
    <h1 class="h3 mb-3 font-weight-normal">Staff List</h1>
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" CssClass="form-control" Height="200px"></asp:ListBox>
        </div>
        <div class="form-buttons">
            <asp:Button ID="btnAdd" runat="server" CssClass="form-control" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" CssClass="form-control" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" CssClass="form-control" OnClick="btnDelete_Click" Text="Delete" />
        </div>
        <div>
            <label for="txtLN" class="form-label">Enter a Last Name</label>
            <asp:TextBox ID="txtLN" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-buttons">
            <asp:Button ID="btnApply" runat="server" CssClass="form-control" OnClick="btnApply_Click" Text="Apply Filter" />
            <asp:Button ID="btnClear" runat="server" CssClass="form-control" OnClick="btnClear_Click" Text="Clear Filter" />
        </div>
        <div class="form-buttons">
            <asp:Button ID="btnBack" runat="server" CssClass="form-control" OnClick="btnBack_Click" Text="Back to Main Menu"/>
       </div>
<div>
            <label ID="lblsesh" class="form-label">
            <asp:Label ID="lblsesh" runat="server"></asp:Label>
            </label>
            </div>
            <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
        <br />
    </form>
</body>
</html>
