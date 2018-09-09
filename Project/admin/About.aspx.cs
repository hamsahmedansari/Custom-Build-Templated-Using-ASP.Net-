using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_About : System.Web.UI.Page
{
    string con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = ConfigurationManager.ConnectionStrings["Hams"].ConnectionString;
        if (!IsPostBack)
        {
            LoadHeader();
            LoadCompleteData();
        }
    }

    private void LoadHeader()
    {
        Model model = new Model();
        LoadNavigation load = model.LoadNavigationDataList(con);

        header.Text = load.nav_2.Trim();

        Label header1 = (Label)Master.FindControl("header_from_master");
        header1.Text = load.nav_2.Trim();
        txtAboutHeading.Value = load.nav_2.Trim();
    }
    private void LoadCompleteData()
    {
        Model model = new Model();
        LoadAbout load = model.LoadAboutDataList(con);
        txtAboutDescription.Value = load.Description.Trim();

    }

    protected void btnLogo_ServerClick(object sender, EventArgs e)
    {
        if (txtAboutHeading.Value.Length != 0 && txtAboutDescription.Value.Length != 0)
        {
            Model model = new Model();
            if (model.UpdateAboutDataList(con,txtAboutHeading.Value,txtAboutDescription.Value.Trim()))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }
            //Response.Write("<script> alert('successfully Updated')</script>");
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                         "alert('successfully Updated')", true);


            LoadCompleteData();
        }
    }
}