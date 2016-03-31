<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bloom.Default" %>

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


    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row ">
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
                        <div class="col-lg-4 col-xs-4 col-md-3 col-sm-4">
                            <a href="#">
                                <img src="http://placehold.it/350x150" class="img-responsive" alt="Chania" /></a>
                        </div>
                    </div>

                    <div class="item">
                        <div class="col-lg-4 col-xs-4 col-md-3 col-sm-4">
                            <a href="#">
                                <img src="http://placehold.it/350x150" class="img-responsive" alt="Chania" /></a>
                        </div>
                    </div>

                    <div class="item">
                        <div class="col-lg-4 col-xs-4 col-md-3 col-sm-4">
                            <a href="#">
                                <img src="http://placehold.it/350x150" class="img-responsive" alt="Flower" /></a>
                        </div>
                    </div>

                    <div class="item">
                        <div class="col-lg-4 col-xs-4 col-md-3 col-sm-4">
                            <a href="#">
                                <img src="http://placehold.it/700x150" class="img-responsive" alt="Flower" /></a>
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
                <a><h3>BROWSE</h3></a>           
        </div>
        <!-- Random Image Area-->
        <div class="col-md-10">
            <div class="col-md-6 ">
                <h4>UserName</h4>
                <a href="#">
                    <img src="http://placehold.it/450x150" class="center-block img-responsive" alt="Flower" /></a>
            </div>
            <div class="col-md-6 ">
                <h4>UserName</h4>
                <a href="#">
                    <img src="http://placehold.it/450x150" class=" center-block img-responsive" alt="Flower" /></a>
            </div>
            <div class="col-md-6 ">
                <h4>UserName</h4>
                <a href="#">
                    <img src="http://placehold.it/450x150" class=" center-block img-responsive" alt="Flower" /></a>
            </div>
            <div class="col-md-6 ">
                <h4>UserName</h4>
                <a href="#">
                    <img src="http://placehold.it/450x150" class="center-block img-responsive" alt="Flower" /></a>
            </div>
        </div>
    </div>
</asp:Content>
