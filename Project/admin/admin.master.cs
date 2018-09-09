using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["LoGiN"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                LoadCompleteOfNavigationList();
            }
        }
        else
        {
            LoadCompleteOfNavigationList();
        }
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session["LoGiN"] = null;
        Response.Redirect("login");

    }
    private void LoadCompleteOfNavigationList()
    {
        string con = ConfigurationManager.ConnectionStrings["Hams"].ConnectionString;
        
        Model model = new Model();
        LoadNavigation load = model.LoadNavigationDataList(con);

        nvabout.Text = load.nav_2.Trim();
        nvsection3.Text = load.nav_4.Trim();
        nvsection4.Text = load.nav_5.Trim();

    }
}
