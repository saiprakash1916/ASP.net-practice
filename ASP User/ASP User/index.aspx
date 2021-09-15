<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ASP_User.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        h2 {
            color: #EC5578;
        }

        h1 {
            color: #cf1531;
        }

        #Submit {
            width: 110px;
            font-weight: 600;
            background-color: #A95AB7;
            border: 0px;
            color: #fff;
            padding: 10px;
        }

        #eventDetails {
            padding-top: 20px;
            padding-bottom: 20px;
        }

        #userInput {
            background-color: #471e7fe0;
            width: 560px;
            padding-top: 20px;
            padding-bottom: 20px;
            color: white;
        }

        img {
            height: 300px !important;
            width: 400px;
        }

        .row {
            padding-top: 10px;
        }

        .name {
            font-size: 18px;
            color: #206737;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div runat="server">
        <h2>User Registration</h2>
        <table runat="server">
            <tr>
                <td>Name : </td>
                <td><asp:TextBox runat="server" ID="Name" placeholder="Enter your name"></asp:TextBox></td>   
            </tr>
            <tr>
                <td>Email : </td>
                <td><asp:TextBox runat="server" ID="Email" placeholder="Enter your email"/></td>
            </tr>
            <tr>
                <td>Phone : </td>
                <td><asp:TextBox runat="server" ID="Phone" placeholder="Enter your phone"/></td>
            </tr>
            <tr>
                <td>Location : </td>
                <td><asp:TextBox runat="server" ID="Location" placeholder="Enter your location"/></td>
            </tr>
            <tr>
                <td>Gender : </td>
                <td>
                    <asp:RadioButtonList ID="gender" runat="server">
                        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:RadioButtonList>
                </td> 
            </tr>
            <tr>
                <td>Language known : </td>
                <td>
                    <asp:CheckBoxList runat="server" ID="languages">
                        <asp:ListItem Text="Tamil" Value="Tamil"></asp:ListItem>
                        <asp:ListItem Text="English" Value="English"></asp:ListItem>
                        <asp:ListItem Text="Hindi" Value="Hindi"></asp:ListItem>
                        <asp:ListItem Text="Telugu" Value="Telugu"></asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td>Membership</td>
                <td>
                    <asp:DropDownList runat="server" ID="Membership">
                        <asp:ListItem Value="1">Basic</asp:ListItem>
                        <asp:ListItem Value="2">Premium</asp:ListItem>
                        <asp:ListItem Value="3">Pro</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Button runat="server" ID="Submit" Text="Submit" OnClick="Submit_Click"/></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
