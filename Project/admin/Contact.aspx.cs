using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Contact : System.Web.UI.Page
{
    string con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = ConfigurationManager.ConnectionStrings["Hams"].ConnectionString;
        if (!IsPostBack)
        {

            LoadCompleteData();
        }
    }
    private void LoadCompleteData()
    {
        Model model = new Model();
        LoadContact load = model.LoadContactDataList(con);
        txtAddress.Value = load.Address.Trim();
        txtContact.Value = load.Contact.Trim();
        txtEmail.Value = load.Email.Trim();
        txtMap.Value = load.Map.Trim();
        
        Links load1 = model.LoadContactLinkDataList(con);
        txtLinkFb.Value = load1.Fb.Trim();
        txtLinkTwitter.Value = load1.Twitter.Trim();
        txtLinkYoutube.Value = load1.Youtube.Trim();
    }

    protected void btnLogo_ServerClick(object sender, EventArgs e)
    {
        if (txtAddress.Value.Length != 0 && txtContact.Value.Length != 0 && txtEmail.Value.Length != 0 && txtMap.Value.Length != 0 && txtLinkFb.Value.Length !=0 && txtLinkTwitter.Value.Length !=0 && txtLinkYoutube.Value.Length !=0)
        {
            Model model = new Model();
            if (model.UpdateContactDataList(con,txtEmail.Value.Trim(),txtContact.Value.Trim(),txtAddress.Value.Trim(),txtMap.Value.Trim()))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }
            if (model.UpdateContactLinksDataList(con,txtLinkFb.Value.Trim(),txtLinkTwitter.Value.Trim(),txtLinkYoutube.Value.Trim()))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                        "alert('successfully Updated')", true);

            LoadCompleteData();
        }
    }
}