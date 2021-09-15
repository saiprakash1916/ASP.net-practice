<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminMember.aspx.cs" Inherits="BookStore.AdminMember" %>
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
                                    <h4>Member details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="Images/generaluser.png" width="100" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="container">
                            <div class="row">
                             <div class="col-md-3">
                                <label>Member ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control mr-1" ID="TextBox2" placeholder="ID" ></asp:TextBox>
                                        <asp:LinkButton runat="server" CssClass="btn btn-primary" ID="LinkButton4" OnClick="LinkButton4_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                    </div> 
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Full Name</label>
                                <div class="form-group">
                                     <asp:TextBox runat="server" class="form-control" ID="TextBox1" placeholder="Full Name" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-5">
                                <label>Account Status</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control mr-1" ID="TextBox7" placeholder="Status" ReadOnly="True"></asp:TextBox> 
                                        <asp:LinkButton runat="server" CssClass="btn btn-success mr-1" ID="LinkButton1" OnClick="LinkButton1_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                        <asp:LinkButton runat="server" CssClass="btn btn-warning mr-1" ID="LinkButton2" OnClick="LinkButton2_Click"><i class="fas fa-pause-circle"></i></asp:LinkButton>
                                        <asp:LinkButton runat="server" CssClass="btn btn-danger mr-1" ID="LinkButton3" OnClick="LinkButton3_Click"><i class="fas fa-times-circle"></i></asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                        </div>
                        <div class="row">
                                <div class="col-md-4">
                                <label>DOB</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox3" placeholder="DOB" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Contact Number</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox4" placeholder="Contact Number" ReadOnly="True"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Email ID</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox8" placeholder="Email ID" ReadOnly="True"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                                <div class="col-md-4">
                                <label>State</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox9" placeholder="State" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>City</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox10" placeholder="City" ReadOnly="True"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Pin Code</label>
                                <div class="form-group">
                                   <div class="input-group">
                                        <asp:TextBox runat="server" class="form-control" ID="TextBox11" placeholder="Pin Code" ReadOnly="True"></asp:TextBox>
                                   </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                                <div class="col-md-12">
                                <label>Full Postal Address</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox5" placeholder="Full Postal Address" TextMode="MultiLine" ReadOnly="True" Rows="2"></asp:TextBox>
                                </div>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col">
                                <asp:Button runat="server" ID="Button2" Text="Delete User Permantely" CssClass="btn btn-danger col-md-12" OnClick="Button2_Click" />
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
                                    <h4>Member List</h4>
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
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [member_master_tbl]"></asp:SqlDataSource>
                                <asp:GridView runat="server" ID="Gridview1" class="table table-striped tabel-bordered" AutoGenerateColumns="False" DataKeyNames="menber_id" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="menber_id" HeaderText="ID" ReadOnly="True" SortExpression="menber_id" />
                                        <asp:BoundField DataField="full_name" HeaderText="Name" SortExpression="full_name" />
                                        <asp:BoundField DataField="account_status" HeaderText="Status" SortExpression="account_status" />
                                        <asp:BoundField DataField="contact_no" HeaderText="Contact" SortExpression="contact_no" />
                                        <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                                        <asp:BoundField DataField="state" HeaderText="State" SortExpression="state" />
                                        <asp:BoundField DataField="city" HeaderText="City" SortExpression="city" />
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
