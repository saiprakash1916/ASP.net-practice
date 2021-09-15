<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Project.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk="  crossorigin="anonymous"></script>
    <title>SignUp</title>
</head>
<body>
    <br />
    <br />
    <h1 class="text-center">SignUp</h1>
    <form id="form1" runat="server" class="container">
       <div class="row form-group">
        <div class="col-sm-2"><asp:Label runat="server">UserName:</asp:Label></div>
        <div class="col-sm-6"><asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox></div>
    </div>
    <div class="row form-group">
        <div class="col-sm-2"><asp:Label runat="server">Password:</asp:Label></div>
        <div class="col-sm-6"><asp:TextBox runat="server" ID="txtPass" TextMode="Password" CssClass="form-control"></asp:TextBox></div>
    </div>
        <div class="row">
            <div class="col-sm-2"><asp:Label runat="server">Role:</asp:Label></div>
            <div class="col-sm-6">
                <asp:DropDownList runat="server" ID="ddlRole" CssClass="form-control">
                    <asp:ListItem value="0">Select Role</asp:ListItem>
                    <asp:ListItem value="1">Admin</asp:ListItem>
                    <asp:ListItem value="2">Librarian</asp:ListItem>
                    <asp:ListItem value="3">Student</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="row pull-right">
             <div class="col-sm-2"><asp:Button runat="server" Text="SignIn" ID="btnSubmit" CssClass="btn btn-danger form-control" OnClick="btnSubmit_Click"/></div>
    </div>
    </form>
</body>
</html>
