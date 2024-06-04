using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the address to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (OrderId != -1)
            {
                // display the current data for the record
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        // create an instance of order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        // find record to update
        OrderBook.ThisOrder.Find(OrderId);
        // display the data for the record
        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtOrderName.Text = OrderBook.ThisOrder.OrderName.ToString();
        txtSofaId.Text = OrderBook.ThisOrder.SofaId.ToString();
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
        txtStaffId.Text = OrderBook.ThisOrder.StaffId.ToString();
        txtDateOrdered.Text = OrderBook.ThisOrder.DateOrdered.ToString();
        chkOrderDispatched.Checked = OrderBook.ThisOrder.OrderDispatched;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrders
        clsOrder AnOrder = new clsOrder();
        // capture the order name
        string OrderName = txtOrderName.Text;
        // capture the sofa id
        string SofaId = txtSofaId.Text;
        // capture the customer id 
        string CustomerId = txtCustomerId.Text;
        // capture the staff id
        string StaffId = txtStaffId.Text;
        // capture the date ordered
        string DateOrdered = txtDateOrdered.Text;
        // capture order dispatched check box
        string OrderDispatched = chkOrderDispatched.Text;
        // variable to store error messages
        string Error = "";
        // validate the data
        Error = AnOrder.Valid(OrderName, SofaId, CustomerId, StaffId, DateOrdered);
        if (Error == "")
        {
            // capture the order id
            AnOrder.OrderId = OrderId;
            // capture the order name
            AnOrder.OrderName = OrderName;
            // capture the sofa id
            AnOrder.SofaId = Convert.ToInt32(SofaId);
            // capture the customer id 
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            // capture the staff id
            AnOrder.StaffId = Convert.ToInt32(StaffId);
            // capture the date ordered
            AnOrder.DateOrdered = Convert.ToDateTime(DateOrdered);
            // capture the order dispatched
            AnOrder.OrderDispatched = chkOrderDispatched.Checked;
            // create new instance of order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            // if this is a new record i.e. OrderId = -1 then add the data
            if (OrderId == -1)
            {
                // set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                // add the new record
                OrderList.Add();
            }
            else
            {
                // find the record to update
                OrderList.ThisOrder.Find(OrderId);
                // set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                // update the record
                OrderList.Update();
            }
            // Navigate back to the list page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            // display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create class instance
        clsOrder AnOrder = new clsOrder();
        // create variable to store primary key
        Int32 OrderId;
        // create variable to store result
        Boolean Found = false;
        // get primary key entered by user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        // find the record 
        Found = AnOrder.Find(OrderId);
        // if found
        if (Found == true)
        {
            // display the values of the properties
            txtOrderId.Text = AnOrder.OrderId.ToString();
            txtOrderName.Text = AnOrder.OrderName;
            txtSofaId.Text = AnOrder.SofaId.ToString();
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtStaffId.Text = AnOrder.StaffId.ToString();
            txtDateOrdered.Text = AnOrder.DateOrdered.ToString();
            chkOrderDispatched.Checked = AnOrder.OrderDispatched;
        }
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        // redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect to list page
        Response.Redirect("OrdersList.aspx");
    }
}