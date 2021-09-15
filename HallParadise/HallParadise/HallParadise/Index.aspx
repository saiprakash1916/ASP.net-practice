<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HallParadise.Index" %>
<%@ Register Src="~/NewFooter.ascx" TagName="footer" TagPrefix="Tfooter"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Hall  Paradise</h1>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>  
                                <b>User ID: </b><span class="lblItem"><%# Eval("iUserId") %></span><br />  
                                <b>User Name: </b><span class="lblItem"><%# Eval("vUserName") %></span><br />  
                                <b>Role Name: </b><span class="lblItem"><%# Eval("vRoleName")%></span><br />  
                            </td>  
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
    <Tfooter:footer ID="footer1" runat="server" />
</body>
</html>
