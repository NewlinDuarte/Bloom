<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewImagePage.aspx.cs" Inherits="Bloom.ViewImagePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView2" runat="server"
        Font-Names="Arial" Caption="Using ImageControl">
    </asp:GridView>
    <asp:Image ID="Image1" runat="server" AlternateText="Image text"  Visible ="True" />

    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
</asp:Content>
