using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySofas();
        }
    }

    void DisplaySofas()
    {
        clsSofaCollection Sofas = new clsSofaCollection();
        lstSofaList.DataSource = Sofas.SofaList;
        lstSofaList.DataValueField = "SofaId";
        lstSofaList.DataTextField = "SofaDescription";
        lstSofaList.DataBind();
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

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 SofaId;
        if (lstSofaList.SelectedIndex != -1)
        {
            SofaId = Convert.ToInt32(lstSofaList.SelectedValue);
            Session["SofaId"] = SofaId;
            Response.Redirect("SofaConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void BtnApplyFilter_Click(object sender, EventArgs e)
    {
        clsSofaCollection ASofa = new clsSofaCollection();
        ASofa.ReportByDescription(txtEnteredColour.Text);
        lstSofaList.DataSource = ASofa.SofaList;
        lstSofaList.DataValueField = "SofaId";
        lstSofaList.DataTextField = "Description";
        lstSofaList.DataBind();
    }

    protected void BtnClearFilter_Click(object sender, EventArgs e)
    {
        clsSofaCollection ASofa = new clsSofaCollection();
        ASofa.ReportByDescription("");
        txtEnteredColour.Text = "";
        lstSofaList.DataSource = ASofa.SofaList;
        lstSofaList.DataValueField = "SofaId";
        lstSofaList.DataTextField = "Colour";
        lstSofaList.DataBind();

    }
}