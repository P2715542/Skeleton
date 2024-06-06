<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Confirm Delete</title>

    <style>
        body {
            margin: 0px;
            padding: 0px;
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            font-family: arial;
        }

        .form-container {
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
            width: 80%;
            height: auto;
            margin: 20px;
            padding: 15px;
            background-color: rgb(225, 226, 230);
            color: black;
            max-height: 700px;
            border: 1px solid black;
        }

        .main-form {
            width: 50%;
            margin: auto;
        }

        #lblConfirmDelete, .confirm-delete {
            height: auto;
            width: auto;
            margin: 10px;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 18px;
        }

        .buttons {
            display: flex;
            align-items: center;
            justify-content: space-evenly;
            margin-top: 40px;
            margin-bottom: 20px;
        }

        #btnYes, #btnNo {
            height: 35px;
            width: 97px;
            font-size: 18px;
            cursor: pointer;
            background-color: black;
            color: white;
            border: 2px solid black;
            border-radius: 50px;
        }
        
        #btnYes:hover, #btnNo:hover {
            background-color: darkred;
            color: white;
        }
    </style>
</head>

<body>
    <div class="form-container">
        <form class="main-form" id="frmCustomerConfirmDelete" runat="server">
            <div class="confirm-delete">
                <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            </div>

            <div class="buttons">
                <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
                <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
            </div>

        </form>

    </div>

</body>

</html>
