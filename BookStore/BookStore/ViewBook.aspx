<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewBook.aspx.cs" Inherits="BookStore.ViewBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
                <center>
                    <asp:GridView runat="server" ID="GridView1"></asp:GridView>
                </center>
                <div class="row">
                    <div class="col-md-12 col-sm-12">
                        <asp:Panel runat="server" class="alert alert-success" role="alert" ID="panel1" Visible="false">
                            <asp:Label runat="server" ID="lable1" Text="lable"></asp:Label>
                        </asp:Panel>                    
                    </div>
                </div><br />
            <div class="row">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Book Inventory List</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [book_master_tbl]"></asp:SqlDataSource>
                                <asp:GridView runat="server" ID="Gridview2" class="table table-striped tabel-bordered" AutoGenerateColumns="False" DataKeyNames="book_id" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="book_id" HeaderText="ID" ReadOnly="True" SortExpression="book_id" >
                                        <FooterStyle Font-Bold="True" />
                                        <ItemStyle Font-Bold="True" />
                                        </asp:BoundField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <div class="container-fluid">
                                                    <div class="row">
                                                        <div class="col-lg-10">
                                                            <div class="row">
                                                                <div class="col-12">
                                                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("booj_name") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-12">
                                                                    Author -<asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("author_name") %>'></asp:Label>
                                                                    &nbsp;| Genre -<asp:Label ID="Label3" runat="server" Font-Bold="True" Text='<%# Eval("genre") %>'></asp:Label>
                                                                    &nbsp;| Languages -<asp:Label ID="Label4" runat="server" Font-Bold="True" Text='<%# Eval("language") %>'></asp:Label>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-12">
                                                                    Publisher -<asp:Label ID="Label5" runat="server" Font-Bold="True" Text='<%# Eval("publisher_name") %>'></asp:Label>
                                                                    &nbsp;| Publish Date -<asp:Label ID="Label6" runat="server" Font-Bold="True" Text='<%# Eval("publish_date") %>'></asp:Label>
                                                                    &nbsp;| Pages -<asp:Label ID="Label7" runat="server" Font-Bold="True" Text='<%# Eval("no_of_pages") %>'></asp:Label>
                                                                    &nbsp;| Edition-<asp:Label ID="Label8" runat="server" Font-Bold="True" Text='<%# Eval("edition") %>'></asp:Label>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-12">
                                                                    Cost -<asp:Label ID="Label9" runat="server" Font-Bold="True" Text='<%# Eval("book_cost") %>'></asp:Label>
                                                                    &nbsp;| Actual Stock -<asp:Label ID="Label10" runat="server" Font-Bold="True" Text='<%# Eval("actual_stock") %>'></asp:Label>
                                                                    &nbsp;| Available -<asp:Label ID="Label11" runat="server" Text='<%# Eval("current_stock") %>'></asp:Label>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-12">
                                                                    Description -<asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Italic="True" Text='<%# Eval("book_description") %>'></asp:Label>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="col-lg-2">
                                                            <asp:Image ID="Image1" class="img-fluid p-2" runat="server" ImageUrl='<%# Eval("book_img_link") %>' />
                                                        </div>
                                                    </div>
                                                </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
          </div>
        <a href="homepage.aspx"> << Back to Home</a><br /><br />
</asp:Content>
