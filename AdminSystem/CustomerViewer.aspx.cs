using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //displays the customer ID for this entry
        Response.Write(AnCustomer.CustomerID);
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //displays the customer ID for this entry
        Response.Write(AnCustomer.FirstName);
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //displays the customer ID for this entry
        Response.Write(AnCustomer.LastName);
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //displays the customer ID for this entry
        Response.Write(AnCustomer.Email);
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //displays the customer ID for this entry
        Response.Write(AnCustomer.PhoneNumber);
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //displays the customer ID for this entry
        Response.Write(AnCustomer.DateOfBirth);
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //displays the customer ID for this entry
        Response.Write(AnCustomer.Active);
    }
}