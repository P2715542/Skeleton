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
        ASofa.Colour = txtSofaColour.Text;

        ASofa.SofaId = Convert.ToInt32(txtSofaId.Text);

        ASofa.SofaDescription = txtSofaDescription.Text;

        ASofa.SupplierId = Convert.ToInt32(txtSupplierId.Text);

        ASofa.Price = Convert.ToDecimal(txtPrice.Text);

        ASofa.Available = chkAvailable.Checked;

        ASofa.DateAdded = Convert.ToDateTime(DateTime.Now);

        Session["ASofa"] = ASofa;
        Response.Redirect("SofaViewer.aspx");
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