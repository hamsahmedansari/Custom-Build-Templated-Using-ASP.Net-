using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoadContact
/// </summary>
public class LoadContact
{


    #region "LoadContact"
    protected string stEmail;
    protected string stMap;
    protected string stAddress;
    protected string stContact;
    #endregion

    #region "LoadContact"
    public string Email
    {
        get { return this.stEmail; }
        set { this.stEmail = value; }
    }
    public string Map
    {
        get { return this.stMap; }
        set { this.stMap = value; }
    }
    public string Address
    {
        get { return this.stAddress; }
        set { this.stAddress = value; }
    }
    public string Contact
    {
        get { return this.stContact; }
        set { this.stContact = value; }
    }
    #endregion
    public LoadContact()
    {
        stEmail = "";
        stMap = "";
        stAddress = "";
        stContact = "";
    }
}