using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Links
/// </summary>
public class Links
{
    #region "Links"
    protected string stFb;
    protected string stTwitter;
    protected string stYoutube;
    #endregion

    #region "Links"
    public string Fb
    {
        get { return this.stFb; }
        set { this.stFb = value; }
    }
    public string Twitter
    {
        get { return this.stTwitter; }
        set { this.stTwitter = value; }
    }
    public string Youtube
    {
        get { return this.stYoutube; }
        set { this.stYoutube = value; }
    }
    #endregion
    public Links()
    {

        stFb = "";
        stTwitter = "";
        stYoutube = "";
    }
}