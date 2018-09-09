using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoadSection4
/// </summary>
public class LoadSection4
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
    public LoadSection4()
    {
        stDescription = "";
        stheading = "";
    }
}