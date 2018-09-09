<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Section4.aspx.cs" Inherits="admin_Section4" %>


<asp:Content ID="head" runat="server" ContentPlaceHolderID="head">


    <script>
        $(document).ready(function () {

            $(".change_text_of_header").html("Section 4")
            $(".ci_li").removeClass("active");
            $(".cu_section_4").addClass("active");

        });
    </script>
</asp:Content>


<asp:Content ID="body" runat="server" ContentPlaceHolderID="body">


    <div class="col-12 c-fadein">

        <div class="card">
            <div class="card-header">
                <strong class="card-title"><asp:Label Text="About" ID="header" runat="server"></asp:Label> </strong>
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
                                            <label>Heading</label>
                                            <input type="text" disabled id="txtAboutHeading" runat="server" placeholder="Max 30" maxlength="30" class="form-control" value="Section 4"  />
                                        </div>

                                    </div>
                                    <div class="col-12">

                                        <div class="form-group">
                                            <label>Description</label>
                                            <textarea id="txtAboutDescription" class="form-control" runat="server" style="height:150px;resize:none;" maxlength="500" placeholder="Max Description 500"></textarea>
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
