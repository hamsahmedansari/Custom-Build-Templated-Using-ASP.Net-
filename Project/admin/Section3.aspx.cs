using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Section3 : System.Web.UI.Page
{
    string con;
    protected void Page_Load(object sender, EventArgs e)
    {

        con = ConfigurationManager.ConnectionStrings["Hams"].ConnectionString;
        if (!IsPostBack)
        {
            LoadHeader();
            LoadCompleteData();
        }
    }
    private void addlist(DropDownList dd)
    {
        ArrayList arrayList = new ArrayList();

        for (int i = 0; i < dd.Items.Count; i++)
        {
            arrayList.Add(dd.Items[i].ToString().Trim());
        }

        dd.DataSource = null;
        dd.DataSource = arrayList;
        dd.DataBind();

    }
    private void LoadCompleteData()
    {
        load1();
        load2();
        load3();
    }
    private void load1()
    {
        addlist(favicon_1);
        string query = @"SELECT        id, strIcon, strHeading, strDescription
FROM            tblSection3
WHERE        (id = 1)";
        SqlConnection conn = new SqlConnection(con);
        conn.Open();
        SqlCommand ocmd = new SqlCommand(query, conn);
        SqlDataReader red = ocmd.ExecuteReader();
        if (red.Read())
        {
            if (red.HasRows)
            {
                txtID1.Text = red["id"].ToString();
                string asd = red["strIcon"].ToString().Trim();
                favicon_1.SelectedValue = favicon_1.Items.FindByText(asd).Value;
                txtBlock1Heading.Value = red["strHeading"].ToString();
                txtBlock1Description.Value = red["strDescription"].ToString();

            }
        }
    }

    private void load2()
    {
        addlist(favicon2);
        string query = @"SELECT        id, strIcon, strHeading, strDescription
FROM            tblSection3
WHERE        (id = 2)";
        SqlConnection conn = new SqlConnection(con);
        conn.Open();
        SqlCommand ocmd = new SqlCommand(query, conn);
        SqlDataReader red = ocmd.ExecuteReader();
        if (red.Read())
        {
            if (red.HasRows)
            {
                txtID2.Text = red["id"].ToString();
                string asd = red["strIcon"].ToString().Trim();
                favicon2.SelectedValue = favicon2.Items.FindByText(asd).Value;
                txtBlock2Heading.Value = red["strHeading"].ToString();
                txtBlock2Description.Value = red["strDescription"].ToString();

            }
        }
    }

    private void load3()
    {
        addlist(favicon3);
        string query = @"SELECT        id, strIcon, strHeading, strDescription
FROM            tblSection3
WHERE        (id = 3)";
        SqlConnection conn = new SqlConnection(con);
        conn.Open();
        SqlCommand ocmd = new SqlCommand(query, conn);
        SqlDataReader red = ocmd.ExecuteReader();
        if (red.Read())
        {
            if (red.HasRows)
            {
                txtID3.Text = red["id"].ToString();
                string asd = red["strIcon"].ToString().Trim();
                favicon3.SelectedValue = favicon3.Items.FindByText(asd).Value;
                txtBlock3Heading.Value = red["strHeading"].ToString();
                txtBlock3Description.Value = red["strDescription"].ToString();

            }
        }
    }
    private void LoadHeader()
    {
        Model model = new Model();
        LoadNavigation load = model.LoadNavigationDataList(con);


        Label header1 = (Label)Master.FindControl("header_from_master");
        header1.Text = load.nav_4.Trim();
    }


    protected void btnLogo_ServerClick(object sender, EventArgs e)
    {
        if (txtBlock1Heading.Value.Length != 0 && txtBlock1Description.Value.Length != 0)
        {
            string query = @"UPDATE [tblSection3]
   SET [strIcon] = '"+favicon_1.SelectedValue.ToString().Trim()+@"'
      ,[strHeading] = '"+txtBlock1Heading.Value.ToString().Trim()+@"'
      ,[strDescription] = '"+txtBlock1Description.Value.ToString().Trim()+@"'
 WHERE [id] = 1";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlCommand ocmd = new SqlCommand(query, conn);
            ocmd.ExecuteScalar();
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                                     "alert('successfully Updated')", true);
            conn.Close();
        }
    }

    protected void Button1_ServerClick(object sender, EventArgs e)
    {

        if (txtBlock2Heading.Value.Length != 0 && txtBlock2Description.Value.Length != 0)
        {
            string query = @"UPDATE [tblSection3]
   SET [strIcon] = '" + favicon2.SelectedValue.ToString().Trim() + @"'
      ,[strHeading] = '" + txtBlock2Heading.Value.ToString().Trim() + @"'
      ,[strDescription] = '" + txtBlock2Description.Value.ToString().Trim() + @"'
 WHERE [id] = 2";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlCommand ocmd = new SqlCommand(query, conn);
            ocmd.ExecuteScalar(); ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                          "alert('successfully Updated')", true);
            conn.Close();
        }
    }

    protected void Button2_ServerClick(object sender, EventArgs e)
    {


        if (txtBlock3Heading.Value.Length != 0 && txtBlock3Description.Value.Length != 0)
        {
            string query = @"UPDATE [tblSection3]
   SET [strIcon] = '" + favicon3.SelectedValue.ToString().Trim() + @"'
      ,[strHeading] = '" + txtBlock3Heading.Value.ToString().Trim() + @"'
      ,[strDescription] = '" + txtBlock3Description.Value.ToString().Trim() + @"'
 WHERE [id] = 3";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlCommand ocmd = new SqlCommand(query, conn);
            ocmd.ExecuteScalar(); ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
                          "alert('successfully Updated')", true);
            conn.Close();
        }
    }
}