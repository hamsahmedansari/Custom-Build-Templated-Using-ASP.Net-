<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        RegisterRoutes(RouteTable.Routes);
    }
    static void RegisterRoutes(RouteCollection Routes)
    {
        Routes.MapPageRoute("Home", "Home", "~/index.aspx");
        Routes.MapPageRoute("em", "", "~/index.aspx");
        Routes.MapPageRoute("Login", "admin/login", "~/admin/login.aspx");
        Routes.MapPageRoute("Basic-Info", "admin/Basic-Info", "~/admin/Basic-Info.aspx");
        Routes.MapPageRoute("Slider", "admin/Slider", "~/admin/Slider.aspx");
        Routes.MapPageRoute("Navigation", "admin/Navigation", "~/admin/Navigation.aspx");
        Routes.MapPageRoute("About", "admin/About", "~/admin/About.aspx");
        Routes.MapPageRoute("Section3", "admin/Section3", "~/admin/Section3.aspx");
        Routes.MapPageRoute("Gallery", "admin/Gallery", "~/admin/Gallery.aspx");
        Routes.MapPageRoute("Section4", "admin/Section4", "~/admin/Section4.aspx");
        Routes.MapPageRoute("Contact", "admin/Contact", "~/admin/Contact.aspx");
    }
    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

</script>
