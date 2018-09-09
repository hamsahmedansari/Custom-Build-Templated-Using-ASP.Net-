using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_login : System.Web.UI.Page
{
    string con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = ConfigurationManager.ConnectionStrings["Hams"].ConnectionString;
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtemail.Value !="" && txtpassword.Value != "")
        {
            Model model = new Model();
            if (model.AdminLogin(con, txtemail.Value, txtpassword.Value))
            {
                Session["LoGiN"] = "SucEssFullYLO78";
                Response.Redirect("Basic-Info");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                         "alert('invalid username or password')", true);
                
                //Response.Write("<script> alert('invalid username or password')</script>");
            }
        }
        else
        {

            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                     "alert('Please Fill Form')", true);
            //Response.Write("<script> alert('Please Fill Form')</script>");
        }
    }
}
