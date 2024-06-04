using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            if (StaffId != -1)
            {
                DisplayStaffs();
            }
        }
    }
    void DisplayStaffs()
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ThisStaff.Find(StaffId);
        txtStaffId.Text = Staffs.ThisStaff.StaffId.ToString();
        txtFirstName.Text = Staffs.ThisStaff.FirstName.ToString();
        txtLastName.Text = Staffs.ThisStaff.LastName.ToString();
        txtEmail.Text = Staffs.ThisStaff.Email.ToString();
        txtRole.Text = Staffs.ThisStaff.Role.ToString();
        txtDoB.Text = Staffs.ThisStaff.DoB.ToString();
        boxActive.Checked = Staffs.ThisStaff.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        Int32 StaffId = Convert.ToInt32(txtStaffId.Text);
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
            //AnStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
            //get the first name
            AnStaff.StaffId = StaffId;
            AnStaff.FirstName = txtFirstName.Text;
            //get the last name
            AnStaff.LastName = txtLastName.Text;
            //get the email
            AnStaff.Email = txtEmail.Text;
            //get the date of birth
            AnStaff.DoB = Convert.ToDateTime(DoB);
            //get the role
            AnStaff.Role = txtRole.Text;
            //get the active check box
            AnStaff.Active = boxActive.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffId == -1)
            {

            
            StaffList.ThisStaff = AnStaff;
            StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = AnStaff.Find(StaffId);
        if (Found == true)
        {
            //display the values
            txtStaffId.Text = StaffId.ToString();
            txtFirstName.Text = AnStaff.FirstName;
            txtLastName.Text = AnStaff.LastName;
            txtEmail.Text = AnStaff.Email;
            txtDoB.Text = AnStaff.DoB.ToString();
            txtRole.Text = AnStaff.Role;
            boxActive.Checked = AnStaff.Active;
        }
    }
}