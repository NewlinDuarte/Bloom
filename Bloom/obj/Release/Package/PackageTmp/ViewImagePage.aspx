<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewImagePage.aspx.cs" Inherits="Bloom.ViewImagePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-9">
        <div class="row ">
            <asp:Image ID="Image1" CssClass="center-block" runat="server" AlternateText="Image text" Visible="True" />

        </div>
        <div class="row" style="min-height: 300px">
            <asp:LoginView ID="LoginView1" runat="server">
                <LoggedInTemplate>
                    <asp:Table ID="Table1" Style="margin: 0 auto; margin-top:2em;" runat="server">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>Comment</asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox ID="CommentTextBox" runat="server" Width="20em" MaxLength="140" TextMode="MultiLine" Style="resize: none"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click1" Text="Submit" />
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </LoggedInTemplate>
            </asp:LoginView>
            <div>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="commentbox" style="text-align: center">
                            <b>
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("Name") %>'>'></asp:Label>
                            </b>
                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("Comment") %>'></asp:Label><br />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>

</asp:Content>
