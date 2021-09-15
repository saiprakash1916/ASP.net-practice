<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Userlogin.aspx.cs" Inherits="BookStore.Userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="Images/generaluser.png" width="150" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Member Login</h3>
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
                                <label>Member ID</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox1" placeholder="Member ID"></asp:TextBox>
                                </div>
                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" class="form-control" ID="TextBox2" placeholder="Password" TextMode="Password"></asp:TextBox>
                                </div><br />
                                <div class="form-group">
                                    <asp:Button runat="server" Text="Login" ID="Button1" class="btn btn-success btn-block btn-lg col-md-12" OnClick="Button1_Click" />
                                </div><br />
                                <div class="form-group">
                                    <a href="UserSignUp.aspx"><input type="button" id="Button2" value="Sign Up" class="btn btn-info btn-block btn-lg col-md-12" /></a>
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
