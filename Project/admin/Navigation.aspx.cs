using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Navigation : System.Web.UI.Page
{
    string con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = ConfigurationManager.ConnectionStrings["Hams"].ConnectionString;
        if (!IsPostBack)
        {
            LoadCompleteList();
        }
    }
    private void LoadCompleteList()
    {
        Model model = new Model();
        LoadNavigation load = model.LoadNavigationDataList(con);

        txtNav1.Value = load.nav_1.Trim();
        txtNav2.Value = load.nav_2.Trim();
        txtNav3.Value = load.nav_3.Trim();
        txtNav4.Value = load.nav_4.Trim();
        txtNav5.Value = load.nav_5.Trim();
        txtNav6.Value = load.nav_6.Trim();

    }

    protected void btnLogo_ServerClick(object sender, EventArgs e)
    {
        if (txtNav1.Value.Length != 0 && txtNav2.Value.Length != 0 && txtNav3.Value.Length != 0 && txtNav4.Value.Length != 0 && txtNav5.Value.Length != 0 && txtNav6.Value.Length != 0)
        {
            Model model = new Model();
            if (model.AdminNavigationUpdate(con,txtNav1.Value,txtNav2.Value,txtNav3.Value,txtNav4.Value,txtNav5.Value,txtNav6.Value))
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                                         "alert('successfully Updated')", true);
            }
            LoadCompleteList();
        }
    }
}