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
}