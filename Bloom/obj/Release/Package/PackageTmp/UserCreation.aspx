<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserCreation.aspx.cs" Inherits="Bloom.UserCreation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-9">
        <div class="col-md-12">
            <div class="col-md-12" >
                <asp:Label ID="Label2" runat="server" Text="User name:"></asp:Label>
            </div>
            <div class="col-md-12" >
                <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="UserNameTextBox" ValidationGroup="Save" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?&lt;![_.])$" ValidationGroup="Save">Only letters, numbers, _ or .</asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="col-md-12">
            <div class="col-md-12" >
                <asp:Label ID="Label1" runat="server" Text="Password:"></asp:Label>
            </div>
            <div class="col-md-12">
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$" ValidationGroup="Save">Minimum 8 characters at least 1 Alphabet and 1 Number and no special characters</asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="col-md-12">
            <div class="col-md-12" >
                <asp:Label ID="Label3" runat="server" Text="Confirm Password:"></asp:Label>
            </div>
            <div class="col-md-12" >
                <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" TextMode="Password" Wrap="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ConfirmPasswordTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PasswordTextBox" ControlToValidate="ConfirmPasswordTextBox" ErrorMessage="CompareValidator" ForeColor="Red" ValidationGroup="Save">Does not match</asp:CompareValidator>
            </div>
        </div>
        <div class="col-md-12" style="padding-top: 5em">
            <asp:Button ID="ConfirmButton" class="btn btn-info" runat="server" Text="Confirm" OnClick="ConfirmButton_Click" ValidationGroup="Save" />
            <asp:Button ID="CleanButton" class="btn btn-danger" runat="server" Text="Clean" OnClick="CleanButton_Click" />
            <asp:Label ID="SuccessLabel" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
    </div>
</asp:Content>
