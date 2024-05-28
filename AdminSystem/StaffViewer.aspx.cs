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
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //displays the staff ID for this entry
        Response.Write(AnStaff.StaffId);
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //displays the staff ID for this entry
        Response.Write(AnStaff.FirstName);
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //displays the staff ID for this entry
        Response.Write(AnStaff.LastName);
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //displays the staff ID for this entry
        Response.Write(AnStaff.Email);
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //displays the staff ID for this entry
        Response.Write(AnStaff.DoB);
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //displays the staff ID for this entry
        Response.Write(AnStaff.Active);
    }
}