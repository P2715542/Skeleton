using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // variable to store the primary key value of the record to be deleted
    Int32 OrderId;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the order to be deleted from the session object
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create collection class instance
        clsOrderCollection OrderBook = new clsOrderCollection();
        // find the record to delete 
        OrderBook.ThisOrder.Find(OrderId);
        // find the record to delete
        OrderBook.Delete();
        // redirect back to main page
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // redirect back to main page
        Response.Redirect("OrdersList.aspx");
    }
}