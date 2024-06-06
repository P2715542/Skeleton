<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry Form</title>

    <style>
        html {
            height: 100%;
            width: 100%;
        }

        body {
            margin: 0px;
            padding: 0px;
            height: 100%;
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
                border: 1px solid silver;
                border-radius: 3px;
                box-sizing: border-box;
                display: block;
                font-size: 16px;
            }

        #lblError, .error {
            height: auto;
            width: auto;
            margin: 10px;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 16px;
        }

        #customerIDBox {
            position: relative;
        }

        #btnFind {
            position: absolute;
            top: 216px;
            right: 465px;
            height: 31px;
            width: 97px;
            font-size: 18px;
            cursor: pointer;
            background-color: black;
            color: white;
            border: 2px solid black;
            border-radius: 50px;
        }

        .buttons {
            display: flex;
            align-items: center;
            justify-content: space-between;
            margin-top: 40px;
            margin-bottom: 20px;
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

        .checkbox {
            margin-bottom: 20px;
            font-size: 18px;
            display: inline;
            border: 1px solid silver;
            padding: 6px;
        }
    </style>
</head>

<body>

    <div class="form-container">
        <h1>Customer Data Entry Form</h1>

        <form class="main-form" id="frmCustomerDataEntry" runat="server">
            <div class="input-details" id="customerIDBox">
                <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
                <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />

            <div class="input-details">
                <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </div>

            <div class="input-details">
                <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </div>

            <div class="input-details">
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>

            <div class="input-details">
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </div>

            <div class="input-details">
                <asp:Label ID="lblAccountCreated" runat="server" Text="Account Created"></asp:Label>
                <asp:TextBox ID="txtAccountCreated" runat="server"></asp:TextBox>
            </div>

            <div class="checkbox">
                <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
            </div>

            <div class="buttons">
                <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
            </div>

            <div class="error">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>

        </form>

    </div>


</body>

</html>
