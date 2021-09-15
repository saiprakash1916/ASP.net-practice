<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminAuthorManagement.aspx.cs" Inherits="BookStore.AdminAuthorManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Author Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="Images/writer.png" width="100" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Author ID</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox1" placeholder="ID"></asp:TextBox>
                                        <asp:Button runat="server" class="btn btn-primary" ID="Button1" Text="Go" OnClick="Button1_Click"/>
                                   </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Author Name</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox2" placeholder="Author Name" ></asp:TextBox>
                                </div>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-4">
                                <asp:Button runat="server" ID="Button2" Text="Add" CssClass="btn btn-success" OnClick="Button2_Click" />
                            </div>
                            <div class="col-md-4">
                                <asp:Button runat="server" ID="Button3" Text="Update" CssClass="btn btn-warning" OnClick="Button3_Click" />
                            </div>
                            <div class="col-md-4">
                                <asp:Button runat="server" ID="Button4" Text="Delete" CssClass="btn btn-danger" OnClick="Button4_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Author List</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [author_master_tbl]"></asp:SqlDataSource>
                                <asp:GridView runat="server" ID="Gridview1" class="table table-striped tabel-bordered" AutoGenerateColumns="False" DataKeyNames="author_id" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="author_id" HeaderText="author_id" ReadOnly="True" SortExpression="author_id" />
                                        <asp:BoundField DataField="author_name" HeaderText="author_name" SortExpression="author_name" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <a href="homepage.aspx"> << Back to Home</a><br /><br />
    </div>
</asp:Content>
