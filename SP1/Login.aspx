<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SP1.Login" %>
<link href="LoginStyle.css" rel="stylesheet" type="text/css" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
    <style>  
        body, html {
    height: 100%;
    margin: 0;
}

.bg {
    /* The image used */
    background-image: url("handcuffs-354042_1920.jpg");

    /* Full height */
    height: 100%; 

    /* Center and scale the image nicely */
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
}
    </style>
</head>
<body>
    <form id="form1" class="bg" runat="server">
    <asp:login id="Login1" runat="server" style="width: 100%;">
    <layouttemplate>
        <div class="box">
            <div class="content">
                <h1>Law Enforcement</h1>
                <h1>&</h1>
                <h1>Federal Investigation</h1>
                <h3>Authentication Required</h3>
                <asp:textbox class="field" placeholder="Operative User Name" id="UserName" runat="server"></asp:textbox>
                <asp:requiredfieldvalidator id="UserNameRequired" runat="server" controltovalidate="UserName" errormessage="User Name is required." tooltip="User Name is required." validationgroup="Login1" Font-Bold="True" ForeColor="Red">User Name is Required!</asp:requiredfieldvalidator>
                <br>
                <asp:textbox class="field" placeholder="Access Code" id="Password" runat="server" textmode="Password"></asp:textbox>
                <asp:requiredfieldvalidator id="PasswordRequired" runat="server" controltovalidate="Password" errormessage="Password is required." tooltip="Password is required." validationgroup="Login1" Font-Bold="True" Font-Italic="False" ForeColor="Red">Password is Required!</asp:requiredfieldvalidator>
                <br>
                <asp:button class="btn" id="LoginButton" runat="server" commandname="Login" text="Log In" validationgroup="Login1" OnClick="LoginButton_Click"></asp:button>
                <br>
                <asp:literal id="FailureText" runat="server" enableviewstate="False"></asp:literal></div>
        </div>
    </layouttemplate>
</asp:login>
        </form>
</body>
</html>
