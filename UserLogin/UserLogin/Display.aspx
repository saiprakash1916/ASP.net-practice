<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="UserLogin.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <center><h1 class="text-success">User Action</h1>
            <div>
                <asp:LinkButton runat="server" ID="but1" Text="Book event" OnClick="Book_Event"></asp:LinkButton><br />
                <asp:LinkButton runat="server" ID="LinkButton1" Text="Create event" OnClick="Create_Event"></asp:LinkButton><br />
                <asp:LinkButton runat="server" ID="LinkButton2" Text="Add item" OnClick="Add_Item"></asp:LinkButton><br />
                <asp:LinkButton runat="server" ID="LinkButton3" Text="Allocate hall" OnClick="Allocate_Hall"></asp:LinkButton>
            </div>
        </center>
    </form>
</body>
</html>
