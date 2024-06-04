<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Login</title>
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
            max-width: 330px;
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
            width: 100%;
        }
        .btn-secondary {
            width: 100%;
        }
        #lblError {
            color: red;
            margin-top: 10px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="Form1" runat="server" class="text-center">
        <h1 class="h3 mb-3 font-weight-normal">Staff Login</h1>
        <div class="form-group">
            <label for="txtUN" class="form-label">User Name</label>
            <asp:TextBox ID="txtUN" runat="server" CssClass="form-control" placeholder="Enter username" />
        </div>
        <div class="form-group">
            <label for="txtPW" class="form-label">Password</label>
            <asp:TextBox ID="txtPW" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter password" />
        </div>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" CssClass="btn btn-primary btn-block" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary btn-block" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
