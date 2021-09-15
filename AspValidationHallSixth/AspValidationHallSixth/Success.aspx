<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="AspValidationHallSixth.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        <h2>Hall Owner Registred Successfully!!!</h2>
        <div class="conatiner">
            <table class="table" style="background-color:lightblue">
         <tr>
             <td>Name</td>
             <td><asp:Label runat="server" ID="lblNameValue"></asp:Label></td>
         </tr>
         <tr>
             <td>Email</td>
             <td><asp:Label runat="server" ID="lblEmailValue"></asp:Label></td>
         </tr>
         <tr>
             <td>Mobile Number</td>
             <td><asp:Label runat="server" ID="lblMobileValue"></asp:Label></td>
         </tr>
        <tr>
             <td>Hall Name</td>
             <td><asp:Label runat="server" ID="lblHallName"></asp:Label></td>
         </tr>
         
    </table>
        </div>
    </form>
</body>
</html>
