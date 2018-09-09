using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class admin_Slider : System.Web.UI.Page
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

        listSlider.DataSource = null;
        listSlider.DataSource = model.LoadSliderDataList(con);
        listSlider.DataBind();
    }

    private string UploadLogo(FileUpload file)
    {
        string strExtension;
        string strNewFileName;
        string strFileName = file.FileName;

        strExtension = Path.GetExtension(strFileName);
        strNewFileName = string.Format("{0}{1}{2}", "Slider", DateTime.Now.ToString("HHmmssffffff"), strExtension);

        file.PostedFile.SaveAs(Server.MapPath("~/Images/" + strNewFileName));
        string path = String.Format("~/Images/{0}", strNewFileName);

        return strNewFileName;
    }

    protected void listSlider_ItemEditing(object sender, ListViewEditEventArgs e)
    {
        TextBox Heading = (TextBox)listSlider.Items[e.NewEditIndex].FindControl("txtSliderHeading");
        TextBox Decption = (TextBox)listSlider.Items[e.NewEditIndex].FindControl("txtSliderDescription");
        Label id = (Label)listSlider.Items[e.NewEditIndex].FindControl("txtID");
        FileUpload img = (FileUpload)listSlider.Items[e.NewEditIndex].FindControl("txtSlider");
        HiddenField slider_db = (HiddenField)listSlider.Items[e.NewEditIndex].FindControl("txtsliderimghidden");

        string uploadimg;
        if (img.FileName.Length!=0)
        {
            uploadimg = UploadLogo(img);
        }
        else
        {
            uploadimg = slider_db.Value;
        }

        if (Heading.Text.Length!=0 && Decption.Text.Length!=0)
        {
            Model model = new Model();
            if (model.AdminUpdateSlider(con,id.Text,uploadimg,Heading.Text,Decption.Text))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                        "alert('successfully Updated')", true);

            LoadCompleteList();
        }


        //SqlConnection sqlConn = new SqlConnection(con);
        //sqlConn.Open();
        //SqlCommand sqlCom = new SqlCommand("UPDATE tblSlider SET strSliderHeading='" + Heading.Text + "' WHERE id = 1", sqlConn);
        //sqlCom.ExecuteNonQuery();
    }
}