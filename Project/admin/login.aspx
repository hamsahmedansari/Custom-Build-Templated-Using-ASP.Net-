<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_login" %>
<!-- 
    ------- Author's ------

    --- Hams Ahmed Ansari ---
    ----- Email : Hams.Ahmed.Ansari95@gmail.com -------
    ----- Website : https://hams.cf ------

    --- Mumtaz Ahmed Siddiui ---
    ----- Email : mumtaz.sid995@gmail.com -------
    ----- Website : http://mumtazsiddiqui.cf ------

    --- Murtaz Ali ---
    ----- Email : ali7murtaza@gmail.com -------
    ----- Website : http://murtazaali.ga ------
    
-->
<!doctype html>
<html class="no-js" lang=""> 
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Admin Login</title>
    <meta name="description" content="Sufee Admin - HTML5 Admin Template">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    
    <link rel="apple-touch-icon" href="images/pn.png">
    <link rel="shortcut icon" href="images/pn.png">
    <link rel="icon" href="images/pn.png" type="image/x-icon">

    <link rel="stylesheet" href="assets/css/normalize.css">
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <link rel="stylesheet" href="assets/css/font-awesome.min.css">
    <link rel="stylesheet" href="assets/css/themify-icons.css">
    <link rel="stylesheet" href="assets/css/flag-icon.min.css">
    <link rel="stylesheet" href="assets/css/cs-skin-elastic.css">
    <link rel="stylesheet" href="assets/scss/style.css">

    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,600,700,800' rel='stylesheet' type='text/css'>

  
</head>
<body class="bg-dark">
    
    <form id="form1" runat="server">

    <div class="sufee-login d-flex align-content-center flex-wrap">
        <div class="container">
            <div class="login-content">
                <div class="login-logo">
                    <a href="http://theprofessionals.com.pk/" target="_blank">
                        <img class="align-content img-fluid"  src="images/logo0.png" alt="">
                    </a>
                </div>
                <div class="login-form">
                    <form>
                        <div class="form-group">
                            <label>User Name</label>
                            <input type="text" class="form-control" runat="server" id="txtemail" placeholder="User Name">
                        </div>
                        <div class="form-group">
                            <label>Password</label>
                            <input type="password" class="form-control" runat="server" id="txtpassword" placeholder="Password">
                        </div>
                       
                        <%--<button type="button" runat="server" class="btn btn-success btn-flat m-b-30 m-t-30" id="btnLogin" >Sign in</button>--%>
                       <asp:Button  runat="server" CssClass="btn btn-success btn-flat m-b-30 m-t-30" id="btnLogin" Text="Sign In" OnClick="btnLogin_Click"/>
                    </form>
                </div>
            </div>
        </div>
    </div>


    <script src="assets/js/vendor/jquery-2.1.4.min.js"></script>
    <script src="assets/js/popper.min.js"></script>
    <script src="assets/js/plugins.js"></script>
    <script src="assets/js/main.js"></script>

    
        

    </form>
</body>
</html>
