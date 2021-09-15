 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="Project.ManageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped" AutoGenerateColumns="False" DataKeyNames="iUserId" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
    <Columns>
        <asp:BoundField DataField="iUserId" HeaderText="User Id" InsertVisible="False" ReadOnly="True" SortExpression="iUserId" />
        <asp:BoundField DataField="VUserName" HeaderText="User Name" SortExpression="VUserName" />
        <asp:BoundField DataField="iRoleId" HeaderText="Role" SortExpression="iRoleId" />
        <asp:TemplateField>
           <ItemTemplate>
               <asp:Button runat="server" Text="Edit" CssClass="btn btn-primary" CommandArgument='<%# Eval("iUserId") %>' CommandName="EditUser"/>
               <asp:Button runat="server" Text="Delete" CssClass="btn btn-danger" CommandArgument='<%# Eval("iUserId") %>' CommandName="DeleteUser"/>
           </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlConnectionString %>" SelectCommand="SELECT [iUserId], [VUserName], [iRoleId] FROM [userMst]"></asp:SqlDataSource>

</asp:Content>
