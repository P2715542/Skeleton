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
        //if this is the first time the page is displayed
        
        if (IsPostBack == false)
        {
            
            
                //update the list box
                DisplayStaff();
            
        }
        clsStaffUser AnUser = new clsStaffUser();
        AnUser = (clsStaffUser)Session["AnUser"];
        lblsesh.Text = "Logged in as: " + AnUser.UserName;
    }

    void DisplayStaff()
    {
        //create an instance of staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source list of staff in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data fied to display
        lstStaffList.DataTextField = "Email";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to Edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1 )
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else 
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection AnStaff = new clsStaffCollection();
        AnStaff.ReportByLastName(txtLN.Text);
        lstStaffList.DataSource = AnStaff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "LastName";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection AnStaff = new clsStaffCollection();
        AnStaff.ReportByLastName("");
        txtLN.Text = "";
        lstStaffList.DataSource = AnStaff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "Email";
        lstStaffList.DataBind();
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

}