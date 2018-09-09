<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/admin.master" CodeFile="Basic-Info.aspx.cs" Inherits="admin_Basic_Info" %>


<asp:Content ID="head" runat="server" ContentPlaceHolderID="head">

    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-colorpicker/2.3.6/css/bootstrap-colorpicker.css" rel="stylesheet">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-colorpicker/2.3.6/js/bootstrap-colorpicker.js"></script>

    <script>
        $(document).ready(function () {

            $(".change_text_of_header").html("Basic Information")
            $(".ci_li").removeClass("active");
            $(".cu_basic").addClass("active");

        });
    </script>
</asp:Content>


<asp:Content ID="body" runat="server" ContentPlaceHolderID="body">


    <div class="col-xl-6 col-lg-6 col-sm-12 col-12 c-fadein">

        <div class="card">
            <div class="card-header">
                <strong class="card-title">Logo </strong>
            </div>
            <div class="card-body">
                <div id="pay-invoice">
                    <div class="card-body">
                        <div class="card-title text-center">
                            <img src="../img/3.jpg" class="img-thumbnail" style="max-width:500px;max-height:300px;" runat="server" id="imgLogo" alt="" />
                            <br />
                            <img src="../img/3.jpg" class="img-thumbnail img-fluid" id="imgFav" runat="server" style="max-width: 50px; max-height: 50px" alt="" />
                        </div>
                        <hr>


                        <div>

                            <div class="form-contol">
                                <label>Update Logo (200x60)</label>
                                <input type="file" runat="server" id="txtlogo" accept="image/*" name="Logo" class="form-control-file">
                            </div>
                            <br />
                            <div class="form-contol">
                                <label>Favicon icon (16x16)</label>
                                <input type="file" runat="server" id="txtFavionicon" accept="image/*" name="Logo" class="form-control-file">
                            </div>
                            <br />
                            <button type="button" id="btnLogo" runat="server" onserverclick="btnLogo_ServerClick" class="btn btn-lg btn-info btn-block">
                                <i class="fa fa-cloud-upload	 fa-lg"></i>&nbsp;
                                             
                                <span>Change</span>
                            </button>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>

    <div class="col-xl-6 col-lg-6 col-sm-12 col-12 c-fadein">

        <div class="card" style="height: 710px;">
            <div class="card-header">
                <strong class="card-title text-center">Info </strong>
            </div>
            <div class="card-body">
                <div id="">
                    <div class="card-body">

                        <div class="card-title">

                            <div class="form-group">
                                <label>Tittle</label>
                                <input type="text" id="txtTittle" maxlength="40" placeholder="Max Tittle 40" runat="server" class="form-control" />
                            </div>
                            <div class="form-group">
                                <label>Description</label>
                                <textarea id="txtDescription" runat="server" class="form-control" maxlength="200" placeholder="Max Description 200" style="height: 150px; resize: none;"></textarea>
                            </div>
                            <div class="form-group">
                                <label>Keyword's</label>
                                <input type="text" id="txtKeywords" placeholder="Separate Keywords with comma" runat="server" class="form-control" />
                            </div>
                            <div class="form-contol float-left mb-4">
                                <label>Social Image (600x300)</label>

                                <input type="file" runat="server" id="txtSocialImage" accept="image/*" name="Logo" class="form-control-file">
                            </div>
                            <div class="float-right">
                                <img src="../img/3.jpg" class="img-thumbnail img-fluid" runat="server" id="imgSocial" style="max-width: 100px; max-height: 100px" alt="" />
                            </div>
                        </div>


                        <div>


                            <br />
                            <button id="btnInfo" runat="server" type="button" onserverclick="btnInfo_ServerClick" class="btn btn-lg btn-info btn-block">
                                <i class="fa fa-cloud-upload	 fa-lg"></i>&nbsp;
                                             
                                <span>Update</span>
                            </button>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>

    <div class="col-xl-6 col-lg-6 col-sm-12 col-12 c-fadein">

        <div class="card" style="height: 574px;">
            <div class="card-header">
                <strong class="card-title text-center">Background Color </strong>
            </div>
            <div class="card-body">
                <div id="">
                    <div class="card-body">

                        <div class="card-title">

                            <label>Nav,Footer,Section 3,Section 4 </label>
                            <div id="BGDark_outter" class="input-group colorpicker-component">
                                <input type="text" id="txtbackgroundColor1" runat="server" maxlength="40" value="#00AABB" class="form-control" />
                                <span class="input-group-addon"><i></i></span>
                            </div>
                            <br />
                            <label>Contact Form</label>
                            <div id="BGContact_Outter" class="input-group colorpicker-component">
                                <input type="text" id="txtbackgroundColor2" runat="server" maxlength="40" value="#00AABB" class="form-control" />
                                <span class="input-group-addon"><i></i></span>
                            </div>
                            <br />
                            <label>Back To Top</label>
                            <div id="BGBackToTop_Outter" class="input-group colorpicker-component">
                                <input type="text" id="txtbackgroundColor3" runat="server" maxlength="40" value="#00AABB" class="form-control" />
                                <span class="input-group-addon"><i></i></span>
                            </div>
                        </div>


                        <div>


                            <br />
                            <button id="btnBackgroundColor" runat="server" onserverclick="btnBackgroundColor_ServerClick" type="submit" class="btn btn-lg btn-info btn-block">
                                <i class="fa fa-cloud-upload	 fa-lg"></i>&nbsp;
                                             
                                <span>Update</span>
                            </button>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>

    <div class="col-xl-6 col-lg-6 col-sm-12 col-12 c-fadein">

        <div class="card">
            <div class="card-header">
                <strong class="card-title text-center">Text Color </strong>
            </div>
            <div class="card-body">
                <div id="">
                    <div class="card-body">

                        <div class="card-title">

                            <label>Nav,Section 3,Section 4 </label>
                            <div id="FontColorLight_Outter" class="input-group colorpicker-component">
                                <input type="text" id="txtTextColor1" runat="server" maxlength="40" value="#00AABB" class="form-control" />
                                <span class="input-group-addon"><i></i></span>
                            </div>
                            <br />
                            <label>Contact Form</label>
                            <div id="FontColorContact_Outter" class="input-group colorpicker-component">
                                <input type="text" id="txtTextColor2" runat="server" maxlength="40" value="#00AABB" class="form-control" />
                                <span class="input-group-addon"><i></i></span>
                            </div>
                            <br />
                            <label>Slider</label>
                            <div id="FontColorSlider_Outter" class="input-group colorpicker-component">
                                <input type="text" id="txtTextColor3" runat="server" maxlength="40" value="#00AABB" class="form-control" />
                                <span class="input-group-addon"><i></i></span>
                            </div>
                            <br />
                            <label>Footer</label>
                            <div id="FontColorFooter_Outter" class="input-group colorpicker-component">
                                <input type="text" id="txtTextColor4" runat="server" maxlength="40" value="#00AABB" class="form-control" />
                                <span class="input-group-addon"><i></i></span>
                            </div>
                            <br />
                            <label>Back To Top </label>
                            <div id="FontColorBackToTop_Outter" class="input-group colorpicker-component">
                                <input type="text" id="txtTextColor5" runat="server" maxlength="40" value="#00AABB" class="form-control" />
                                <span class="input-group-addon"><i></i></span>
                            </div>
                        </div>
                        <hr>


                        <div>


                            <br />
                            <button id="btnTextColor" type="submit" runat="server" onserverclick="btnTextColor_ServerClick"  class="btn btn-lg btn-info btn-block">
                                <i class="fa fa-cloud-upload	 fa-lg"></i>&nbsp;
                                             
                                <span>Update</span>
                            </button>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>

    <script>

        $('#BGDark_outter').colorpicker();
        $('#BGContact_Outter').colorpicker();
        $('#BGBackToTop_Outter').colorpicker();
        $('#FontColorLight_Outter').colorpicker();
        $('#FontColorSlider_Outter').colorpicker();
        $('#FontColorContact_Outter').colorpicker();
        $('#FontColorFooter_Outter').colorpicker();
        $('#FontColorBackToTop_Outter').colorpicker();
    </script>

</asp:Content>
