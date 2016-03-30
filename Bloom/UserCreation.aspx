<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserCreation.aspx.cs" Inherits="Bloom.UserCreation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="height: 100%; width: 70%; ">
        <div class="col-md-12">
            <div class="col-md-12" style ="padding-left: 0px">
                <asp:Label ID="Label2" runat="server" Text="User name:"></asp:Label>
            </div>
            <div class="col-md-12" style ="padding-left: 0px">
                <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-12">
            <div class="col-md-12" style ="padding-left: 0px">
                <asp:Label ID="Label1" runat="server" Text="Password:"></asp:Label>
            </div>
            <div class="col-md-12" style ="padding-left: 0px">
                <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-12">
            <div class="col-md-12" style ="padding-left: 0px">
                <asp:Label ID="Label3" runat="server" Text="Confirm Password:"></asp:Label>
            </div>
            <div class="col-md-12" style ="padding-left: 0px">
                <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" Wrap="False"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-12" style ="padding-top: 5em">
            <asp:Button ID="ConfirmButton" class="btn btn-info" runat="server" Text="Confirm" />
            <asp:Button ID="CancelButton" class="btn btn-warning" runat="server" Text="Cancel" />
        </div>
    </div>
</asp:Content>
