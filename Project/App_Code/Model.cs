using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Model
/// Hams Ahmed Ansari
/// </summary>
public class Model
{

    //Admin Login Start

    public Boolean AdminLogin(string conn, string user, string pass)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spAdminLogin";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@user", user, 20));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@password", pass, 20));

            SqlDataReader SqlReader = oCommand.ExecuteReader();
            SqlReader.Read();
            if (SqlReader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }

    }

    //Admin Login End


    //Admin Logo Update Start

    public Boolean AdminLogoUpdate(string conn, string logo, string fav)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateLogo";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@logo", logo));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@fav", fav));

            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }

    }

    //Admin Logo Update End

    //Admin Info Update Start

    public Boolean AdminInfoUpdate(string conn, string tittle, string dec, string keyword, string social)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateInfo";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@tittle", tittle, 40));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@dec", dec));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@keyword", keyword, 100));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@socialImg", social));

            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }

    }

    //Admin Info Update End

    //Admin Background Color Start

    public Boolean AdminBackGroundColor(string conn, string bg1, string bg2, string bg3)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateBackgroundColor";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@bg1", bg1, 40));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@bg2", bg2, 40));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@bg3", bg3, 40));

            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }

    }

    //Admin Background Color End

    //Admin Text Color Start

    public Boolean AdminTextColor(string conn, string text1, string text2, string text3, string text4, string text5)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateTextColor";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@text1", text1, 40));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@text2", text2, 40));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@text3", text3, 40));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@text4", text4, 40));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@text5", text5, 40));

            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }

    }

    //Admin Text Color End

    //Admin Load BasicInfo Data Start
    public LoadData LoadDataList(string conn)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        LoadData load = new LoadData();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spGetBasicInfoList";
            oCommand.Parameters.Clear();
            SqlDataReader red = oCommand.ExecuteReader();
            if (red.Read())
            {
                if (red.HasRows)
                {

                    load.Logo = red["strLogo"].ToString();
                    load.FavIcon = red["strFavicon"].ToString();
                    load.Tittle = red["strTittle"].ToString();
                    load.Description = red["strDescription"].ToString();
                    load.Keywords = red["strKeywords"].ToString();
                    load.SocialImage = red["strSocialImage"].ToString();
                    load.BackgroundColor1 = red["strBackgroundColor1"].ToString();
                    load.BackgroundColor2 = red["strBackgroundColor2"].ToString();
                    load.BackgroundColor3 = red["strBackgroundColor3"].ToString();
                    load.TextColor1 = red["strTextColor1"].ToString();
                    load.TextColor2 = red["strTextColor2"].ToString();
                    load.TextColor3 = red["strTextColor3"].ToString();
                    load.TextColor4 = red["strTextColor4"].ToString();
                    load.TextColor5 = red["strTextColor5"].ToString();

                }


            }



            return load;
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load BasicInfo Data End

    
    //Admin Load Slider Data Start
    public DataSet LoadSliderDataList(string conn)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        DataSet ds = new DataSet();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spGetSliderList";
            oCommand.Parameters.Clear();
            SqlDataAdapter red = new SqlDataAdapter(oCommand);
            red.Fill(ds);
            return ds;
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load Slider Data End

    //Admin Load Slider Data Start
    public DataSet LoadSection3DataList(string conn)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        DataSet ds = new DataSet();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spGetLoadSection3";
            oCommand.Parameters.Clear();
            SqlDataAdapter red = new SqlDataAdapter(oCommand);
            red.Fill(ds);
            return ds;
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load Slider Data End

    //Admin Load Slider Data Start
    public Boolean AdminUpdateSlider(string conn, string id, string img, string heading, string dec)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        DataSet ds = new DataSet();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateSlider";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateIntegerParameter("@id", id));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@img", img));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@heading", heading, 15));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@dec", dec));
            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load Slider Data End

    //Admin Load Navigation Data Start
    public LoadNavigation LoadNavigationDataList(string conn)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        LoadNavigation load = new LoadNavigation();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spGetNavigationList";
            oCommand.Parameters.Clear();
            SqlDataReader red = oCommand.ExecuteReader();
            if (red.Read())
            {
                if (red.HasRows)
                {
                    load.nav_1 = red["strNav1"].ToString();
                    load.nav_2 = red["strNav2"].ToString();
                    load.nav_3 = red["strNav3"].ToString();
                    load.nav_4 = red["strNav4"].ToString();
                    load.nav_5 = red["strNav5"].ToString();
                    load.nav_6 = red["strNav6"].ToString();

                }


            }



            return load;
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load Navigation Data End

    //Admin Navigation Update Start
    public Boolean AdminNavigationUpdate(string conn, string n1, string n2, string n3,string n4,string n5,string n6)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateNavigation";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@n1", n1, 20));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@n2", n2, 20));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@n3", n3, 20));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@n4", n4, 20));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@n5", n5, 20));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@n6", n6, 20));

            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }

    }
    //Admin Navigation Update End

    //Admin Update About Data Start
    public Boolean UpdateAboutDataList(string conn,string heading,string dec)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        LoadNavigation load = new LoadNavigation();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateAbout";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@heading", heading, 20));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@Dec", dec));

            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Update about Data End

    //Admin Load About  Data Start
    public LoadAbout LoadAboutDataList(string conn)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        LoadAbout load = new LoadAbout();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spGetAboutData";
            oCommand.Parameters.Clear();
            SqlDataReader red = oCommand.ExecuteReader();
            if (red.Read())
            {
                if (red.HasRows)
                {
                    load.heading = red["strHeading"].ToString();
                    load.Description = red["strDescription"].ToString();

                }


            }



            return load;
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load About  Data End


    //Admin Load Gallery Data Start
    public DataSet LoadGalleryDataList(string conn)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        DataSet ds = new DataSet();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spGetGalleryList";
            oCommand.Parameters.Clear();
            SqlDataAdapter red = new SqlDataAdapter(oCommand);
            red.Fill(ds);
            return ds;
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load Gallery Data End


    //Admin Update Gallery Data Start
    public Boolean AdminUpdateGallery(string conn, string id, string img)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        DataSet ds = new DataSet();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateGallery";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateIntegerParameter("@id", id));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@img", img));
            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Update Gallery Data End

    //Admin Load Section4  Data Start
    public LoadSection4 LoadSection4DataList(string conn)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        LoadSection4 load = new LoadSection4();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spGetLoadSection4";
            oCommand.Parameters.Clear();
            SqlDataReader red = oCommand.ExecuteReader();
            if (red.Read())
            {
                if (red.HasRows)
                {
                    load.heading = red["strHeading"].ToString();
                    load.Description = red["strDescription"].ToString();

                }


            }



            return load;
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load Section4  Data End

    //Admin Update Setion 4 Data Start
    public Boolean UpdateSetion4DataList(string conn, string heading, string dec)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        LoadNavigation load = new LoadNavigation();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateSetion4";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@heading", heading, 20));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@Dec", dec));

            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Update Setion 4 Data End

    //Admin Load Contact  Data Start
    public LoadContact LoadContactDataList(string conn)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        LoadContact load = new LoadContact();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spGetLoadContact";
            oCommand.Parameters.Clear();
            SqlDataReader red = oCommand.ExecuteReader();
            if (red.Read())
            {
                if (red.HasRows)
                {
                    load.Email = red["strEmail"].ToString();
                    load.Map = red["strMap"].ToString();
                    load.Address = red["strAddress"].ToString();
                    load.Contact = red["strContact"].ToString();

                }


            }



            return load;
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load Contact  Data End

    //Admin Update Contact  Data Start
    public Boolean UpdateContactDataList(string conn, string email, string contact,string address,string map)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        LoadNavigation load = new LoadNavigation();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateContact";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@email", email, 50));
            oCommand.Parameters.Add(oGateway.CreateStringParameter("@contact", contact, 15));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@address", address));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@map", map));

            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Update Contact Data End

    //Admin Load Contact  Data Start
    public Links LoadContactLinkDataList(string conn)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        Links load = new Links();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spGetContactLinkList";
            oCommand.Parameters.Clear();
            SqlDataReader red = oCommand.ExecuteReader();
            if (red.Read())
            {
                if (red.HasRows)
                {
                    load.Fb = red["strLinkFb"].ToString();
                    load.Twitter = red["strLinkTwitter"].ToString();
                    load.Youtube = red["strLinkYoutube"].ToString();

                }


            }



            return load;
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Load Contact  Data End

    //Admin Update Contact  Data Start
    public Boolean UpdateContactLinksDataList(string conn, string fb, string twitter, string youtube)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        LoadNavigation load = new LoadNavigation();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spUpdateContactLink";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@fb", fb));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@twitter", twitter));
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@youtube", youtube));

            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Update Contact Data End


    //Admin Update Gallery Data Start
    public Boolean AdminAddGallery(string conn, string img)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        DataSet ds = new DataSet();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spAddNewGallery";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateTextParameter("@img", img));
            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Update Gallery Data End

    //Admin Update Gallery Data Start
    public Boolean AdminDeletingGallery(string conn, string id)
    {
        SqlCommand oCommand = new SqlCommand();
        Connection oGateway = new Connection(conn);
        DataSet ds = new DataSet();
        try
        {
            oCommand.Connection = oGateway.OpenConnection();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.CommandText = "spDeleteGallery";
            oCommand.Parameters.Clear();
            oCommand.Parameters.Add(oGateway.CreateIntegerParameter("@id", id));
            int abc = Convert.ToInt32(oCommand.ExecuteScalar());
            if (abc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        finally
        {
            oCommand.Connection.Close();
        }




    }
    //Admin Update Gallery Data End
    public Model()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
