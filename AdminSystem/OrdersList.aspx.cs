using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        // create an instance of order collection
        clsOrderCollection Orders = new clsOrderCollection();
        // set the data source to list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        // set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        // set the data field to display
        lstOrderList.DataTextField = "OrderName";
        // bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        // redirect to the data entry page
        Response.Redirect("OrdersDataEntry.aspx");
    }
}