<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="User_Registation.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-beta/css/bootstrap.min.css" />
    <style>
        input, select {
            width: 230px !important;
            height: 30px !important;
            padding-left: 5px;
        }
        .col-sm-3 {
            -ms-flex: 0 0 23%;
            flex: 0 0 23%;
            max-width: 23%;
        }
        .col-sm-2 {
            -ms-flex: 0 0 14%;
            flex: 0 0 14%;
            max-width: 14%;
        }
        h2 {
            color: #48237e;
            padding-left: 90px;
            margin: 20px 0px;
        }
        #Submit {
            height: auto !important;
            margin-left: 90px;
            background-color: #48237e;
        }
    </style>
</head>
<body>
    <div class="container">
        <h2>User Register</h2>
        <form class="form" runat="server">
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Name" ID="lblName"></asp:Label></div>
                <div class="col-sm-4"><asp:TextBox runat="server" ID="Name" placeholder="Name"></asp:TextBox></div>
                <div class="col-sm-6"><asp:RequiredFieldValidator runat="server" ID="NameError" ControlToValidate="Name" ErrorMessage="Please enter a name"></asp:RequiredFieldValidator> </div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Username" ID="lblUserName"></asp:Label></div>
                <div class="col-sm-4"><asp:TextBox runat="server" ID="Username" placeholder="Username"></asp:TextBox></div>
                <div class="col-sm-6"><asp:RequiredFieldValidator runat="server" ID="UserNameError" ControlToValidate="Username" ErrorMessage="Please enter a user name"></asp:RequiredFieldValidator> </div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Password" ID="lblPassword"></asp:Label></div>
                <div class="col-sm-4"><asp:TextBox runat="server" ID="Password" placeholder="Password"></asp:TextBox></div>
                <div class="col-sm-6"><asp:RequiredFieldValidator runat="server" ID="PasswordError" ControlToValidate="Password" ErrorMessage="Please enter a password"></asp:RequiredFieldValidator> </div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Confirm Password" ID="lblConfirmPassword"></asp:Label></div>
                <div class="col-sm-4"><asp:TextBox runat="server" ID="ConfirmPassword" placeholder="Confirm password"></asp:TextBox></div>
                <div class="col-sm-6"><asp:RequiredFieldValidator runat="server" ID="ConfirmPasswordError" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm password should match password"></asp:RequiredFieldValidator> </div>
            </div>
            <div class="row form-group">
                <asp:Button runat="server" ID="Submit" Text="Submit" OnClick="Submit_Click"/>    
            </div>
        </form>
    </div>
</body>
</html>
