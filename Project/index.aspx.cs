using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    string con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = ConfigurationManager.ConnectionStrings["Hams"].ConnectionString;
        loadData();
    }

    private void loadData()
    {
        load_basic();
        load_slider();
        load_navigation();
        load_About();
        load_Section_3();
        load_Gallery();
        load_section4();
        load_contact_us();
    }
    private void load_basic()
    {
        Model model = new Model();
        LoadData load = model.LoadDataList(con);
        String strPathAndQuery = HttpContext.Current.Request.Url.PathAndQuery;
        String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(strPathAndQuery, "/");

        imgLogo.Src = "Images/" + load.Logo;

        imgFav_1.Attributes.Add("href", strUrl + "Images/" + load.FavIcon);
        imgFav_2.Attributes.Add("href", strUrl + "Images/" + load.FavIcon);

        txtTittle.InnerHtml = load.Tittle;
        footerlabel.InnerHtml = load.Tittle;
        txtFBtittle.Attributes.Add("content", load.Tittle);
        txtTWITTERtittle.Attributes.Add("content", load.Tittle);

        txtKeyword.Attributes.Add("content", load.Keywords);

        txtTWITTERDecsription.Attributes.Add("content", load.Description);
        txtFBDecsription.Attributes.Add("content", load.Description);
        txtDecsription.Attributes.Add("content", load.Description);

        imgFBSocial.Attributes.Add("content", strUrl + "Images/" + load.SocialImage);
        imgTwitterSocial.Attributes.Add("content", strUrl + "Images/" + load.SocialImage);

        txtFbUrl.Attributes.Add("content", strUrl);

        //Colors

        string Bg1 = load.BackgroundColor1.Trim();
        string Bg2 = load.BackgroundColor2.Trim();
        string Bg3 = load.BackgroundColor3.Trim();
        string text1 = load.TextColor1.Trim();
        string text2 = load.TextColor2.Trim();
        string text3 = load.TextColor3.Trim();
        string text4 = load.TextColor4.Trim();
        string text5 = load.TextColor5.Trim();

        ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                    @"$(document).ready(function () {
                        $('.custom-dark').css('background-color', '" + Bg1 + @"');
                        $('.custom-contact').css('background-color', '" + Bg2 + @"');
                        $('.custom-back-to-top').css('background-color', '" + Bg3 + @"');
                        $('.custom-text-light').css('color', '" + text1 + @"');
                        $('.custom-text-contact').css('color', '" + text2 + @"');
                        $('.custom-text-slider').css('color', '" + text3 + @"');
                        $('.custom-text-footer').css('color', '" + text4 + @"');
                        $('.custom-back-to-top-text').css('color', '" + text5 + @"');
                    })"
        , true);

    }
    private void load_slider()
    {
        Model model = new Model();

        Slider.DataSource = null;
        Slider.DataSource = model.LoadSliderDataList(con);
        Slider.DataBind();
    }
    private void load_navigation()
    {
        Model model = new Model();
        LoadNavigation load = model.LoadNavigationDataList(con);
        txtnav1.InnerHtml = load.nav_1;
        txtnav2.InnerHtml = load.nav_2;
        txtnav3.InnerHtml = load.nav_3;
        txtnav4.InnerHtml = load.nav_4;
        txtnav5.InnerHtml = load.nav_5;
        txtnav6.InnerHtml = load.nav_6;
        txtSection_3_heading.InnerHtml = load.nav_4;
        txtGalleryHeading.InnerHtml = load.nav_3;
        txtSection4Heading.InnerHtml = load.nav_5;
        txtContactusHeading.InnerHtml = load.nav_6;
    }
    private void load_About()
    {
        Model model = new Model();
        LoadAbout load = model.LoadAboutDataList(con);
        txtAboutHeading.InnerHtml = load.heading.Trim();
        txtAboutSection.InnerHtml = load.Description.Trim();
    }
    private void load_Section_3()
    {
        Model model = new Model();

        lvtSection3.DataSource = null;
        lvtSection3.DataSource = model.LoadSection3DataList(con);
        lvtSection3.DataBind();
    }
    private void load_Gallery()
    {
        Model model = new Model();

        lvGallery.DataSource = null;
        lvGallery.DataSource = model.LoadGalleryDataList(con);
        lvGallery.DataBind();
    }
    private void load_section4()
    {
        Model model = new Model();
        LoadSection4 load = model.LoadSection4DataList(con);
        txtSection4Section.InnerHtml = load.Description.Trim();
    }
    private void load_contact_us()
    {
        Model model = new Model();
        LoadContact load = model.LoadContactDataList(con);
        txtContactAddress.InnerHtml = load.Address.Trim();
        txtContactEmail.InnerHtml = load.Email.Trim();
        txtContactno.InnerHtml = load.Contact.Trim();
        iframeMap.Src = load.Map.Trim();

        Links load1 = model.LoadContactLinkDataList(con);
        lnkFb.Attributes.Add("href",load1.Fb.Trim());
        lnkTwitter.Attributes.Add("href",load1.Twitter.Trim());
        lnkYoutube.Attributes.Add("href",load1.Youtube.Trim());

    }




    protected void btnsubmit_ServerClick(object sender, EventArgs e)
    {
        if (txtfullname.Value.Length != 0 && txtcontact.Value.Length != 0 && txtemail.Value.Length != 0 && txtmessage.Value.Length != 0)
        {

            string site_name = txtTittle.InnerText.ToString();
            string send_email = txtContactEmail.InnerText.ToString();

            try
            {

                const string SERVER = "bolo.com.pk";
                MailMessage oMail = new System.Web.Mail.MailMessage();
                oMail.From = "hgbanquet@bolo.com.pk";
                oMail.To = "hgbanquet@bolo.com.pk";
                oMail.Subject = "Contact Request By " + txtfullname.Value.Trim();
                oMail.BodyFormat = MailFormat.Html; // enumeration
                oMail.Priority = MailPriority.High; // enumeration
                oMail.Body = "<b>Full Name :" + txtfullname.Value.Trim() + "<br/>"
                             + "<b>Sender Email :" + txtemail.Value.Trim() + "<br/>" +
                             "<b>Sender ContactNo :" + txtcontact.Value.Trim() + "<br/>" +
                             "<b>Message :" + txtmessage.Value.Trim() + "<br/>";
                SmtpMail.SmtpServer = SERVER;
                SmtpMail.Send(oMail);
                oMail = null;   // free up resources
                Response.Write("<script>alert('Submit Successfully')</script>");
                Response.Write("<script> window.location = 'index.aspx'; </script>");

            }
            catch (Exception)
            {
                Response.Write("<script>alert('Error')</script>");

            }
        }
    }
}