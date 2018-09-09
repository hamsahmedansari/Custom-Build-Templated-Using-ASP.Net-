<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Navigation.aspx.cs" Inherits="admin_Navigation" %>

<asp:Content ID="head" runat="server" ContentPlaceHolderID="head">

   
    <script>
        $(document).ready(function () {

            $(".change_text_of_header").html("Navigation")
            $(".ci_li").removeClass("active");
            $(".cu_nav").addClass("active");



        });
    </script>
</asp:Content>


<asp:Content ID="body" runat="server" ContentPlaceHolderID="body">


    <div class="col-12 c-fadein">

        <div class="card">
            <div class="card-body">
                <div id="">
                    <div class="card-body">
                        <div class="card-title">
                            NavBar
                        </div>
                        <hr>


                        <div>


                            <div class="container">

                                <div class="row">
                                    
                                    <div class="col-6">
                                        
                                        <div class="form-group">
                                            <label>Nav 1</label>
                                            <input type="text" id="txtNav1" runat="server" placeholder="Max 10" maxlength="10" class="form-control" value="Home" disabled />
                                        </div>

                                    </div>
                                    <div class="col-6">
                                        
                                        <div class="form-group">
                                            <label>Nav 2</label>
                                            <input type="text" id="txtNav2" runat="server" placeholder="Max 10" maxlength="10" class="form-control" value=""  />
                                        </div>

                                    </div>
                                    <div class="col-6">
                                        
                                        <div class="form-group">
                                            <label>Nav 3</label>
                                            <input type="text" id="txtNav3" runat="server" placeholder="Home" maxlength="10" class="form-control" value="Gallery" disabled  />
                                        </div>

                                    </div>
                                    <div class="col-6">
                                        
                                        <div class="form-group">
                                            <label>Nav 4</label>
                                            <input type="text" id="txtNav4" runat="server" placeholder="Max 10" maxlength="10" class="form-control" value=""  />
                                        </div>

                                    </div>
                                    <div class="col-6">
                                        
                                        <div class="form-group">
                                            <label>Nav 5</label>
                                            <input type="text" id="txtNav5" runat="server" placeholder="Home" maxlength="10" class="form-control" value=""  />
                                        </div>

                                    </div>
                                    <div class="col-6">
                                        
                                        <div class="form-group">
                                            <label>Nav 6</label>
                                            <input type="text" id="txtNav6" runat="server" placeholder="Max 10" maxlength="10" class="form-control" value="Contact" disabled  />
                                        </div>

                                    </div>

                                </div>

                            </div>

                            <button id="btnLogo" runat="server" type="button" onserverclick="btnLogo_ServerClick" class="btn btn-lg btn-info btn-block">
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
