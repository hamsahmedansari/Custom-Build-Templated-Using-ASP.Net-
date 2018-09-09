using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Gallery : System.Web.UI.Page
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

        gallery.DataSource = null;
        gallery.DataSource = model.LoadGalleryDataList(con);
        gallery.DataBind();

        pnlAddNew.Visible = false;
        pnlupdate.Visible = true;
    }

    protected void gallery_ItemEditing(object sender, ListViewEditEventArgs e)
    {
        FileUpload img = (FileUpload)gallery.Items[e.NewEditIndex].FindControl("upload_image");
        HiddenField id = (HiddenField)gallery.Items[e.NewEditIndex].FindControl("txtID");


        string uploadimg;
        if (img.FileName.Length != 0)
        {
            uploadimg = UploadLogo(img);
            Model model = new Model();
            if (model.AdminUpdateGallery(con, id.Value, uploadimg))
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
    private string UploadLogo(FileUpload file)
    {
        string strExtension;
        string strNewFileName;
        string strFileName = file.FileName;

        strExtension = Path.GetExtension(strFileName);
        strNewFileName = string.Format("{0}{1}{2}", "Gallery", DateTime.Now.ToString("HHmmssffffff"), strExtension);

        file.PostedFile.SaveAs(Server.MapPath("~/Images/" + strNewFileName));
        string path = String.Format("~/Images/{0}", strNewFileName);

        return strNewFileName;
    }

    protected void addnew_ServerClick(object sender, EventArgs e)
    {
        if (Add_upload_image.FileName.Length!=0)
        {
            string  uploadimg = UploadLogo(Add_upload_image);
            Model model = new Model();
            if (model.AdminAddGallery(con,uploadimg))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                        "alert('successfully Updated')", true);

            LoadCompleteList();
        }
    }

    protected void btnaddnew_ServerClick(object sender, EventArgs e)
    {
        pnlupdate.Visible = false;
        pnlAddNew.Visible = true;
    }

    protected void btnUpdate_ServerClick(object sender, EventArgs e)
    {
        pnlAddNew.Visible = false;
        pnlupdate.Visible = true;
    }




    protected void gallery_ItemDeleting(object sender, ListViewDeleteEventArgs e)
    {
        
        HiddenField id = (HiddenField)gallery.Items[e.ItemIndex].FindControl("txtID");
        
            Model model = new Model();
            if (model.AdminDeletingGallery(con, id.Value))
            {
                Response.Write("<script> alert('successfully Updated')</script>");
            }
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                        "alert('successfully Deleted')", true);

            LoadCompleteList();
        
        
    }
}