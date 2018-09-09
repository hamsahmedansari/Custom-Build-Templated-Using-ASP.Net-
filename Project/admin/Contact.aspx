<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="admin_Contact" %>



<asp:Content ID="head" runat="server" ContentPlaceHolderID="head">


    <script>
        $(document).ready(function () {

            $(".change_text_of_header").html("Contact")
            $(".ci_li").removeClass("active");
            $(".cu_contact").addClass("active");
            $(".iframemap").attr("src", $(".custom_map").val());

            $(".custom_map").on('change', function () {
                $(".iframemap").attr("src", $(".custom_map").val());

            });

        });



    </script>
</asp:Content>


<asp:Content ID="body" runat="server" ContentPlaceHolderID="body">


    <div class="col-12 c-fadein">

        <div class="card">
            <div class="card-header">
                <strong class="card-title">Contact</strong>
            </div>
            <div class="card-body">
                <div id="">
                    <div class="card-body">
                        <hr>


                        <div>


                            <div class="container">

                                <div class="row">

                                    <div class="col-12">

                                        <div class="form-group">
                                            <label>Email</label>
                                            <input type="email" maxlength="50" id="txtEmail" runat="server" placeholder="Enter Email" class="form-control" />
                                        </div>

                                    </div>
                                    <div class="col-12">

                                        <div class="form-group">
                                            <label>Contact</label>
                                            <input type="text" id="txtContact" runat="server" placeholder="Enter Contact max 15" maxlength="15" class="form-control" />
                                        </div>

                                    </div>
                                    <div class="col-12">

                                        <div class="form-group">
                                            <label>Address</label>
                                            <textarea id="txtAddress" class="form-control" runat="server" style="height: 150px; resize: none;" maxlength="150" placeholder="Enter Address Max 150"></textarea>
                                        </div>

                                    </div>
                                     <div class="col-12">

                                        <div class="form-group">
                                            <label>Facebook</label>
                                            <input type="text" id="txtLinkFb" runat="server" placeholder="Enter Link " class="form-control" />
                                        </div>

                                    </div>
                                     <div class="col-12">

                                        <div class="form-group">
                                            <label>Twitter</label>
                                            <input type="text" id="txtLinkTwitter" runat="server" placeholder="Enter Link " class="form-control" />
                                        </div>

                                    </div>
                                     <div class="col-12">

                                        <div class="form-group">
                                            <label>Youtube</label>
                                            <input type="text" id="txtLinkYoutube" runat="server" placeholder="Enter Link " class="form-control" />
                                        </div>

                                    </div>
                                    <div class="col-12">

                                        <div class="form-group">
                                            <label>Map <sup>(Enter Embed Code Of Your Location)</sup>   </label>
                                            <span class="float-right"><a href="https://www.google.com/maps" target="_blank" class="text-primary float-left">CLICK HERE</a> &nbsp To Get Codes</span>
                                            <textarea id="txtMap" class="form-control custom_map" runat="server" style="height: 150px; resize: none;" placeholder="Enter Embed Code Of Your Location"></textarea>
                                        </div>

                                    </div>

                                    <div class="col-12">

                                        <label>This is Your Map</label>
                                        <div class="form-group embed-responsive embed-responsive-4by3" style="max-height: 150px;">
                                            <iframe class="iframemap" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d924244.0627424379!2d66.59496829665616!3d25.192146424327134!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3eb33e06651d4bbf%3A0x9cf92f44555a0c23!2sKarachi%2C+Pakistan!5e0!3m2!1sen!2s!4v1518849123137" width="600" height="450" frameborder="0" style="border: 0" allowfullscreen></iframe>
                                        </div>

                                    </div>
                                </div>

                            </div>

                            <button id="btnLogo" runat="server" onserverclick="btnLogo_ServerClick" type="button" class="btn btn-lg btn-info btn-block">
                                <i class="fa fa-cloud-upload	 fa-lg"></i>&nbsp;
                                             
                                <span>Change</span>
                            </button>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>


</asp:Content>
