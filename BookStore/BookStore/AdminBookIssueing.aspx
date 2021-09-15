<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminBookIssueing.aspx.cs" Inherits="BookStore.AdminBookIssueing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Book Issuing</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="Images/books.png" width="100" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                             <div class="col-md-6">
                                <label>Member ID</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox2" placeholder="ID" ></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Book ID</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox1" placeholder="ID"></asp:TextBox>
                                        <asp:Button runat="server" class="btn btn-primary" ID="Button1" Text="Go" OnClick="Button1_Click"/>
                                   </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                                <div class="col-md-6">
                                <label>Member Name</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox3" placeholder="Member Name" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Book Name</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox4" placeholder="Book Name" ReadOnly="True"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                                <div class="col-md-6">
                                <label>Start Date</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox5" placeholder="Member Name" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>End Date</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox6" placeholder="Book Name" TextMode="Date"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-6">
                                <asp:Button runat="server" ID="Button2" Text="Issue" CssClass="btn btn-primary" OnClick="Button2_Click" />
                            </div>
                            <div class="col-md-6">
                                <asp:Button runat="server" ID="Button3" Text="Return" CssClass="btn btn-success" OnClick="Button3_Click" />
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
                                    <h4>Issued Book List</h4>
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
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [book_issue_tbl]"></asp:SqlDataSource>
                                <asp:GridView runat="server" ID="Gridview1" class="table table-striped tabel-bordered" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowDataBound="Gridview1_RowDataBound">
                                    <Columns>
                                        <asp:BoundField DataField="member_id" HeaderText="Member ID" SortExpression="member_id" />
                                        <asp:BoundField DataField="member_name" HeaderText="Member Name" SortExpression="member_name" />
                                        <asp:BoundField DataField="book_id" HeaderText="Book ID" SortExpression="book_id" />
                                        <asp:BoundField DataField="book_name" HeaderText="Book Name" SortExpression="book_name" />
                                        <asp:BoundField DataField="issue_date" HeaderText="Issue Date" SortExpression="issue_date" />
                                        <asp:BoundField DataField="due_date" HeaderText="Due Date" SortExpression="due_date" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <a href="homepage.aspx"> << Back to Home</a><br /><br />
    </div><br />
</asp:Content>
