<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer List</title>

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
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
            width: 80%;
            height: auto;
            margin: auto;
            margin: 5px;
            background-color: rgb(225, 226, 230);
            color: black;
            border: 1px solid black;
        }

        .main-form {
            width: 50%;
            margin: auto;
        }

        .customer-list {
            display: flex;
            justify-content: center;
            margin-bottom: 20px;
            font-size: 18px;
        }

        #lstCustomerList {
            width: 400px;
            height: 350px;
            font-size: 16px;
        }

        .buttons {
            display: flex;
            align-items: center;
            justify-content: space-around;
            margin-top: 20px;
            margin-bottom: 15px;
        }

        #btnAdd, #btnEdit, #btnDelete {
            height: 35px;
            width: 97px;
            font-size: 18px;
            cursor: pointer;
            background-color: black;
            color: white;
            border: 2px solid black;
            border-radius: 50px;
        }
        
        #btnAdd:hover, #btnEdit:hover, #btnDelete:hover {
            background-color: darkred;
            color: white;
        }

        #lblLoggedIn, #lblError, .labels {
            height: auto;
            width: auto;
            margin-top: 10px;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 16px;
            margin-bottom: 10px;
        }

        #lblError {
            color: red;
        }

        .input-details {
            margin-bottom: 20px;
            font-size: 18px;
        }

            .input-details label {
                display: block;
                margin-bottom: 5px;
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

        .filter-buttons {
            display: flex;
            align-items: center;
            justify-content: space-between;
            margin-top: 20px;
            margin-bottom: 30px;
            gap: 33px;
        }

        #btnApplyFilter, #btnClearFilter, #btnMainMenu {
            height: 35px;
            width: 205px;
            font-size: 18px;
            cursor: pointer;
            background-color: black;
            color: white;
            border: 2px solid black;
            border-radius: 50px;
        }
        
        #btnApplyFilter:hover, #btnClearFilter:hover, #btnMainMenu:hover {
            background-color: darkred;
            color: white;
        }
    </style>
</head>

<body>
    <div class="form-container">
        <div class="labels">
            <asp:Label ID="lblLoggedIn" runat="server"></asp:Label>
        </div>

        <form class="main-form" id="frmCustomerList" runat="server">
            <div class="customer-list">
                <asp:ListBox ID="lstCustomerList" runat="server"></asp:ListBox>
            </div>

            <div class="buttons">
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click1" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </div>

            <div class="labels">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>

            <div class="input-details">
                <label id="lblLastName" runat="server" for="txtFilter">Enter a Last Name</label>
                <asp:TextBox ID="txtFilter" runat="server" placeholder="Enter a last name to filter the list by..."></asp:TextBox>
            </div>

            <div class="filter-buttons">
                <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
                <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" />
                <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
            </div>

        </form>

    </div>

</body>

</html>
