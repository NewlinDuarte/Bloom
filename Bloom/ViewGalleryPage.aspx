<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewGalleryPage.aspx.cs" Inherits="Bloom.ViewGalleryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-9">
        <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="col-md-5" style="margin:1em">
                            <b>
                                <asp:Label ID="UserName" runat="server" Text='<%#Eval("Title") %>'></asp:Label>
                            </b>
                            <asp:HyperLink ID="RecentHyperLink1"  NavigateUrl='<%#  "~/ViewImagePage.aspx?ImageId=" + Eval("UploadId") %>'  runat="server" CssClass="thumbnails">
                                <asp:Image ID="RecentImage1" class="img-responsive " ImageUrl ='<%# Eval("Img") %>' alt="Chania" runat="server" />
                            </asp:HyperLink>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
    </div>
</asp:Content>
