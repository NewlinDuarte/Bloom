<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserCreation.aspx.cs" Inherits="Bloom.UserCreation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-9">
        <div class="col-md-12">
            <div class="col-md-12" style="padding-left: 0px">
                <asp:Label ID="Label2" runat="server" Text="User name:"></asp:Label>
            </div>
            <div class="col-md-12" style="padding-left: 0px">
                <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ErrorMessage="RequiredFieldValidator" ControlToValidate="UserNameTextBox" ValidationGroup="Save" ForeColor="Red">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="col-md-12">
            <div class="col-md-12" style="padding-left: 0px">
                <asp:Label ID="Label1" runat="server" Text="Password:"></asp:Label>
            </div>
            <div class="col-md-12" style="padding-left: 0px">
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="col-md-12">
            <div class="col-md-12" style="padding-left: 0px">
                <asp:Label ID="Label3" runat="server" Text="Confirm Password:"></asp:Label>
            </div>
            <div class="col-md-12" style="padding-left: 0px">
                <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" TextMode="Password" Wrap="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ConfirmPasswordTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </div>
        </div>
        <div class="col-md-12" style="padding-top: 5em">
            <asp:Button ID="ConfirmButton" class="btn btn-info" runat="server" Text="Confirm" OnClick="ConfirmButton_Click" ValidationGroup="Save" />
            <asp:Button ID="CleanButton" class="btn btn-danger" runat="server" Text="Clean" OnClick="CleanButton_Click" />
            <asp:Button ID="CancelButton" class="btn btn-warning" runat="server" Text="Cancel" />
            <asp:Label ID="SuccessLabel" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
    </div>
</asp:Content>
