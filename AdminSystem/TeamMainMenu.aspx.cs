using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        // redirect the user to the orders login page
        Response.Redirect("OrdersLogin.aspx");
    }

    protected void btnSofas_Click(object sender, EventArgs e)
    {
        // redirect the user to the sofa supplies login page
        Response.Redirect("SofaLogin.aspx");
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        // redirect the user to the customers login page
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        //redirect the user to the staff login page
        Response.Redirect("StaffLogin.aspx");
    }
}