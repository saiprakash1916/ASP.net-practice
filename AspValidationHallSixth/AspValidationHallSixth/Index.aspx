<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspValidationHallSixth.Index" %>

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
        #Create {
            height: auto !important;
            margin-left: 90px;
            background-color: #48237e;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Hall Owner Registration</h2>
        <div class="container">
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Name"></asp:Label></div>
                <div class="col-sm-6"><asp:TextBox runat="server" ID="name" placeholder="Name"></asp:TextBox></div>
                <div class="col-sm-4"><asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter the name" ID="nameError" ControlToValidate="name"></asp:RequiredFieldValidator></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Email"></asp:Label></div>
                <div class="col-sm-6"><asp:TextBox runat="server" ID="email" placeholder="Email"></asp:TextBox></div>
                <div class="col-sm-4"><asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter the email" ID="emailError" ControlToValidate="email"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ValidationExpression="^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$" runat="server" ControlToValidate="email" ErrorMessage="Please enter the valid email"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Mobile Number"></asp:Label></div>
                <div class="col-sm-6"><asp:TextBox runat="server" ID="mobileNumber" placeholder="Mobile Number"></asp:TextBox></div>
                <div class="col-sm-4"><asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter the mobile number" ID="mobileNumberError" ControlToValidate="mobileNumber"></asp:RequiredFieldValidator></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Hall Name"></asp:Label></div>
                <div class="col-sm-6"><asp:TextBox runat="server" ID="hallName" placeholder="Name"></asp:TextBox></div>
                <div class="col-sm-4"><asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter the hall name" ID="hallNameError" ControlToValidate="hallName"></asp:RequiredFieldValidator></div>
            </div>
            <div class="col-sm-4">
                <asp:Button runat="server" Text="Create" ID="Create" OnClick="Create_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
