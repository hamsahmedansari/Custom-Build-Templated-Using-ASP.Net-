using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoadAbout
/// </summary>
public class LoadAbout
{

    #region "LoadAbou1t"
    protected string stheading;
    protected string stDescription;
    #endregion

    #region "LoadAbou1t"
    public string heading
    {
        get { return this.stheading; }
        set { this.stheading = value; }
    }
    public string Description
    {
        get { return this.stDescription; }
        set { this.stDescription = value; }
    }
    #endregion
    public LoadAbout()
    {
        stDescription = "";
        stheading = "";
    }
}