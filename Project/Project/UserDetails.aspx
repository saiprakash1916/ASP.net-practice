<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="Project.UserDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField  runat="server" ID="hdnUserId" Value="0"/>
    <asp:Label ID="lblTitle" runat="server">User Details</asp:Label>
    <br />
    <br />
    <div class="row">
        <div class="col-sm-4"><asp:Label ID="lblName" runat="server">Name:</asp:Label></div>
        <div class="col-sm-8"><asp:Label ID="lblNameValue" runat="server"></asp:Label></div> 
    </div>
    <div class="row" runat="server" visible="false" id="dvRole"> 
        <div class="col-sm-4"><asp:Label ID="lblRole" runat="server">Role:</asp:Label></div>
        <div class="col-sm-8">
            <asp:DropDownList runat="server" ID="ddlRole" CssClass="form-control">
                <asp:ListItem value="0">Select Role</asp:ListItem>
                    <asp:ListItem value="1">Admin</asp:ListItem>
                    <asp:ListItem value="2">Librarian</asp:ListItem>
                    <asp:ListItem value="3">Student</asp:ListItem>
                </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4"><asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Visible="false" CssClass="btn btn-primary"/></div>
    </div>
    <div class="row">
        <div class="col-sm-4"><asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="btn btn-danger" Visible="false" OnClientClick="return onDelete()"/></div>
    </div>
    <script>
        function onDelete() {
            return confirm("Do you want to delete this user");
        }
    </script>
    
</asp:Content>
