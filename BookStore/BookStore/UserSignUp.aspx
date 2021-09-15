<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserSignUp.aspx.cs" Inherits="BookStore.UserSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="Images/generaluser.png" width="100" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>User Registration</h4>
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
                                <label>Full Name</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox1" placeholder="Full Name"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Date of Birth</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox2" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label>Contact Number</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox3" placeholder="Contact Numbe" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Email ID</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox4" placeholder="Email Id"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>State</label>
                                <div class="form-group">
                                   <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                      <asp:ListItem Text="Select" Value="select" />
                                      <asp:ListItem Text="Andhra Pradesh" Value="Andhra Pradesh" />
                                      <asp:ListItem Text="Arunachal Pradesh" Value="Arunachal Pradesh" />
                                      <asp:ListItem Text="Assam" Value="Assam" />
                                      <asp:ListItem Text="Bihar" Value="Bihar" />
                                      <asp:ListItem Text="Chhattisgarh" Value="Chhattisgarh" />
                                      <asp:ListItem Text="Rajasthan" Value="Rajasthan" />
                                      <asp:ListItem Text="Goa" Value="Goa" />
                                      <asp:ListItem Text="Gujarat" Value="Gujarat" />
                                      <asp:ListItem Text="Haryana" Value="Haryana" />
                                      <asp:ListItem Text="Himachal Pradesh" Value="Himachal Pradesh" />
                                      <asp:ListItem Text="Jammu and Kashmir" Value="Jammu and Kashmir" />
                                      <asp:ListItem Text="Jharkhand" Value="Jharkhand" />
                                      <asp:ListItem Text="Karnataka" Value="Karnataka" />
                                      <asp:ListItem Text="Kerala" Value="Kerala" />
                                      <asp:ListItem Text="Madhya Pradesh" Value="Madhya Pradesh" />
                                      <asp:ListItem Text="Maharashtra" Value="Maharashtra" />
                                      <asp:ListItem Text="Manipur" Value="Manipur" />
                                      <asp:ListItem Text="Meghalaya" Value="Meghalaya" />
                                      <asp:ListItem Text="Mizoram" Value="Mizoram" />
                                      <asp:ListItem Text="Nagaland" Value="Nagaland" />
                                      <asp:ListItem Text="Odisha" Value="Odisha" />
                                      <asp:ListItem Text="Punjab" Value="Punjab" />
                                      <asp:ListItem Text="Rajasthan" Value="Rajasthan" />
                                      <asp:ListItem Text="Sikkim" Value="Sikkim" />
                                      <asp:ListItem Text="Tamil Nadu" Value="Tamil Nadu" />
                                      <asp:ListItem Text="Telangana" Value="Telangana" />
                                      <asp:ListItem Text="Tripura" Value="Tripura" />
                                      <asp:ListItem Text="Uttar Pradesh" Value="Uttar Pradesh" />
                                      <asp:ListItem Text="Uttarakhand" Value="Uttarakhand" />
                                      <asp:ListItem Text="West Bengal" Value="West Bengal" />
                                   </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>City</label>
                                <div class="form-group">
                                   <asp:TextBox class="form-control" ID="TextBox5" runat="server" placeholder="City"></asp:TextBox>
                                </div>
                          </div>
                        <div class="col-md-4">
                            <label>Pincode</label>
                            <div class="form-group">
                               <asp:TextBox class="form-control" ID="TextBox6" runat="server" placeholder="Pincode" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Full Address</label>
                                <asp:TextBox runat="server" CssClass="form-control" placeholder="Full Address" TextMode="MultiLine" Rows="2" ID="TextBox7"></asp:TextBox>
                             </div>
                        </div><br />
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <center><span class="badge rounded-pill bg-primary">Login Credentails</span></center>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label>MemberId</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox8" placeholder="Member ID"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox9" TextMode="Password" placeholder="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:Button runat="server" class="btn btn-success btn-lg btn-block col-md-12" Text="Sign Up" ID="Button1" OnClick="Button1_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <a href="homepage.aspx"> << Back to Home</a><br /><br />
            </div>
        </div>
    </div>
</asp:Content>
