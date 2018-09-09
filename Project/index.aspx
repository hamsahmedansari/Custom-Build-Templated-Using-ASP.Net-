<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>
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

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title runat="server" id="txtTittle"></title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <%-- icon --%>

    <link rel="apple-touch-icon" runat="server" id="imgFav_1" />
    <link rel="shortcut icon" runat="server" id="imgFav_2" />

    <%--icon--%>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="dist/css/owl.carousel.css" rel="stylesheet" />
    <link href="dist/css/owl.theme.default.css" rel="stylesheet" />
    <script src="dist/js/owl.carousel.js"></script>
    <link href="dist/css/footer.css" rel="stylesheet" />
    <link href="dist/css/main.css" rel="stylesheet" />

    <script src="dist/js/main.js"></script>

    <%--FACEBOOK--%>
    <meta property="og:url" runat="server" id="txtFbUrl" />
    <meta property="og:type" content="article" />
    <meta property="og:title" runat="server" id="txtFBtittle" />
    <meta property="og:description" runat="server" id="txtFBDecsription" />
    <meta property="og:image" runat="server" id="imgFBSocial" />
    <%--TWITTER--%>
    <meta name="twitter:card" content="summary" />
    <meta name="twitter:title" runat="server" id="txtTWITTERtittle" />
    <meta name="twitter:description" runat="server" id="txtTWITTERDecsription" />
    <meta name="twitter:image" runat="server" id="imgTwitterSocial" />
    <%--GOOGLE--%>
    <meta name="description" runat="server" id="txtDecsription" />
    <meta name="keywords" runat="server" id="txtKeyword" />




