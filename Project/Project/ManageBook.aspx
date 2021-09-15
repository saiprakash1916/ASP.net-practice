<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageBook.aspx.cs" Inherits="Project.ManageBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="iBookId" DataSourceID="SqlDataSource1" CssClass="table table-striped" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="iBookId" HeaderText="Book Id" InsertVisible="False" ReadOnly="True" SortExpression="iBookId" />
            <asp:BoundField DataField="vBookName" HeaderText="Book Name" SortExpression="vBookName" />
            <asp:BoundField DataField="vAuthor" HeaderText="Author" SortExpression="vAuthor" />
            <asp:TemplateField>
           <ItemTemplate>
               <asp:Button runat="server" Text="Edit" CssClass="btn btn-primary" CommandArgument='<%# Eval("iBookId") %>' CommandName="EditBook"/>
               <asp:Button runat="server" Text="Delete" CssClass="btn btn-danger" CommandArgument='<%# Eval("iBookId") %>' CommandName="DeleteBook"/>
           </ItemTemplate>
        </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlConnectionString %>" SelectCommand="SELECT [iBookId], [vBookName], [vAuthor] FROM [BookMst]"></asp:SqlDataSource>

</asp:Content>
