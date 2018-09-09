<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Gallery.aspx.cs" Inherits="admin_Gallery" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderID="head">

    <script>
        $(document).ready(function () {

            $(".change_text_of_header").html("Gallery")
            $(".ci_li").removeClass("active");
            $(".cu_gallery").addClass("active");



        });
    </script>
</asp:Content>
<asp:Content runat="server" ID="body" ContentPlaceHolderID="body">


    <div class="col-12 c-fadein">

        <div class="card">
            <div class="card-body">
                <div id="">
                    <div class="card-body">
                        <div class="card-title">
                            Gallery
                            
                            <span class="float-right">1/20</span>
                        </div>
                        <hr>
                        <div class="card-title">
                            <button class="btn btn-primary" runat="server" onserverclick="btnaddnew_ServerClick" id="btnaddnew">
                                Add New
                            </button>
                            <button class="btn btn-primary" runat="server" id="btnUpdate" onserverclick="btnUpdate_ServerClick">
                                Update
                            </button>

                        </div>

                    </div>
                </div>

            </div>
        </div>

    </div>

    <asp:Panel ID="pnlAddNew" runat="server">

        <div class="col-12 c-fadein">

            <div class="card">
                <div class="card-body">
                    <div id="">
                        <div class="card-body">



                            <div>

                                <div class="row">

                                    <div class="col-12">

                                        <asp:FileUpload runat="server" ID="Add_upload_image" />
                                        
                                        <button class="bth btn-success" runat="server" id="addnew" onserverclick="addnew_ServerClick"> 
                                            Add New
                                        </button>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

        </div>


    </asp:Panel>



    <asp:Panel ID="pnlupdate" runat="server">

        <div class="col-12 c-fadein">

            <div class="card">
                <div class="card-body">
                    <div id="">
                        <div class="card-body">



                            <div>

                                <div class="row">

                                    <asp:ListView runat="server" ID="gallery" OnItemEditing="gallery_ItemEditing"  OnItemDeleting="gallery_ItemDeleting">
                                        <LayoutTemplate>
                                            <span runat="server" id="tblProducts">
                                                <span runat="server" id="groupPlaceholder"></span>
                                            </span>

                                        </LayoutTemplate>
                                        <GroupTemplate>
                                            <span runat="server" id="productRow">
                                                <span runat="server" id="itemPlaceholder"></span>
                                            </span>
                                        </GroupTemplate>
                                        <ItemTemplate>


                                            <div class="col-lg-6 col-md-6 col-sm-12 col-12 mt-3 mb-3 text-center">

                                                <img src='<%# "../Images/" + Eval("strImage") %>' style="max-height: 150px;" runat="server" id="imgSlider1" class="img-thumbnail img-fluid" alt="" />
                                                <br />
                                                <asp:HiddenField ID="txtID" runat="server" Value='<%# Eval("id") %>' />
                                                <asp:FileUpload runat="server" ID="upload_image" CssClass="float-right mt-5" />

                                                <asp:Button ID="btnLogo" CommandName="Edit" runat="server" type="button" Text="Change" class="btn btn-lg btn-info btn-block mt-3" />
                                                <asp:Button ID="btnDelete"  CommandName="Delete" runat="server" type="button" Text="Deleted" class="btn btn-lg btn-danger btn-block mb-3" />

                                                <%--<button id="btnLogo" runat="server" type="button" class="btn btn-lg btn-info btn-block mt-3 mb-3">
                                                <i class="fa fa-cloud-upload	 fa-lg"></i>&nbsp;
                                             
                                                    <span></span>
                                            </button>--%>
                                            </div>

                                        </ItemTemplate>
                                    </asp:ListView>

                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

        </div>

    </asp:Panel>






</asp:Content>
