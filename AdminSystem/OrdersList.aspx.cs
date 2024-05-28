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

        // create an instance of clsOrderUser
        clsOrderUser AnUser = new clsOrderUser();
        // get data from the session object
        AnUser = (clsOrderUser)Session["AnUser"];
        // display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        Int32 OrderId;
        // if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            // store the data in the session object
            Session["OrderId"] = OrderId;
            // redirect to edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else     // if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        Int32 OrderId;
        // if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            // store the data in the session object
            Session["OrderId"] = OrderId;
            // redirect to edit page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else     // if no record has been selected
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of order collection
        clsOrderCollection AnOrder = new clsOrderCollection();
        // retrieve the value of order name from the presentation layer
        AnOrder.ReportByOrderName(txtOrderNameFilter.Text);
        // set the data source to list of orders in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        // set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        // set the data field to display
        lstOrderList.DataTextField = "OrderName";
        // bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of order collection
        clsOrderCollection AnOrder = new clsOrderCollection();
        // retrieve the value of order name from the presentation layer
        AnOrder.ReportByOrderName("");
        // clear any existing filter to tidy up the interface
        txtOrderNameFilter.Text = "";
        // set the data source to list of orders in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        // set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        // set the data field to display
        lstOrderList.DataTextField = "OrderName";
        // bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        // redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}