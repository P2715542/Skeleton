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
        clsSofa ASofa = new clsSofa();
        ASofa = (clsSofa)Session["ASofa"];
        Response.Write(ASofa.SofaId);

        ASofa = (clsSofa)Session["ASofa"];
        Response.Write(ASofa.SofaDescription);

        ASofa = (clsSofa)Session["ASofa"];
        Response.Write(ASofa.Colour);

        ASofa = (clsSofa)Session["ASofa"];
        Response.Write(ASofa.SupplierId);

        ASofa = (clsSofa)Session["ASofa"];
        Response.Write(ASofa.Price);

        ASofa = (clsSofa)Session["ASofa"];
        Response.Write(ASofa.Available);

        ASofa = (clsSofa)Session["ASofa"];
        Response.Write(ASofa.DateAdded);
    }
}