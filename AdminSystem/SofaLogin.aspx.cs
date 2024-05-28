using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SofaLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        clsSofaUser AUser = new clsSofaUser();
        string UserName = txtUsername.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AUser.FindUser(UserName, Password);
        if (txtUsername.Text == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password";
        }

        else if (Found == true)
        {
            Response.Redirect("SofaList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again";
        }
    }
}