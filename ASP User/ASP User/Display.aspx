<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="ASP_User.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
  h2{
     color:#EC5578;
}
h1{
     color:#cf1531;
}
#Submit{
   width: 110px;
    font-weight: 600;
    background-color: #A95AB7;
    border: 0px;
    color: #fff;
    padding: 10px;
}
#eventDetails{
	
        padding-top: 20px;
        padding-bottom: 20px;
}
#userInput{
	background-color: #471e7fe0;
        width:560px;
        padding-top: 20px;
        padding-bottom: 20px;
        color:white;
}
  img{
        height:300px !important;
        width:400px;
    }
    .row{
        padding-top: 10px;
    }
    .name{
        font-size: 18px;
        color:#206737;
    }
</style>
</head>
<body>
     <center>
        <div>
            	<h2>User Registered Successfully</h2>
           
 	<table style="text-align: left;" border="1">
 		<tr>
 			<td>Name: </td>
 			<td><asp:Label runat="server" ID="Name"></asp:Label></td>
 		</tr>
 		<tr>
 			<td>Email: </td>
 			<td><asp:Label runat="server" ID="Email"></asp:Label></td>
		</tr>
 		<tr>
 			<td>Phone: </td>
 			<td><asp:Label runat="server" ID="Phone"></asp:Label></td>
 		</tr>
 		<tr>
 			<td>Location: </td>
 			<td><asp:Label runat="server" ID="Location"></asp:Label></td>
 		</tr>
         <tr>
 			<td>Gender : </td>
 			<td><asp:Label runat="server" ID="Gender"></asp:Label></td>
 		</tr>
         <tr>
 			<td>Language known : </td>
 			<td><asp:Label runat="server" ID="Language"></asp:Label></td>
 		</tr>
          <tr>
 			<td>Membership : </td>
 			<td><asp:Label runat="server" ID="Membership"></asp:Label></td>
 		</tr>
 	</table>
        </div>
   </center>
</body>
</html>
