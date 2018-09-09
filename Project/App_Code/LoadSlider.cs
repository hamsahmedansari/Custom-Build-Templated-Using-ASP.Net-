using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoadSlider
/// </summary>
public class LoadSlider
{

    #region "Slider"
    protected string strImg;
    protected string strHeading;
    protected string strDec;
    #endregion

    #region "SliderDec"
    public string Image
    {
        get { return this.strImg; }
        set { this.strImg = value; }
    }
    public string Description
    {
        get { return this.strDec; }
        set { this.strDec = value; }
    }
    public string Heading
    {
        get { return this.strHeading; }
        set { this.strHeading = value; }
    }
    #endregion
    public LoadSlider()
    {
        strImg = "";
        strHeading = "";
        strDec = "";
    }
}