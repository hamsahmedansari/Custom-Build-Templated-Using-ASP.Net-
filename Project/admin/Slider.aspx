<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/admin.master" CodeFile="Slider.aspx.cs" Inherits="admin_Slider" %>

<asp:Content ID="head" runat="server" ContentPlaceHolderID="head">


    <script>
        $(document).ready(function () {

            $(".change_text_of_header").html("Slider")
            $(".ci_li").removeClass("active");
            $(".cu_slider").addClass("active");

        });
    </script>
</asp:Content>


<asp:Content ID="body" runat="server" ContentPlaceHolderID="body">


    <asp:ListView ID="listSlider" runat="server" OnItemEditing="listSlider_ItemEditing">

        <LayoutTemplate>
            <span cellpadding="20" runat="server" cellspacing="50" id="tblProducts">
                <span runat="server" id="groupPlaceholder">
                </span>

            </span>
        </LayoutTemplate>
        <GroupTemplate>
            <span class="text-center" runat="server" id="productRow">
                <span runat="server" id="itemPlaceHolder"></span>
            </span>
        </GroupTemplate>
        <ItemTemplate>
            <!-- post -->
            <div class="col-xl-6 col-lg-6 col-sm-12 col-12 c-fadein">

                <div class="card">
                    <div class="card-header">
                        <strong class="card-title">Slider <asp:Label runat="server" ID="txtID" Text='<%# Eval("id") %>'></asp:Label> </strong>
                    </div>
                    <div class="card-body">
                        <div id="">
                            <div class="card-body">
                                <div class="card-title">
                                    <img src='<%# "../Images/" + Eval("strSliderImage") %>' style="max-height: 150px;" runat="server" id="imgSlider1" class="img-thumbnail" alt="" />
                                </div>
                                <hr>


                                <div>

                                    <div class="form-contol">
                                        <label>Update Slider (1253x404)</label>
                                        <%--<input type="file" runat="server" id="txtSlider" accept="image/*" name="Logo" class="form-control-file" >--%>
                                        <asp:FileUpload  runat="server" id="txtSlider" accept="image/*" CssClass="form-control-file"  />
                                        <asp:HiddenField ID="txtsliderimghidden" runat="server" Value='<%# Eval("strSliderImage") %>' />
                                        </div>
                                    <br />
                                    <div class="form-group">
                                        <label>Heading</label>
                                        <asp:TextBox type="text" id="txtSliderHeading" runat="server" placeholder="Max Heading 15" maxlength="15" class="form-control" Text='<%# Eval("strSliderHeading") %>' />
                                    </div>
                                    <div class="form-group">
                                        <label>Description</label>
                                        <%--<textarea id="txtSliderDescription" runat="server" placeholder="Max Description 200" maxlength="200" class="form-control" style="height: 150px; resize: none;" value='<%# Eval("strSliderDescription") %>'></textarea>--%>
                                        <asp:TextBox id="txtSliderDescription" TextMode="MultiLine" runat="server" placeholder="Max Description 200" MaxLength="200" CssClass="form-control" style="height: 150px; resize: none;" Text='<%# Eval("strSliderDescription") %>'></asp:TextBox>
                                    </div>
                                   <%-- <button id="btnLogo" runat="server" type="button" class="btn btn-lg btn-info btn-block">
                                        <i class="fa fa-cloud-upload	 fa-lg"></i>&nbsp;
                                             
                                <span>Change</span>
                                    </button>--%>
                                    <asp:Button runat="server" ID="btnUpdate" CommandName="Edit" CssClass="btn btn-lg btn-info btn-block" Text=" Update" />
                                </div>
                            </div>
                        </div>

                    </div>
                </div>

            </div>
        </ItemTemplate>
    </asp:ListView>

    <%--<div class="col-xl-6 col-lg-6 col-sm-12 col-12 c-fadein">

        <div class="card">
            <div class="card-header">
                <strong class="card-title">Slider 2 </strong>
            </div>
            <div class="card-body">
                <div id="">
                    <div class="card-body">
                        <div class="card-title">
                            <img src="../img/3.jpg" class="img-thumbnail" alt="" />
                        </div>
                        <hr>


                        <div>

                            <div class="form-contol">
                                <label>Update Slider (1253x404)</label>
                                <input type="file" runat="server" id="File1" accept="image/*" name="Logo" class="form-control-file">
                            </div>
                            <br />
                            <div class="form-group">
                                <label>Heading</label>
                                <input type="text" id="Text1" runat="server" placeholder="Max Heading 15" maxlength="15" class="form-control" value="" />
                            </div>
                            <div class="form-group">
                                <label>Description</label>
                                <textarea id="Textarea1" runat="server" placeholder="Max Description 200" maxlength="200" class="form-control" style="height:150px;resize:none;"></textarea>
                            </div>
                            <button id="Button1" runat="server" type="button" class="btn btn-lg btn-info btn-block">
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

        <div class="card">
            <div class="card-header">
                <strong class="card-title">Slider 3 </strong>
            </div>
            <div class="card-body">
                <div id="">
                    <div class="card-body">
                        <div class="card-title">
                            <img src="../img/3.jpg" class="img-thumbnail" alt="" />
                        </div>
                        <hr>


                        <div>

                            <div class="form-contol">
                                <label>Update Slider (1253x404)</label>
                                <input type="file" runat="server" id="File2" accept="image/*" name="Logo" class="form-control-file">
                            </div>
                            <br />
                            <div class="form-group">
                                <label>Heading</label>
                                <input type="text" id="Text2" runat="server" placeholder="Max Heading 15" maxlength="15" class="form-control" value="" />
                            </div>
                            <div class="form-group">
                                <label>Description</label>
                                <textarea id="Textarea2" runat="server" placeholder="Max Description 200" maxlength="200" class="form-control" style="height:150px;resize:none;"></textarea>
                            </div>
                            <button id="Button2" runat="server" type="button" class="btn btn-lg btn-info btn-block">
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

        <div class="card">
            <div class="card-header">
                <strong class="card-title">Slider 4 </strong>
            </div>
            <div class="card-body">
                <div id="">
                    <div class="card-body">
                        <div class="card-title">
                            <img src="../img/3.jpg" class="img-thumbnail" alt="" />
                        </div>
                        <hr>


                        <div>

                            <div class="form-contol">
                                <label>Update Slider (1253x404)</label>
                                <input type="file" runat="server" id="File3" accept="image/*" name="Logo" class="form-control-file">
                            </div>
                            <br />
                            <div class="form-group">
                                <label>Heading</label>
                                <input type="text" id="Text3" runat="server" placeholder="Max Heading 15" maxlength="15" class="form-control" value="" />
                            </div>
                            <div class="form-group">
                                <label>Description</label>
                                <textarea id="Textarea3" runat="server" placeholder="Max Description 200" maxlength="200" class="form-control" style="height:150px;resize:none;"></textarea>
                            </div>
                            <button id="Button3" runat="server" type="button" class="btn btn-lg btn-info btn-block">
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

        <div class="card">
            <div class="card-header">
                <strong class="card-title">Slider 5 </strong>
            </div>
            <div class="card-body">
                <div id="pay-">
                    <div class="card-body">
                        <div class="card-title">
                            <img src="../img/3.jpg" class="img-thumbnail" alt="" />
                        </div>
                        <hr>


                        <div>

                            <div class="form-contol">
                                <label>Update Slider (1253x404)</label>
                                <input type="file" runat="server" id="File4" accept="image/*" name="Logo" class="form-control-file">
                            </div>
                            <br />
                            <div class="form-group">
                                <label>Heading</label>
                                <input type="text" id="Text4" runat="server" placeholder="Max Heading 15" maxlength="15" class="form-control" value="" />
                            </div>
                            <div class="form-group">
                                <label>Description</label>
                                <textarea id="Textarea4" runat="server" placeholder="Max Description 200" maxlength="200" class="form-control" style="height:150px;resize:none;"></textarea>
                            </div>
                            <button id="Button4" runat="server" type="button" class="btn btn-lg btn-info btn-block">
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

        <div class="card">
            <div class="card-header">
                <strong class="card-title">Slider 6 </strong>
            </div>
            <div class="card-body">
                <div id="">
                    <div class="card-body">
                        <div class="card-title">
                            <img src="../img/3.jpg" class="img-thumbnail" alt="" />
                        </div>
                        <hr>


                        <div>

                            <div class="form-contol">
                                <label>Update Slider (1253x404)</label>
                                <input type="file" runat="server" id="File5" accept="image/*" name="Logo" class="form-control-file">
                            </div>
                            <br />
                            <div class="form-group">
                                <label>Heading</label>
                                <input type="text" id="Text5" runat="server" placeholder="Max Heading 15" maxlength="15" class="form-control" value="" />
                            </div>
                            <div class="form-group">
                                <label>Description</label>
                                <textarea id="Textarea5" runat="server" placeholder="Max Description 200" maxlength="200" class="form-control" style="height:150px;resize:none;"></textarea>
                            </div>
                            <button id="Button5" runat="server" type="button" class="btn btn-lg btn-info btn-block">
                                <i class="fa fa-cloud-upload	 fa-lg"></i>&nbsp;
                                             
                                <span>Change</span>
                            </button>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>--%>
</asp:Content>
