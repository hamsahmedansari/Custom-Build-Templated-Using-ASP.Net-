using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoadNavigation
/// </summary>
public class LoadNavigation
{

    #region "Navigation"
    protected string nav1;
    protected string nav2;
    protected string nav3;
    protected string nav4;
    protected string nav5;
    protected string nav6;
    #endregion

    #region "BasicInfoDec"
    public string nav_1
    {
        get { return this.nav1; }
        set { this.nav1 = value; }
    }
    public string nav_2
    {
        get { return this.nav2; }
        set { this.nav2 = value; }
    }
    public string nav_3
    {
        get { return this.nav3; }
        set { this.nav3 = value; }
    }
    public string nav_4
    {
        get { return this.nav4; }
        set { this.nav4 = value; }
    }
    public string nav_5
    {
        get { return this.nav5; }
        set { this.nav5 = value; }
    }
    public string nav_6
    {
        get { return this.nav6; }
        set { this.nav6 = value; }
    }
    #endregion
    public LoadNavigation()
    {        
        nav1 = "";
        nav2 = "";
        nav3 = "";
        nav4 = "";
        nav5 = "";
        nav6 = "";
    }
}