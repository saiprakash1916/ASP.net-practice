<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="Project.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField  runat="server" ID="hdnUserId" Value="0"/>
    <asp:Label ID="lblTitle" runat="server">Book Details</asp:Label>
    <br />
    <br />
    <div class="row form-group">
            <div class="col-sm-2"><asp:Label runat="server">BookName:</asp:Label></div>
            <div class="col-sm-6"><asp:TextBox runat="server" ID="lblbookName" CssClass="form-control"></asp:TextBox></div>
        </div>
        <div class="row form-group">
            <div class="col-sm-2"><asp:Label runat="server">BookAuthor:</asp:Label></div>
            <div class="col-sm-6"><asp:TextBox runat="server" ID="lblbookAuthor" CssClass="form-control"></asp:TextBox></div>
    </div>
        <div class="row">
             <div class="col-sm-4"><asp:Button runat="server" Text="Edit Book" Visible="false" ID="btnEdit" CssClass="btn btn-success form-control" OnClick="btnEdit_Click"/></div>
    </div>
    <div class="row">
             <div class="col-sm-4"><asp:Button runat="server" Text="Delete Book" Visible="false" ID="btnDelete" CssClass="btn btn-danger form-control" OnClick="btnDelete_Click"/></div>
    </div>
</asp:Content>
