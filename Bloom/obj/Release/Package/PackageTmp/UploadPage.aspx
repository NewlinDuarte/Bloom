<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UploadPage.aspx.cs" Inherits="Bloom.UploadPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="height: 100%; width: 70%; min-height: 60em">
        <div class ="row">
            <div class="col-md-6"> 
                <asp:FileUpload ID="PhotoUpload" class="btn btn-info" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Button ID="UploadButton" class="btn btn-success" runat="server" Text="Upload" OnClick="UploadButton_Click" />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </div>


</asp:Content>
