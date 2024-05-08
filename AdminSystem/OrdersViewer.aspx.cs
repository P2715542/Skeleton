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
        // create new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        // get the dtaa from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        // display the order id for the entry
        Response.Write(AnOrder.OrderId);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderName);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.SofaId);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.CustomerId);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.StaffId);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.DateOrdered);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderDispatched);
    }
}