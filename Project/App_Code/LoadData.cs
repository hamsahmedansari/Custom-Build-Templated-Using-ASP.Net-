using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoadData
/// </summary>
public class LoadData
{
    #region "BasicInfo"
    protected string strLogo;
    protected string strFav;
    protected string strTittle;
    protected string strDescription;
    protected string strKeywords;
    protected string strSocialImage;
    protected string strBackgroundColor1;
    protected string strBackgroundColor2;
    protected string strBackgroundColor3;
    protected string strTextColor1;
    protected string strTextColor2;
    protected string strTextColor3;
    protected string strTextColor4;
    protected string strTextColor5;
    #endregion

    #region "BasicInfoDec"
    public string Tittle
    {
        get { return this.strTittle; }
        set { this.strTittle = value; }
    }
    public string Description
    {
        get { return this.strDescription; }
        set { this.strDescription = value; }
    }
    public string Keywords
    {
        get { return this.strKeywords; }
        set { this.strKeywords = value; }
    }
    public string SocialImage
    {
        get { return this.strSocialImage; }
        set { this.strSocialImage = value; }
    }
    public string Logo
    {
        get { return this.strLogo; }
        set { this.strLogo = value; }
    }
    public string FavIcon
    {
        get { return this.strFav; }
        set { this.strFav = value; }
    }
    public string BackgroundColor1
    {
        get { return this.strBackgroundColor1; }
        set { this.strBackgroundColor1 = value; }
    }
    public string BackgroundColor2
    {
        get { return this.strBackgroundColor2; }
        set { this.strBackgroundColor2 = value; }
    }
    public string BackgroundColor3
    {
        get { return this.strBackgroundColor3; }
        set { this.strBackgroundColor3 = value; }
    }
    public string TextColor1
    {
        get { return this.strTextColor1; }
        set { this.strTextColor1 = value; }
    }
    public string TextColor2
    {
        get { return this.strTextColor2; }
        set { this.strTextColor2 = value; }
    }
    public string TextColor3
    {
        get { return this.strTextColor3; }
        set { this.strTextColor3 = value; }
    }
    public string TextColor4
    {
        get { return this.strTextColor4; }
        set { this.strTextColor4 = value; }
    }
    public string TextColor5
    {
        get { return this.strTextColor5; }
        set { this.strTextColor5 = value; }
    }
    #endregion

    public LoadData()
    {
        strLogo = "";
        strFav = "";
        strTittle = "";
        strDescription = "";
        strKeywords = "";
        strSocialImage = "";
        strBackgroundColor1 = "";
        strBackgroundColor2 = "";
        strBackgroundColor3 = "";
        strTextColor1 = "";
        strTextColor2 = "";
        strTextColor3 = "";
        strTextColor4 = "";
        strTextColor5 = "";
    }
}

