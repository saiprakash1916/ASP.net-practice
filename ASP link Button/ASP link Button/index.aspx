<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ASP_link_Button.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
         h2 {
            text-align: center;
            color: #48237e;
        }
        .row {
            margin-top: 20px;
        }
        .table {
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h2>Stall Details</h2>
                <table id="StallTable">
                    <tbody>
                        <tr>
                            <th>S.No</th>
                            <th>Name</th>
                            <th>Type</th>
                            <th>Owner</th>
                            <th>Cost per day</th>
                        </tr>
                        <tr>
                            <td>1</td>
                            <td><asp:LinkButton runat="server" OnClick="Unnamed_Click" PostBackUrl="~/Display.aspx">Work and roll</asp:LinkButton></td>
                            <td>Promotinal Type</td>
                            <td>Elsa</td>
                            <td>3000</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td><asp:LinkButton runat="server" OnClick="Unnamed_Click1" PostBackUrl="~/Display.aspx">Plant of the graphs</asp:LinkButton></td>
                            <td>Maxima Type</td>
                            <td>Albert</td>
                            <td>5800</td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td><asp:LinkButton runat="server" OnClick="Unnamed_Click2" PostBackUrl="~/Display.aspx">Chez creation</asp:LinkButton></td>
                            <td>Promotinal Type</td>
                            <td>Samantha</td>
                            <td>1400</td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td><asp:LinkButton runat="server" OnClick="Unnamed_Click3" PostBackUrl="~/Display.aspx">Studio on sunshine</asp:LinkButton></td>
                            <td>Maxima Type</td>
                            <td>Cassandra</td>
                            <td>2650</td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td><asp:LinkButton runat="server" OnClick="Unnamed_Click4" PostBackUrl="~/Display.aspx">Food plaza max</asp:LinkButton></td>
                            <td>Maxima Type</td>
                            <td>Isabella</td>
                            <td>1980</td>
                        </tr>
                        <tr>
                            <td>6</td>
                            <td><asp:LinkButton runat="server" OnClick="Unnamed_Click5" PostBackUrl="~/Display.aspx">Madisoon lang stall</asp:LinkButton></td>
                            <td>Promotinal Type</td>
                            <td>William</td>
                            <td>1500</td>
                        </tr>
                    </tbody>
                </table>
            </center>
        </div>
    </form>
</body>
</html>
