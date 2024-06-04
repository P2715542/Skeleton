﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sofalux</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #f8f9fa;
        }
        #login-form {
            width: 100%;
            max-width: 530px;
            padding: 15px;
            margin: auto;
            border: 1px solid;
            border-radius: 10px;
            background: #ffffff;
        }
        .form-label {
            font-weight: bold;
        }
        .btn-primary {
            width: 800%;
        }
        .btn-secondary {
            width: 80%;
        }
        #lblError {
            color: red;
            margin-top: 10px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </div>
                <div class="form-group">
                <label class="form-label">SofaLux Main Menu</label>
            </div>
                <asp:Button ID="btnOrders" runat="server" OnClick="btnOrders_Click" Text="Orders" CssClass="btn btn-primary btn-block" />
                <asp:Button ID="btnSofas" runat="server" OnClick="btnSofas_Click" Text="Sofas" CssClass="btn btn-secondary btn-block" />
                <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Customers" CssClass="btn btn-primary btn-block" />
                <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" Text="Staff" CssClass="btn btn-secondary btn-block" />
    </form>
</body>
</html>