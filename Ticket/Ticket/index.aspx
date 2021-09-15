<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Ticket.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
       <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
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
        #Submit {
            height: auto !important;
            margin-left: 90px;
            background-color: #48237e;
        }
    </style>
</head>
<body>
    <div class="container" runat="server">
        <h2>Ticket Booking</h2>
        <form runat="server" id="form" >
             <div class="row form-group">
                 <div class="col-sm-2"><asp:Label runat="server" Text="Name:"></asp:Label></div>
                 <div class="col-sm-4"><asp:TextBox ID="Name" runat="server" CssClass="form-control"></asp:TextBox></div>
                 <div class="col-sm-6"><asp:RequiredFieldValidator ID="NameError" runat="server" ControlToValidate="Name" ErrorMessage="Please enter a name"></asp:RequiredFieldValidator></div>
             </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Date:"></asp:Label></div>
                <div class="col-sm-4"><asp:TextBox ID="Date" runat="server" CssClass="form-control"></asp:TextBox></div>
                <div class="col-sm-6"><asp:RequiredFieldValidator ID="DateErroe" runat="server" ControlToValidate="Date" ErrorMessage="Please choose a date"></asp:RequiredFieldValidator></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Number of tickets:"></asp:Label></div>
                <div class="col-sm-4"><asp:TextBox ID="Tickets" runat="server" CssClass="form-control"></asp:TextBox></div>
                <div class="col-sm-6"><asp:RequiredFieldValidator ID="TicketError" runat="server" ControlToValidate="Tickets" ErrorMessage="Please number of tickets"></asp:RequiredFieldValidator></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Ticket Type:"></asp:Label></div>
                <div class="col-sm-4">
                    <asp:DropDownList runat="server" ID="ddlTicketType" CssClass="form-control">
                        <asp:ListItem Value="0">Ticket Type</asp:ListItem>
                        <asp:ListItem Value="1">Platinum</asp:ListItem>
                        <asp:ListItem Value="2">Gold</asp:ListItem>
                        <asp:ListItem Value="3">Normal</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-sm-6"><asp:RequiredFieldValidator ID="TicketTypeError" runat="server" ControlToValidate="ddlTicketType" ErrorMessage="Please choose a ticket type"></asp:RequiredFieldValidator></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2"><asp:Label runat="server" Text="Event:"></asp:Label></div>
                <div class="col-sm-4">
                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlEventType">
                        <asp:ListItem Value="0">Event Type</asp:ListItem>
                        <asp:ListItem Value="1">Rio Carnival</asp:ListItem>
                        <asp:ListItem Value="2">Dancing</asp:ListItem>
                        <asp:ListItem Value="3">Others</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-sm-6"><asp:RequiredFieldValidator ID="EventError" runat="server" ControlToValidate="ddlEventType" ErrorMessage="Please choose a event type"></asp:RequiredFieldValidator></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-4"><asp:Button runat="server" Text="Submit" ID="submit" OnClick="submit_Click"/></div>
            </div>
        </form>
        <asp:Label runat="server" ID="lblName"></asp:Label>
        <asp:Label runat="server" ID="lblDate"></asp:Label>
        <asp:Label runat="server" ID="lblNoofTicket"></asp:Label>
        <asp:Label  runat="server" ID="lblTicketType"></asp:Label>
        <asp:Label runat="server" ID="lblEventType"></asp:Label>
    </div>
</body>
</html>
