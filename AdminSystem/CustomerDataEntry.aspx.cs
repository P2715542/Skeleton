﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record 
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the customer
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to update
        Customers.ThisCustomer.Find(CustomerID);
        //display the data for the record
        txtCustomerID.Text = Customers.ThisCustomer.CustomerID.ToString();
        txtFirstName.Text = Customers.ThisCustomer.FirstName.ToString();
        txtLastName.Text = Customers.ThisCustomer.LastName.ToString();
        txtEmail.Text = Customers.ThisCustomer.Email.ToString();
        txtPhoneNumber.Text = Customers.ThisCustomer.PhoneNumber.ToString();
        txtDateOfBirth.Text = Customers.ThisCustomer.DateOfBirth.ToString();
        chkActive.Checked = Customers.ThisCustomer.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the first name
        string FirstName = txtFirstName.Text;
        //capture the last name
        string LastName = txtLastName.Text;
        //capture the email
        string Email = txtEmail.Text;
        //capture the phone number
        string PhoneNumber = txtPhoneNumber.Text;
        //capture the date of birth
        string DateOfBirth = txtDateOfBirth.Text;
        //capture the active check box
        string Active = chkActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(FirstName, LastName, Email, PhoneNumber, DateOfBirth);
        if (Error == "")
        {
            //capture the customer id
            AnCustomer.CustomerID = CustomerID;
            //capture the first name
            AnCustomer.FirstName = FirstName;
            //capture the last name
            AnCustomer.LastName = LastName;
            //capture the email
            AnCustomer.Email = Email;
            //capture the phone number
            AnCustomer.PhoneNumber = PhoneNumber;
            //capture the date of birth
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture active
            AnCustomer.Active = chkActive.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e CustomerID = -1 then add the data
            if (CustomerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        int CustomerID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            //txtCustomerID.Text = AnCustomer.CustomerID.ToString();
            txtFirstName.Text = AnCustomer.FirstName;
            txtLastName.Text = AnCustomer.LastName;
            txtEmail.Text = AnCustomer.Email;
            txtPhoneNumber.Text = AnCustomer.PhoneNumber;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
            chkActive.Checked = AnCustomer.Active;
        }
    }
}