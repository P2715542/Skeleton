using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrders
        clsOrder AnOrder = new clsOrder();
        // capture the order Id
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrder.OrderName = txtOrderName.Text;
        AnOrder.SofaId = Convert.ToInt32(txtSofaId.Text);
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnOrder.StaffId = Convert.ToInt32(txtStaffId.Text);
        AnOrder.DateOrdered = Convert.ToDateTime(DateTime.Now);
        AnOrder.OrderDispatched = chkOrderDispatched.Checked;

        // store the order id in the session object
        Session["AnOrder"] = AnOrder;
        // Navigate to View Page
        Response.Redirect("OrdersViewer.aspx");
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
}