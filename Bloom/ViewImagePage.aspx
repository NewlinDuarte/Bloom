<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewImagePage.aspx.cs" Inherits="Bloom.ViewImagePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<asp:GridView ID="GridView2" runat="server"
        Font-Names="Arial" Caption="Using ImageControl">
    </asp:GridView>--%>
    <div class="row" style="min-height: 300px">
        <asp:Table ID="Table1" runat="server">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell Width="20em" >NAME</asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox ID="CommentTextBox" runat="server"  Width="20em" MaxLength="140"  TextMode="MultiLine" style="resize:none" ></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click1" Text="Submit" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <div>
        <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="commentbox">
                        <b>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Name") %>'>'></asp:Label>
                        </b>
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Comment") %>'></asp:Label><br />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            </div>
    </div>
    <asp:Image ID="Image1" runat="server" AlternateText="Image text" Visible="True" />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
</asp:Content>
