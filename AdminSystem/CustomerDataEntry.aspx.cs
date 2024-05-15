using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            //store the customer in the session object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
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