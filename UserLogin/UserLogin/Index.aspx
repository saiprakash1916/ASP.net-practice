<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UserLogin.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <center><h1>User Login</h1></center>
        <div class="container form-group">
           <div class="row form-group">
               <div class="col-sm-4"><asp:Label runat="server" Text="Enter username" ID="name"></asp:Label></div>
               <div class="col-sm-6"><asp:TextBox runat="server" name="username" ID="txtUsername" CssClass="form-control"></asp:TextBox></div>
           </div>
            <div class="row form-group">
               <div class="col-sm-4"><asp:Label runat="server" Text="Enter password" ID="password"></asp:Label></div>
               <div class="col-sm-6"><asp:TextBox runat="server" name="password" ID="txtPassword" CssClass="form-control" TextMode="Password"></asp:TextBox></div>
           </div>
            <div class="col-sm-4">
                <asp:Button runat="server" ID="submit" Text="Submit" OnClick="submit_Click" CssClass="btn btn-primary"/>
            </div>
        </div>
    </form>
</body>
</html>
