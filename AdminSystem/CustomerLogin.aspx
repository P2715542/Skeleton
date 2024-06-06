<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Login (Staff)</title>

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
            margin: auto;
            margin: 5px;
            padding: 20px;
            background-color: rgb(225, 226, 230);
            color: black;
            border: 1px solid black;
        }

        .main-form {
            width: 50%;
            margin: auto;
        }

        h1 {
            font-size: 26px;
            margin-bottom: 20px;
            margin-top: 15px;
            text-align: center;
            color: black;
        }

        .input-details {
            margin-bottom: 20px;
            font-size: 18px;
        }

            .input-details label {
                display: block;
            }

            .input-details input {
                width: 100%;
                padding: 10px;
                border: 2px solid silver;
                border-radius: 3px;
                box-sizing: border-box;
                display: block;
                font-size: 16px;
            }

        .buttons {
            display: flex;
            align-items: center;
            justify-content: space-evenly;
            margin-top: 20px;
            margin-bottom: 20px;
        }

        #btnLogin, #btnCancel {
            height: 35px;
            width: 97px;
            font-size: 18px;
            cursor: pointer;
            background-color: black;
            color: white;
            border: 2px solid black;
            border-radius: 50px;
        }

        #btnLogin:hover, #btnCancel:hover {
            background-color: darkred;
            color: white;
        }

        #lblError, .error {
            height: auto;
            width: auto;
            margin: 10px;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 16px;
            color: red;
        }
    </style>
</head>

<body>

    <div class="form-container">
        <h1>Customer Login</h1>
        <form class="main-form" id="frmCustomerLogin" runat="server">

            <div class="input-details">
                <label id="lblUserName" runat="server" for="txtUserName">UserName</label>
                <asp:TextBox ID="txtUserName" runat="server" placeholder="Enter your username..."></asp:TextBox>
            </div>

            <div class="input-details">
                <label id="lblPassword" runat="server" for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Enter your password..."></asp:TextBox>
            </div>

            <div class="error">
                <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
            </div>

            <div class="buttons">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </div>

        </form>
    </div>

</body>

</html>
