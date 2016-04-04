﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bloom.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .carousel-inner .active.left {
            left: -33%;
        }

        .carousel-inner .next {
            left: 33%;
        }

        .carousel-inner .prev {
            left: -33%;
        }

        .carousel-control.left, .carousel-control.right {
            background-image: none;
        }

        .item:not(.prev) {
            visibility: visible;
        }

        .item.right:not(.prev) {
            visibility: hidden;
        }

        .rightest {
            visibility: visible;
        }

        img {
            max-height: 150px;
            max-width: 100%;
        }

        .img-container {
            max-width: 302.5px;
            max-height: 150px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-9">
        <!-- Recent Carousel Title -->
        <div class="col-md-4">
            <h3>RECENT</h3>
        </div>
        <!--Recent Carousel -->
        <div class="col-md-10">
            <div class="carousel slide" id="myCarousel">
                <!-- Wrapper for slides -->
                <div class="carousel-inner">
                    <div class="item active">
                        <div class="col-lg-4 col-xs-4 col-md-3 col-sm-4 img-container">
                            <asp:HyperLink ID="RecentHyperLink1" data-field="2008" data-Id="0" NavigateUrl="~/ViewImagePage.aspx" runat="server" CssClass="thumbnails">
                                <asp:Image ID="RecentImage1" class="img-responsive " alt="Chania" runat="server" />
                            </asp:HyperLink>
                        </div>
                    </div>
                    <div class="item">
                        <div class="col-lg-4 col-xs-4 col-md-3 col-sm-4 img-container">
                            <asp:HyperLink ID="RecentHyperLink2" data-Id="0" NavigateUrl="~/ViewImagePage.aspx" runat="server" CssClass="thumbnails">
                                <asp:Image ID="RecentImage2" class="img-responsive" alt="Chania" runat="server" />
                            </asp:HyperLink>
                        </div>
                    </div>

                    <div class="item">
                        <div class="col-lg-4 col-xs-4 col-md-3 col-sm-4 img-container">
                            <asp:HyperLink ID="RecentHyperLink3" data-Id="0" NavigateUrl="~/ViewImagePage.aspx" runat="server" CssClass="thumbnails">
                                <asp:Image ID="RecentImage3" data-Id="0" class="img-responsive" alt="Flower" runat="server" />
                            </asp:HyperLink>
                        </div>
                    </div>

                    <div class="item">
                        <div class="col-lg-4 col-xs-4 col-md-3 col-sm-4 img-container">
                            <asp:HyperLink ID="RecentHyperLink4" data-Id="0" NavigateUrl="~/ViewImagePage.aspx" runat="server" CssClass="thumbnails">
                                <asp:Image ID="RecentImage4" data-Id="0" class="img-responsive" alt="Flower" runat="server" />
                            </asp:HyperLink>
                        </div>
                    </div>
                </div>

                <!-- Left and right controls -->
                <a class="left carousel-control" href="#myCarousel" data-slide="prev"><i class="glyphicon glyphicon-chevron-left"></i></a>
                <a class="right carousel-control" href="#myCarousel" data-slide="next"><i class="glyphicon glyphicon-chevron-right"></i></a>
            </div>
            <script type="text/javascript">
                $('.carousel .item').each(function () {
                    var next = $(this).next();
                    if (!next.length) {
                        next = $(this).siblings(':first');
                    }
                    next.children(':first-child').clone().appendTo($(this));

                    if (next.next().length > 0) {
                        next.next().children(':first-child').clone().appendTo($(this));
                    }
                    else {
                        $(this).siblings(':first').children(':first-child').clone().appendTo($(this));
                    }
                });
            </script>
        </div>

        <!-- Browse Carousel Title -->
        <div class="col-md-12">
            <a>
                <h3>BROWSE</h3>
            </a>
        </div>
        <!-- Random Image Area-->
        <div class="col-md-10">
            <div class="row">
                <div class="col-md-6 ">
                    <h4>UserName</h4>
                    <div class="col-lg-12 col-xs-12 col-md-12 col-sm-12 img-container">
                        <asp:HyperLink ID="RandomHyperLink1" NavigateUrl="~/ViewImagePage.aspx" runat="server" CssClass="thumbnails">
                            <asp:Image ID="RandomImage1" class="img-responsive " alt="Chania" runat="server" />
                        </asp:HyperLink>
                    </div>
                </div>
                <div class="col-md-6 ">
                    <h4>UserName</h4>
                    <div class="col-lg-12 col-xs-12 col-md-12 col-sm-12 img-container">
                        <asp:HyperLink ID="RandomHyperLink2" NavigateUrl="~/ViewImagePage.aspx" runat="server" CssClass="thumbnails">
                            <asp:Image ID="RandomImage2" class="img-responsive" alt="Chania" runat="server" />
                        </asp:HyperLink>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 ">
                    <h4>UserName</h4>
                    <div class="col-lg-12 col-xs-12 col-md-12 col-sm-12 img-container">
                        <asp:HyperLink ID="RandomHyperLink3" NavigateUrl="~/ViewImagePage.aspx" runat="server" CssClass="thumbnails">
                            <asp:Image ID="RandomImage3" class="img-responsive" alt="Flower" runat="server" />
                        </asp:HyperLink>
                    </div>
                </div>
                <div class="col-md-6 ">
                    <h4>UserName</h4>
                    <div class="col-lg-12 col-xs-12 col-md-12 col-sm-12 img-container">
                        <asp:HyperLink ID="RandomHyperLink4" NavigateUrl="~/ViewImagePage.aspx" runat="server" CssClass="thumbnails">
                            <asp:Image ID="RandomImage4" class="img-responsive" alt="Flower" runat="server" />
                        </asp:HyperLink>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
