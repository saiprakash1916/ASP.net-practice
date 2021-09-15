<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="User_Registation.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-beta/css/bootstrap.min.css" />
    <style>    
        h2 {
            color: #48237e;
            padding-left: 90px;
            margin: 20px 0px;
        }
        table {
            margin-left: 160px;
        }
        th, td {
            padding: 5px;
        }
        th {
            padding-right: 20px;
        }
        table, td, th, tr {
            border: 1px solid #000;
            border-collapse: collapse;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>User Registred Successfully!!!</h2>
    <table class="table">
        <tr>
            <th>Name</th>
            <td><asp:Label runat="server" ID="lblValueName"></asp:Label></td>
        </tr>
        <tr>
            <th>Username</th>
            <td><asp:Label runat="server" ID="lblValueUsername"></asp:Label></td>
        </tr>
        <tr>
            <th>Password</th>
            <td><asp:Label runat="server" ID="lblValuePassword"></asp:Label></td>
        </tr>
    </table>
        </div>
    </form>
</body>
</html>
