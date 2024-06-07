<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry Form</title>

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

        h1 {
            font-size: 26px;
            margin-bottom: 20px;
            margin-top: 15px;
            text-align: center;
            color: black;
        }

        .main-form {
            width: 50%;
            margin: auto;
        }

        .form-container {
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
            width: 80%;
            height: auto;
            margin: 5px;
            padding: 15px;
            background-color: rgb(225, 226, 230);
            color: black;
            border: 1px solid black;
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

        #lblError, .error {
            height: auto;
            width: auto;
            margin-top: 10px;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 16px;
            margin-bottom: 10px;
            color: red;
        }

        #customerIDBox {
            position: relative;
        }

        #btnFind {
            /*position: absolute;*/
            /* top: 116px; */
            /* right: 350px; */
            height: 31px;
            width: 97px;
            font-size: 18px;
            cursor: pointer;
            background-color: black;
            color: white;
            border: 2px solid black;
            border-radius: 50px;
            display: flex;
            align-items: center;
            justify-content: center;
            flex-direction: column;
            padding: 2px;
            margin-top: 5px;
        }
        
        #btnFind:hover {
            background-color: darkred;
            color: white;
        }

        .buttons {
            display: flex;
            align-items: center;
            justify-content: space-between;
            margin-bottom: 15px
        }

        #btnMainMenu {
            height: 35px;
            width: 200px;
            font-size: 18px;
            cursor: pointer;
            background-color: black;
            color: white;
            border: 2px solid black;
            border-radius: 50px;
        }

        #btnOK, #btnCancel {
            height: 35px;
            width: 97px;
            font-size: 18px;
            cursor: pointer;
            background-color: black;
            color: white;
            border: 2px solid black;
            border-radius: 50px;
        }

        #btnOK:hover, #btnCancel:hover, #btnMainMenu:hover {
            background-color: darkred;
            color: white;
        }

        .checkbox {
            font-size: 18px;
            display: flex;
            flex-direction: row-reverse;
            justify-content: flex-end;
            border: 1px solid silver;
            padding: 6px;
        }

        #chkActive {
            margin-left: 10px;
        }
    </style>
</head>

<body>

    <div class="form-container">
        <form class="main-form" id="frmCustomerDataEntry" runat="server">
            <div class="input-details" id="customerIDBox">
                <label id="lblCustomerID" runat="server" for="txtCustomerID">Customer ID</label>
                <asp:TextBox ID="txtCustomerID" runat="server" placeholder="Enter a customer ID..."></asp:TextBox>
                <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            </div>

            <div class="input-details">
                <label id="lblFirstName" runat="server" for="txtFirstName">First Name</label>
                <asp:TextBox ID="txtFirstName" runat="server" placeholder="Enter your first name..."></asp:TextBox>
            </div>

            <div class="input-details">
                <label id="lblLastName" runat="server" for="txtLastName">Last Name</label>
                <asp:TextBox ID="txtLastName" runat="server" placeholder="Enter your last name..."></asp:TextBox>
            </div>

            <div class="input-details">
                <label id="lblEmail" runat="server" for="txtEmail">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your email..."></asp:TextBox>
            </div>

            <div class="input-details">
                <label id="lblPassword" runat="server" for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter your password..."></asp:TextBox>
            </div>

            <div class="input-details">
                <label id="lblAccountCreated" runat="server" for="txtAccountCreated">Account Created</label>
                <asp:TextBox ID="txtAccountCreated" runat="server" placeholder="Enter the date your account was created..."></asp:TextBox>
            </div>

            <div class="checkbox">
                <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
            </div>

            <div class="error">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>

            <div class="buttons">
                <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
            </div>

        </form>

    </div>

</body>

</html>
