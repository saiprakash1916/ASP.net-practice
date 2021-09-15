<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="Ticket.Success" %>

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
    <h2>Ticket Booked Successfully!!!</h2>
    <table class="table">
        <tr>
            <th>Name</th>
            <td><asp:Label runat="server" ID="lblValueName"></asp:Label></td>
        </tr>
        <tr>
            <th>Date</th>
            <td><asp:Label runat="server" ID="lblValueDate"></asp:Label></td>
        </tr>
        <tr>
            <th>Number of tickets</th>
            <td><asp:Label runat="server" ID="lblValueNumberofTickets"></asp:Label></td>
        </tr>
        <tr>
            <th>Ticket Type</th>
            <td><asp:Label runat="server" ID="lblValueTicketType"></asp:Label></td>
        </tr>
        <tr>
            <th>Event</th>
            <td><asp:Label runat="server" ID="lblvalueEvent"></asp:Label></td>
        </tr>
    </table>
</body>
</html>
