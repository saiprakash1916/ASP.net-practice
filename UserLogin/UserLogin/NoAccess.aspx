<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NoAccess.aspx.cs" Inherits="UserLogin.NoAccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div class="container">
                <p class="text-danger">Access Denied</p><br />
                <asp:LinkButton runat="server" Text="Back" NavigateUrl="Display.aspx" ID="but1" OnClick="Back_Click"></asp:LinkButton>
            </div>
        </center>
    </form>
</body>
</html>
