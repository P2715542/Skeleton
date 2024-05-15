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

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

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
            ASofa.SofaDescription = SofaDescription;
            ASofa.Colour = SofaColour;
            ASofa.SupplierId = Convert.ToInt32(SupplierId);
            ASofa.Price = Convert.ToDecimal(Price);
            ASofa.DateAdded = Convert.ToDateTime(DateAdded);
            Session["ASofa"] = ASofa;
            Response.Redirect("SofaViewer.aspx");
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
}