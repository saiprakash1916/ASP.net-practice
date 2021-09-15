<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingBooks.aspx.cs" Inherits="Project.AddingBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk="  crossorigin="anonymous"></script>
    <title>Adding Books</title>
</head>
<body>
    <br />
    <br />
    <h1 class="text-center">Adding Books to the Library</h1>
    <form id="form1" runat="server" class="container">
         <div class="row form-group">
            <div class="col-sm-2"><asp:Label runat="server">BookName:</asp:Label></div>
            <div class="col-sm-6"><asp:TextBox runat="server" ID="txtbookName" CssClass="form-control"></asp:TextBox></div>
        </div>
        <div class="row form-group">
            <div class="col-sm-2"><asp:Label runat="server">BookAuthor:</asp:Label></div>
            <div class="col-sm-6"><asp:TextBox runat="server" ID="txtbookAuthor" CssClass="form-control"></asp:TextBox></div>
    </div>
        <div class="row form-group">
            <div class="col-sm-2"><asp:Label runat="server">Book Available:</asp:Label></div>
             <div class="col-sm-6">
                 <asp:RadioButtonList ID="isBookAvailable" runat="server">
                    <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                    <asp:ListItem Text="No" Value="No"></asp:ListItem>
            </asp:RadioButtonList>
             </div>   
        </div>
        <div class="row pull-right">
             <div class="col-sm-2"><asp:Button runat="server" Text="Add Book" ID="btnAdd" CssClass="btn btn-danger form-control" OnClick="btnAdd_Click"/></div>
    </div>
    </form>
</body>
</html>
