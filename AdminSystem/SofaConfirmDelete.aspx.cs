using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SofaId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SofaId = Convert.ToInt32(Session["SofaId"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        clsSofaCollection SofaCollection = new clsSofaCollection();
        SofaCollection.Delete();
        Response.Redirect("SofaList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SofaList.aspx");
    }
}