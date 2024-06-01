using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SofaId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SofaId = Convert.ToInt32(Session["SofaId"]);
        if (IsPostBack == false)
        {
            if (SofaId != -1)
            {
                DisplaySofa();
            }
        }
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSofa ASofa = new clsSofa();
        string SofaDescription = txtSofaDescription.Text;
        string SofaColour = txtSofaColour.Text;
        string SupplierId = txtSupplierId.Text;
        string Price = txtPrice.Text;
        string Available = chkAvailable.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = ASofa.Valid(SofaDescription, SofaColour, SupplierId, Price, DateAdded);
        if (Error == "")
        {
            ASofa.SofaId = SofaId;
            ASofa.SofaDescription = SofaDescription;
            ASofa.Colour = SofaColour;
            ASofa.SupplierId = Convert.ToInt32(SupplierId);
            ASofa.Price = Convert.ToDecimal(Price);
            ASofa.DateAdded = Convert.ToDateTime(DateAdded);
            ASofa.Available = chkAvailable.Checked;
            clsSofaCollection SofaList = new clsSofaCollection();
            if (SofaId == -1)
            {
                SofaList.ThisSofa = ASofa;
                SofaList.Add();
            }

            else
            {
                SofaList.ThisSofa.Find(SofaId);
                SofaList.ThisSofa = ASofa;
                SofaList.Update();
            }
            
            Response.Redirect("SofaList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        clsSofa ASofa = new clsSofa();
        Int32 SofaId;
        Boolean Found = false;
        SofaId = Convert.ToInt32(txtSofaId.Text);
        Found = ASofa.Find(SofaId);
        if (Found == true)
        {
            txtSofaDescription.Text = ASofa.SofaDescription;
            txtSofaColour.Text = ASofa.Colour;
            txtSupplierId.Text = ASofa.SupplierId.ToString();
            txtPrice.Text = ASofa.Price.ToString();
            chkAvailable.Checked = ASofa.Available;
            txtDateAdded.Text = ASofa.DateAdded.ToString();
        }
    }


    void DisplaySofa()
    {
        clsSofaCollection SofaCollection = new clsSofaCollection();
        SofaCollection.ThisSofa.Find(SofaId);
        txtSofaId.Text = SofaCollection.ThisSofa.SofaId.ToString();
        txtSofaDescription.Text = SofaCollection.ThisSofa.SofaDescription.ToString();
        txtSofaColour.Text = SofaCollection.ThisSofa.Colour.ToString();
        txtSupplierId.Text = SofaCollection.ThisSofa.SupplierId.ToString();
        txtPrice.Text = SofaCollection.ThisSofa.Price.ToString();
        chkAvailable.Checked = SofaCollection.ThisSofa.Available;
        txtDateAdded.Text = SofaCollection.ThisSofa.DateAdded.ToString();
    }

   





    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SofaList.aspx");
    }

   
}