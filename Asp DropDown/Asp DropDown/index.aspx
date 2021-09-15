<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Asp_DropDown.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Welcome to Hall Paradise</h1>
        <div class="row form-group">
            <div class="col-sm-2"><asp:Label ID="lblTicket" runat="server" Text="No. of tickets"></asp:Label></div>
            <div class="col-sm-4"><asp:TextBox ID="TicketNumber" runat="server" CssClass="form-control"></asp:TextBox></div>
            <div class="col-sm-4"><asp:RequiredFieldValidator runat="server" ControlToValidate="TicketNumber" ID="TicketError" ErrorMessage="Please enter the number of tickets" ForeColor="Red"></asp:RequiredFieldValidator></div>
        </div>
        <br />
        <div class="row form-group">
            <div class="col-sm-2"><asp:Label ID="lblType" runat="server" Text="Select the ticket type"></asp:Label></div>
            <div class="col-sm-4">
                <asp:DropDownList ID="TicketType" runat="server" OnSelectedIndexChanged="TicketType_Change" CssClass="form-control">
                    <asp:ListItem Value="0">Please Selete</asp:ListItem>
                    <asp:ListItem Value="1">Platinum</asp:ListItem>
                    <asp:ListItem Value="2">Gold</asp:ListItem>
                    <asp:ListItem Value="3">Silver</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-sm-4"><asp:RequiredFieldValidator runat="server" ControlToValidate="TicketType" ID="TicketTypeError" ErrorMessage="Please select a ticket type" ForeColor="Red"></asp:RequiredFieldValidator></div>
        </div>
       <div id="amount">
           <asp:ValidationSummary  runat="server"/>
       </div>
    </form>
</body>
</html>
