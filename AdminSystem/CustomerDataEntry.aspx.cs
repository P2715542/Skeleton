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
        //capture the customer id
        AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        AnCustomer.FirstName = txtFirstName.Text;
        AnCustomer.LastName = txtLastName.Text;
        AnCustomer.Email = txtEmail.Text;
        AnCustomer.PhoneNumber = txtPhoneNumber.Text;
        AnCustomer.DateOfBirth = Convert.ToDateTime(DateTime.Now);
        AnCustomer.Active = true;
        //stores the customer in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
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