</head>
<body>
    <form id="form1" runat="server">


        <a class="fa fa-angle-up scroll_top d-none custom-back-to-top custom-back-to-top-text" href="#Home"></a>
        <%--Navbar--%>

        <div class="conatiner-fluid custom-dark fixed-top box-shadow">

            <div class="container">

                <nav class="navbar navbar-expand-md bg-none navbar-danger ">
                    <a class="navbar-brand" href="#">

                        <img src="" runat="server" id="imgLogo" class="img-fluid img" style="max-width: 200px; max-height: 70px;" alt="" />

                    </a>
                    <button class="navbar-toggler bg-white text-white" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
                        <span class="fa fa-bars text-dark text-white p-3"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="collapsibleNavbar">
                        <ul class="navbar-nav ml-auto">
                            <li class="nav-item">
                                <a class="nav-link custom-text-light" href="#Home" runat="server" id="txtnav1"></a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link custom-text-light" href="#About" runat="server" id="txtnav2"></a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link custom-text-light" href="#Gallery" runat="server" id="txtnav3"></a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link custom-text-light" href="#Section-3" runat="server" id="txtnav4"></a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link custom-text-light" href="#Section-4" runat="server" id="txtnav5"></a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link custom-text-light" href="#Section-5" runat="server" id="txtnav6"></a>
                            </li>
                        </ul>
                    </div>
                </nav>

            </div>

        </div>

        <%--Navbar--%>

        <div id="Home" class="mt-5"></div>

        <%-- Slider --%>

        <div class="" style="margin-top: 70px;">


            <%--<div class="w-100  text-center text-capitalize p-5 custom_slider" style="height: 500px; background-image: url('img/2.jpg'); background-position: center; background-repeat: no-repeat; background-size: cover;">

                <div class="pt-5 row">

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                    <div class="col-lg-6 col-12">


                        <h1 class="pt-5 custom-text-slider ">Heading</h1>
                        <p class="custom-text-slider">
                            Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                        </p>


                    </div>

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                </div>

            </div>
            <div class="w-100  text-center text-capitalize p-5 custom_slider" style="height: 500px; background-image: url('img/3.jpg'); background-position: center; background-repeat: no-repeat; background-size: cover;">

                <div class="pt-5 row">

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                    <div class="col-lg-6 col-12">


                        <h1 class="pt-5 custom-text-slider ">Heading</h1>
                        <p class="custom-text-slider">
                            Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                        </p>


                    </div>

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                </div>

            </div>
            <div class="w-100  text-center text-capitalize p-5 custom_slider" style="height: 500px; background-image: url('img/4.jpg'); background-position: center; background-repeat: no-repeat; background-size: cover;">

                <div class="pt-5 row">

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                    <div class="col-lg-6 col-12">


                        <h1 class="pt-5 custom-text-slider ">Heading</h1>
                        <p class="custom-text-slider">
                            Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                        </p>


                    </div>

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                </div>

            </div>
            <div class="w-100  text-center text-capitalize p-5 custom_slider" style="height: 500px; background-image: url('img/5.jpg'); background-position: center; background-repeat: no-repeat; background-size: cover;">

                <div class="pt-5 row">

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                    <div class="col-lg-6 col-12">


                        <h1 class="pt-5 custom-text-slider ">Heading</h1>
                        <p class="custom-text-slider">
                            Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                        </p>


                    </div>

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                </div>

            </div>
            <div class="w-100  text-center text-capitalize p-5 custom_slider" style="height: 500px; background-image: url('img/6.jpg'); background-position: center; background-repeat: no-repeat; background-size: cover;">

                <div class="pt-5 row">

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                    <div class="col-lg-6 col-12">


                        <h1 class="pt-5 custom-text-slider ">Heading</h1>
                        <p class="custom-text-slider">
                            Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                                Tincidunt integer eu integer eu 
                        </p>


                    </div>

                    <div class="col-lg-3 d-none d-lg-block d-md-block ">
                    </div>

                </div>

            </div>--%>

            <asp:ListView ID="Slider" runat="server" GroupItemCount="1">

                <LayoutTemplate>
                    <div class="owl-carousel" cellpadding="20" runat="server" cellspacing="50" id="tblProducts">
                        <span runat="server" class="items" id="groupPlaceholder"></span>

                    </div>
                </LayoutTemplate>
                <GroupTemplate>
                    <span class="text-center" runat="server" id="productRow">
                        <span runat="server" id="itemPlaceHolder"></span>
                    </span>
                </GroupTemplate>
                <ItemTemplate>

                    <div class="w-100 text-center text-capitalize p-5 custom_slider" style='background-image: url("<%# "Images/"+ Eval("strSliderImage") %>")'>


                        <div class="pt-5 row">

                            <div class="col-lg-3 d-none d-lg-block d-md-block ">
                            </div>

                            <div class="col-lg-6 col-12">


                                <h1 class="pt-5 custom-text-slider "><%# Eval("strSliderHeading") %></h1>
                                <p class="custom-text-slider">
                                    <%# Eval("strSliderDescription") %>
                                </p>


                            </div>

                            <div class="col-lg-3 d-none d-lg-block d-md-block ">
                            </div>

                        </div>

                    </div>

                </ItemTemplate>

            </asp:ListView>

        </div>

        <%-- Slider --%>

        <%-- About --%>

        <div class="container-fluid p-5" id="About">

            <div class="row">

                <div class="col-12 text-center pt-5">

                    <h1 runat="server" id="txtAboutHeading">About
                    </h1>
                    <p class="pl-5 pr-5" runat="server" id="txtAboutSection">
                        Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.

                    </p>
                </div>

            </div>

        </div>

        <%-- About --%>


        <%-- Section 3 --%>

        <div class="container-fluid p-5 custom-dark custom-text-light" id="Section-3">
            <div class="container">
                <div class="row ">

                    <div class="col-12 text-center mb-3">

                        <h1 runat="server" id="txtSection_3_heading">Section 3</h1>

                    </div>
                    <asp:ListView ID="lvtSection3" runat="server">

                        <LayoutTemplate>
                            <div class="row w-100" cellpadding="20" runat="server" cellspacing="50" id="tblProducts">
                                <span runat="server" class="" id="groupPlaceholder"></span>

                            </div>
                        </LayoutTemplate>
                        <GroupTemplate>
                            <div class="col-lg-4 col-md-4 col-sm-4 col-12" runat="server" id="productRow">
                                <span runat="server" id="itemPlaceHolder"></span>
                            </div>
                        </GroupTemplate>
                        <ItemTemplate>


                            <div class="card img-fluid bg-none border-0 text-center">
                                <span class="<%# "card-img-top fa "+ Eval("strIcon") %>"></span>
                                <div class="card-body">
                                    <h4 class="card-title"><%# Eval("strHeading") %></h4>
                                    <p class="card-text"><%# Eval("strDescription") %> </p>
                                </div>
                            </div>

                        </ItemTemplate>

                    </asp:ListView>

                    <%--                    <div class="col-lg-4 col-md-4 col-sm-4 col-12">

                        <div class="card img-fluid bg-none border-0 text-center">
                            <span class="card-img-top fa fa-bullhorn"></span>
                            <div class="card-body">
                                <h4 class="card-title">Block 2</h4>
                                <p class="card-text">Some example text some example text. John Doe is an architect and engineer</p>
                            </div>
                        </div>

                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-12">

                        <div class="card img-fluid bg-none border-0 text-center">
                            <span class="card-img-top 	fa fa-bar-chart"></span>
                            <div class="card-body">
                                <h4 class="card-title">Block 3</h4>
                                <p class="card-text">Some example text some example text. John Doe is an architect and engineer</p>
                            </div>
                        </div>

                    </div>--%>
                </div>
            </div>
        </div>

        <%-- Section 3 --%>

        <%-- Gallery --%>

        <div class=" p-5" id="Gallery">

            <div class="container">

                <div class="row">

                    <div class="col-12 text-center text-dark p-5">

                        <h1 runat="server" id="txtGalleryHeading"></h1>
                    </div>

                </div>

                <asp:ListView ID="lvGallery" runat="server">

                    <LayoutTemplate>
                        <div class="row" cellpadding="20" runat="server" cellspacing="50" id="tblProducts">
                            <span runat="server" class="" id="groupPlaceholder"></span>

                        </div>
                    </LayoutTemplate>
                    <GroupTemplate>
                        <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1 " runat="server" id="productRow">
                            <span runat="server" id="itemPlaceHolder"></span>
                        </div>
                    </GroupTemplate>
                    <ItemTemplate>


                        <div class="">

                            <img src="<%# "Images/"+ Eval("strImage") %>" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                        </div>

                    </ItemTemplate>

                </asp:ListView>


                <%--<div class="row">

                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1 ">

                        <img src="img/1.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/2.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/3.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/5.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/4.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/6.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/1.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/2.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/3.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1 ">

                        <img src="img/1.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/2.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/3.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/5.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/4.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/6.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/1.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/2.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                    <div class="col-12 col-lg-4 col-md-4 col-sm-6 p-1">

                        <img src="img/3.jpg" class="img img-fluid img_popup" data-toggle="modal" data-target="#myModal" alt="" />

                    </div>
                </div>--%>
            </div>


            <div class="modal fade bg-none" id="myModal">
                <div class="modal-dialog bg-none">
                    <div class="modal-content bg-none border-0">



                        <!-- Modal body -->
                        <div class="modal-body text-center bg-none">

                            <img src="" class="img img-fluid img_popup_model" alt="" />

                        </div>


                    </div>
                </div>
            </div>

        </div>

        <%-- Gallery --%>

        <%-- Section 4 --%>

        <div class="container-fluid p-5 custom-dark custom-text-light" id="Section-4">

            <div class="row">

                <div class="col-12 text-center pt-5">

                    <h1 runat="server" id="txtSection4Heading">Section 4
                    </h1>
                    <p class="pl-5 pr-5" runat="server" id="txtSection4Section">
                        Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.

                    </p>
                </div>

            </div>

        </div>

        <%-- Section 4 --%>


        <%-- Section 5 --%>

        <div class="container-fluid p-5 text-dark" id="Section-5">

            <div class="row">

                <div class="col-12 text-center pt-5 pb-3">

                    <h1 runat="server" id="txtContactusHeading">Contact us
                    </h1>

                    <div class="row">

                        <div class="col-lg-8 col-md-8 col-sm-8 col-12">

                            <div class="container">


                                <div class="p-5 text-left">





                                        <span>
                                            <span><span class="fa fa-envelope"></span></span>
                                            <span>Email</span>
                                            <span>:</span>
                                            <span runat="server" id="txtContactEmail"></span>
                                        </span>
                                    <br />
                                        <span class="mt-4" >
                                            <span><span class="fa fa-phone mt-4"></span></span>
                                            <span>Contact</span>
                                            <span>:</span>
                                            <span runat="server" id="txtContactno"></span>
                                        </span>
                                    <br class="mt-4" />
                                        
                                            <span class="fa fa-address-book mt-4"></span>
                                           Address
                                            :
                                            <span runat="server" id="txtContactAddress"></span>
                                        

                                </div>

                                <div class="map-responsive">
                                    <iframe runat="server" id="iframeMap" src="https://www.google.com/maps/embed/v1/place?key=AIzaSyA0s1a7phLN0iaD6-UE7m4qP-z21pH0eSc&q=Eiffel+Tower+Paris+France" style="width: 100%; height: 250px;" frameborder="0" allowfullscreen></iframe>
                                </div>

                            </div>
                        </div>


                        <div class="col-lg-4 col-md-4 col-sm-4 col-12 text-left custom-contact custom-text-contact p-5">
                            <label>
                                Full Name
                            </label>
                            <input type="text" runat="server" id="txtfullname" class="form-control" />
                            <label class="pt-2">
                                Contact No
                            </label>
                            <input type="text" runat="server" id="txtcontact" class="form-control" />
                            <label class="pt-2">
                                Email
                            </label>
                            <input type="Email" runat="server" id="txtemail" class="form-control" />
                            <label class="pt-2">
                                Message
                            </label>
                            <textarea id="txtmessage" runat="server" class="form-control" style="height: 120px; resize: none"></textarea>
                            <div class="mt-3 text-center">
                                <button runat="server" id="btnreset" class="btn btn-danger d-inline-block">
                                    RESET
                                </button>
                                <button runat="server" onserverclick="btnsubmit_ServerClick" id="btnsubmit" class="btn btn-success d-inline-block">
                                    SUBMIT
                                </button>
                            </div>

                        </div>

                    </div>

                </div>

            </div>

        </div>

        <%-- Section 5 --%>

        <%-- Footer --%>

        <footer id="myFooter">

            <div class="footer-copyright custom-dark ">
                <p class="custom-text-footer">&copy; 2016 Copyright
                    <label runat="server" id="footerlabel"></label>
                </p>
            </div>
        </footer>

        <%-- Footer --%>


        <%-- Social Icons --%>
        <div class="col-md-12">
                    <ul class="social-network social-circle position-fixed" style="top:40%;left:-.5%;">
                        <li><a runat="server" target="_blank" id="lnkFb" class="icoFacebook" title="Facebook"><i class="fa fa-facebook"></i></a></li>
                        <li><a runat="server" target="_blank" id="lnkTwitter" class="icoTwitter" title="Twitter"><i class="fa fa-twitter"></i></a></li>
                        <li><a runat="server" target="_blank" id="lnkYoutube" class="icoGoogle" title="Google +"><i class="fa fa-youtube"></i></a></li>
                    </ul>				
				</div>
    </form>
</body>
</html>
