<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SelectItem.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-beta/css/bootstrap.min.css" />
     <style>
         h2 {
            color: #48237e;
        }
         table {
            margin-top: 25px;
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
          <h2>Item Details</h2>  
            <table id="Itemtable">
	            <tbody>
                    <tr>
		                <th>S.No</th>
                        <th>Name</th>
                        <th>Type</th>
                        <th>Vendor</th>
	                </tr>
                    <tr>
		                <td>1</td>
                        <td><asp:LinkButton runat="server" Text="Projector" OnClick="Projector_Click" name="Projector" ></asp:LinkButton></td>
                        <td>Electronics</td>
                        <td>Alex</td>
                    </tr>
                    <tr>
		                <td>2</td>
                        <td><asp:LinkButton runat="server" Text="Table" OnClick="Table_Click" name="Table"></asp:LinkButton></td>
                        <td>Furniture</td>
                        <td>Cassandra</td>
                    </tr>
                    <tr>
		                <td>3</td>
                        <td><asp:LinkButton runat="server" Text="Balloon" OnClick="Balloon_Click" name="Balloon"></asp:LinkButton></td>
                        <td>Decorations</td>
                        <td>Smith</td>
                    </tr>
                    <tr>
		                <td>4</td>
                        <td><asp:LinkButton runat="server" Text="Candle" OnClick="Candle_Click" name="Candle"></asp:LinkButton></td>
                        <td>Decorations</td>
                        <td>John</td>
                    </tr>
                    <tr>
		                <td>5</td>
                        <td><asp:LinkButton runat="server" Text="Radio" OnClick="Radio_Click" name="Radio"></asp:LinkButton></td>
                        <td>Electronics</td>
                        <td>Williams</td>
                    </tr>
                    <tr>
		                <td>6</td>
                        <td><asp:LinkButton runat="server" Text="Pen" OnClick="Pen_Click" name="Pen"></asp:LinkButton></td>
                        <td>Stationaries</td>
                        <td>Joseph</td>
                    </tr>
                </tbody>
            </table>
            <asp:Label runat="server" ID="selectedItem"></asp:Label>
            </div>
        </form>
</body>
</html>
