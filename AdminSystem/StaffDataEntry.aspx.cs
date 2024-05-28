using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        string StaffId = txtStaffId.Text;
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Email = txtEmail.Text;
        string Role  = txtRole.Text;
        string DoB = txtDoB.Text;
        string Active  = boxActive.Text;
        string Error = "";
        Error = AnStaff.Valid(FirstName, LastName, Email, Role, DoB);
        if (Error == "")
        {
            //get the staff id
            AnStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
            //get the first name
            AnStaff.FirstName = txtFirstName.Text;
            //get the last name
            AnStaff.LastName = txtLastName.Text;
            //get the email
            AnStaff.Email = txtEmail.Text;
            //get the date of birth
            AnStaff.DoB = Convert.ToDateTime(DoB);
            //get the active check box
            AnStaff.Active = boxActive.Checked;
            Session["AnStaff"] = AnStaff;
            //navigate to view page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}