using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    Int32 SofaId;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["SofaId"] = -1;
        Response.Redirect("SofaDataEntry.aspx");
    }


    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 SofaId;
        if (lstSofaList.SelectedIndex != -1)
        {
            SofaId = Convert.ToInt32(lstSofaList.SelectedValue);
            Session["SofaId"] = SofaId;
            Response.Redirect("SofaDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["SofaId"] = -1;
        Response.Redirect("SofaDataEntry.aspx");
    }
}