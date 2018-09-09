using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Basic_Info : System.Web.UI.Page
{
    string con;
    string logo, favicon, social;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = ConfigurationManager.ConnectionStrings["Hams"].ConnectionString;
        if (!IsPostBack)
        {
            LoadCompleteList();
        }
    }
    protected void btnLogo_ServerClick(object sender, EventArgs e)
    {

        if (txtlogo.Value.Length != 0 || txtFavionicon.Value.Length != 0)
        {
            string logo1, fav1;
            if (txtlogo.Value.Length != 0)
            {
                logo1 = UploadLogo();
            }
            else
            {
                logo1 = Session["imgLogo"].ToString();
            }
            if (txtFavionicon.Value.Length != 0)
            {
                fav1 = UploadFavicon();
            }
            else
            {
                fav1 = Session["imgFav"].ToString();
            }

            Model model = new Model();
            if (model.AdminLogoUpdate(con, logo1, fav1))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                        "alert('successfully Updated')", true);

            LoadCompleteList();

        }
        else
        {
            Response.Write("<script> alert('Error')</script>");

        }

    }
    private string UploadLogo()
    {
        string strExtension;
        string strNewFileName;
        string strFileName = txtlogo.Value;

        strExtension = Path.GetExtension(strFileName);
        strNewFileName = string.Format("{0}{1}{2}", "LOGO", DateTime.Now.ToString("HHmmssffffff"), strExtension);

        txtlogo.PostedFile.SaveAs(Server.MapPath("~/Images/" + strNewFileName));
        string path = String.Format("~/Images/{0}", strNewFileName);

        return strNewFileName;
    }
    private string UploadFavicon()
    {
        string strExtension;
        string strNewFileName;
        string strFileName = txtFavionicon.Value;

        strExtension = Path.GetExtension(strFileName);
        strNewFileName = string.Format("{0}{1}{2}", "Favionicon", DateTime.Now.ToString("HHmmssffffff"), strExtension);

        txtFavionicon.PostedFile.SaveAs(Server.MapPath("~/Images/" + strNewFileName));
        string path = String.Format("~/Images/{0}", strNewFileName);

        return strNewFileName;
    }
    private string UploadSocialImage()
    {
        string strExtension;
        string strNewFileName;
        string strFileName = txtSocialImage.Value;

        strExtension = Path.GetExtension(strFileName);
        strNewFileName = string.Format("{0}{1}{2}", "SocialImage", DateTime.Now.ToString("HHmmssffffff"), strExtension);

        txtSocialImage.PostedFile.SaveAs(Server.MapPath("~/Images/" + strNewFileName));
        string path = String.Format("~/Images/{0}", strNewFileName);

        return strNewFileName;
    }
    protected void btnInfo_ServerClick(object sender, EventArgs e)
    {
        string socialimg1;
        if (txtSocialImage.Value.Length != 0)
        {
            socialimg1 = UploadSocialImage();
        }
        else
        {
            socialimg1 = Session["imgSocial"].ToString();
        }
        if (txtTittle.Value.Length != 0 && txtDescription.Value.Length != 0 && txtKeywords.Value.Length != 0)
        {
            Model model = new Model();
            if (model.AdminInfoUpdate(con, txtTittle.Value, txtDescription.Value, txtKeywords.Value, socialimg1))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }

            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                       "alert('successfully Updated')", true);

            LoadCompleteList();
        }
        else
        {
            Response.Write("<script> alert('Error')</script>");

        }
    }

    private void LoadCompleteList()
    {
        Model model = new Model();
        LoadData load = model.LoadDataList(con);
        logo = load.Logo;
        favicon = load.FavIcon;
        social = load.SocialImage;
        txtTittle.Value = load.Tittle;
        txtDescription.Value = load.Description;
        txtKeywords.Value = load.Keywords;
        txtbackgroundColor1.Value = load.BackgroundColor1;
        txtbackgroundColor2.Value = load.BackgroundColor2;
        txtbackgroundColor3.Value = load.BackgroundColor3;
        txtTextColor1.Value = load.TextColor1;
        txtTextColor2.Value = load.TextColor2;
        txtTextColor3.Value = load.TextColor3;
        txtTextColor4.Value = load.TextColor4;
        txtTextColor5.Value = load.TextColor5;

        imgLogo.Src = "../Images/" + logo;
        imgFav.Src = "../Images/" + favicon;
        imgSocial.Src = "../Images/" + social;

        Session["imgLogo"] = logo;
        Session["imgFav"] = favicon;
        Session["imgSocial"] = social;
    }

    protected void btnBackgroundColor_ServerClick(object sender, EventArgs e)
    {
        if (txtbackgroundColor1.Value.Length != 0 && txtbackgroundColor2.Value.Length != 0 && txtbackgroundColor3.Value.Length != 0)
        {
            Model model = new Model();
            if (model.AdminBackGroundColor(con, txtbackgroundColor1.Value, txtbackgroundColor2.Value, txtbackgroundColor3.Value))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }

            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                       "alert('successfully Updated')", true);

            LoadCompleteList();
        }
        else
        {
            Response.Write("<script> alert('Error')</script>");

        }
    }

    protected void btnTextColor_ServerClick(object sender, EventArgs e)
    {

        if (txtTextColor1.Value.Length != 0 && txtTextColor2.Value.Length != 0 && txtTextColor3.Value.Length != 0 && txtTextColor4.Value.Length != 0 && txtTextColor5.Value.Length != 0)
        {
            Model model = new Model();
            if (model.AdminTextColor(con, txtTextColor1.Value, txtTextColor2.Value, txtTextColor3.Value, txtTextColor4.Value, txtTextColor5.Value))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }

            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                        "alert('successfully Updated')", true);

            LoadCompleteList();
        }
        else
        {
            Response.Write("<script> alert('Error')</script>");

        }
    }
}