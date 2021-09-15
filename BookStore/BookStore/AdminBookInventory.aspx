<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminBookInventory.aspx.cs" Inherits="BookStore.AdminBookInventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#imgview').attr('src', e.target.result);
                };
                reader.readAsDataURL(input.files[0]);
            };
        };
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
                                    <h4>Book Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="book_Inventory/books1.png" width="100" id="imgview"/>
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
                                <asp:FileUpload runat="server" class="form-control" ID="Fileupload1" onchange="readURL(this);"/>
                            </div>
                        </div>
                        <div class="row">
                             <div class="col-md-4">
                                <label>Member ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox2" placeholder="ID" ></asp:TextBox>
                                        <asp:Button runat="server" class="btn btn-primary" ID="Button1" Text="Go" OnClick="Button1_Click"/>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Book Name</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox1" placeholder="Book Name"></asp:TextBox> 
                                   </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                              <div class="col-md-4">
                                <label>Languages</label>
                                <div class="form-group">
                                    <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                                        <asp:ListItem Text="English" Value="English"></asp:ListItem>
                                        <asp:ListItem Text="Telugu" Value="Telugu"></asp:ListItem>
                                        <asp:ListItem Text="Hindi" Value="Hindi"></asp:ListItem>
                                        <asp:ListItem Text="French" Value="French"></asp:ListItem>
                                        <asp:ListItem Text="Urdu" Value="Urdu"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                  <label>Publisher</label>
                                <div class="form-group">
                                    <asp:DropDownList ID="DropDownList2" runat="server" class="form-control">
                                        <asp:ListItem Text="Publisher 1 " Value="Publisher1"></asp:ListItem>
                                        <asp:ListItem Text="Publisher 2" Value="Publisher2"></asp:ListItem>
                                        <asp:ListItem Text="Publisher 3" Value="Publisher3"></asp:ListItem>
                                        <asp:ListItem Text="Publisher 4" Value="Publisher4"></asp:ListItem>
                                        <asp:ListItem Text="Publisher 5" Value="Publisher5"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Author Name</label>
                                <div class="form-group">
                                    <asp:DropDownList ID="DropDownList3" runat="server" class="form-control">
                                        <asp:ListItem Text="A1" Value="a1"></asp:ListItem>
                                        <asp:ListItem Text="A2" Value="a2"></asp:ListItem>
                                        <asp:ListItem Text="A3" Value="a3"></asp:ListItem>
                                        <asp:ListItem Text="A4" Value="a4"></asp:ListItem>
                                        <asp:ListItem Text="A5" Value="a5"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <label>Publisher Date</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox3" runat="server" placeholder="Date" class="form-control" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Genre</label>
                                <div class="form-group">
                                   <div class="input-group">
                                       <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" class="form-control">
                                           <asp:ListItem Text="Action" Value="Action" />
                                          <asp:ListItem Text="Adventure" Value="Adventure" />
                                          <asp:ListItem Text="Comic Book" Value="Comic Book" />
                                          <asp:ListItem Text="Self Help" Value="Self Help" />
                                          <asp:ListItem Text="Motivation" Value="Motivation" />
                                          <asp:ListItem Text="Healthy Living" Value="Healthy Living" />
                                          <asp:ListItem Text="Wellness" Value="Wellness" />
                                          <asp:ListItem Text="Crime" Value="Crime" />
                                          <asp:ListItem Text="Drama" Value="Drama" />
                                          <asp:ListItem Text="Fantasy" Value="Fantasy" />
                                          <asp:ListItem Text="Horror" Value="Horror" />
                                          <asp:ListItem Text="Poetry" Value="Poetry" />
                                          <asp:ListItem Text="Personal Development" Value="Personal Development" />
                                          <asp:ListItem Text="Romance" Value="Romance" />
                                          <asp:ListItem Text="Science Fiction" Value="Science Fiction" />
                                          <asp:ListItem Text="Suspense" Value="Suspense" />
                                          <asp:ListItem Text="Thriller" Value="Thriller" />
                                          <asp:ListItem Text="Art" Value="Art" />
                                          <asp:ListItem Text="Autobiography" Value="Autobiography" />
                                          <asp:ListItem Text="Encyclopedia" Value="Encyclopedia" />
                                          <asp:ListItem Text="Health" Value="Health" />
                                          <asp:ListItem Text="History" Value="History" />
                                          <asp:ListItem Text="Math" Value="Math" />
                                          <asp:ListItem Text="Textbook" Value="Textbook" />
                                          <asp:ListItem Text="Science" Value="Science" />
                                          <asp:ListItem Text="Travel" Value="Travel" />
                                       </asp:ListBox>
                                   </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                                <div class="col-md-4">
                                <label>Edition</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox5" placeholder="Edition"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Book Cost(Per Unit)</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox6" placeholder="Book Cost" TextMode="Number"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Pages</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox4" placeholder="Pages" TextMode="Number"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                                <div class="col-md-4">
                                <label>Actual Stock</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox7" placeholder="Actual Stock" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Current Stock</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox8" placeholder="Current Stock" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Issued Books</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox9" placeholder="Issued Books" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <label>Book Description</label>
                                <asp:TextBox runat="server" class="form-control" ID="TextBox10" TextMode="MultiLine" placeholder="Book Description" Rows="2"></asp:TextBox>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-4">
                                <asp:Button runat="server" ID="Button4" Text="Add" CssClass="btn btn-success" OnClick="Button4_Click" />
                            </div>
                            <div class="col-md-4">
                                <asp:Button runat="server" ID="Button5" Text="Update" CssClass="btn btn-warning" OnClick="Button5_Click" />
                            </div>
                             <div class="col-md-4">
                                <asp:Button runat="server" ID="Button2" Text="Delete" CssClass="btn btn-danger" OnClick="Button2_Click" />
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
                            <div class="col">
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [book_master_tbl]"></asp:SqlDataSource>
                                <asp:GridView runat="server" ID="Gridview1" class="table table-striped tabel-bordered" AutoGenerateColumns="False" DataKeyNames="book_id" DataSourceID="SqlDataSource1">
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
    </div><br />
</asp:Content>
