<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UploadPage.aspx.cs" Inherits="Bloom.UploadPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-9">
        <div class="col-md-12">
            <div class="col-md-12">
                <div class="col-md-6" style="padding-bottom:2em">
                    <h4>Title:</h4>
                    <asp:TextBox ID="TitleTextBox" runat="server"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TitleTextBox" ErrorMessage="RequiredFieldValidator" ValidationGroup="Upload">*</asp:RequiredFieldValidator>
            </div>
            <div class="col-md-6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PhotoUpload" ErrorMessage="RequiredFieldValidator" Visible="false" ValidationGroup="Upload"></asp:RequiredFieldValidator>
                <asp:FileUpload ID="PhotoUpload" class="btn btn-info" runat="server" />

            </div>
            <div class="col-md-6">
                <asp:Button ID="UploadButton" class="btn btn-success" runat="server" Text="Upload" OnClick="UploadButton_Click" ValidationGroup="Upload" />
                <asp:Label ID="Label1" runat="server" Visible="false" Text="Label"></asp:Label>

            </div>



        </div>
    </div>
</asp:Content>
