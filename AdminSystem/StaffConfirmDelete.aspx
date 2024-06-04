<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
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
    </style>
</head>
<body>
    <form id="Form1" runat="server" class="text-center">
        <h1 class="h3 mb-3 font-weight-normal">Are you sure you want to delete this record?</h1>
     </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="btn btn-primary btn-block" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" CssClass="btn btn-secondary btn-block" />

    </form>
</body>
</html>
