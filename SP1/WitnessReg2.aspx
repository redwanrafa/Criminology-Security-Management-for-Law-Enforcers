<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WitnessReg2.aspx.cs" Inherits="SP1.WitnessReg2" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Witness Registration</title>

</head>

<body>

    <div class="w3-sidebar w3-bar-block w3-card-2 w3-animate-left w3-black " style="display: none" id="mySidebar">
        <button class="w3-bar-item w3-button w3-large w3-hover-amber" 
            onclick="w3_close()">
            Close &times;</button>
        <a href="/Home.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="fa fa-home"	style="font-size:36px;	"></i>Home</a>
        <a href="/ViewProfile.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="fa fa-product-hunt"	style="font-size:36px"		"></i>Profile</a>
        
            <%if (Convert.ToInt32(Session["Rank1"]) == 1)
                {
            %>
                    <div class="w3-dropdown-hover">
            <button class="w3-button w3-hover-amber">
        <i class="fa fa-user-secret	"style="font-size:36px"		"></i>
                Police
        <i class="fa fa-chevron-down"></i>
            </button>
            <div class="w3-dropdown-content w3-dark-gray w3-bar-block ">
                <a href="/PoliceReg.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="fa fa-user-plus"	style="font-size:36px"		"></i>Register A Officer</a>
                <a href="/SearchPolice.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="fa fa-users"	style="font-size:36px"		"></i>Search Officer</a>
            </div>
        </div>
        <%
            }

        %>
        <div class="w3-dropdown-hover">
            <button class="w3-button w3-hover-amber">
        <i class="fa fa-book	"	style="font-size:36px"		"></i>
                Case
        <i class="fa fa-chevron-down"></i>
            </button>
            <div class="w3-dropdown-content w3-dark-gray w3-bar-block ">
                <a href="/CaseReg.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="fa fa-openid	"	style="font-size:36px"		"></i>Plaintiff A Case</a>
                <a href="/SearchCase.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="glyphicon glyphicon-search		"	style="font-size:36px"		"></i>Search A Case</a>
            </div>
        </div>
        <a href="/SearchCriminal.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="glyphicon glyphicon-ban-circle	"style="font-size:36px;color: red"	color: red	"></i>Criminal</a>
        
        <%
            if (Convert.ToInt32(Session["Rank2"]) <5)
            {
        %> 
         <a href="/AddNotice.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="fa fa-calendar-check-o" style="font-size:36px"		"></i>Notice</a>
         <%
             }
         %> 

        <a href="/Reports.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="fa fa-line-chart	Try it" style="font-size:36px"		"></i>Reports</a>
        <a href="/LogOut.aspx" class="w3-bar-item w3-button w3-hover-amber"><i class="glyphicon glyphicon-log-out" style="font-size:36px"		"></i>Log Out</a>
    </div>

    <div class="w3-main" id="main">

        <div class="w3-amber">
            <button class="w3-button w3-amber w3-hover-black w3-xlarge" onclick="w3_open()">&#9776;</button>
            <div class="w3-container w3-center w3-animate-top" style="left: 0px; top: 0px">
                <h1 dir="ltr">Law Enforcement & Federal Investigation</h1>
            </div>
        </div>


        <div class="w3-container">
           <form id="form1" runat="server" class="auto-style1">
    <h1>Witness Registration</h1>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="ButtonBack" runat="server" BackColor="#33CCCC" CausesValidation="False" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="&lt;- Back" Width="181px" OnClick="ButtonBack_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="ButtonWitnessExist" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="Add An Existing Witness" Width="421px" CausesValidation="False" OnClick="ButtonWitnessExist_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Witness Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="name" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Name must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Father's Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="fname" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="fname" ErrorMessage="Father's Name must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Mother's Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="mname" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mname" ErrorMessage="Mother's Name must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Address :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="caddress" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="caddress" ErrorMessage="Address must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Division :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownDivision" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDivision_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="DropDownDivision" ErrorMessage="Division must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="District :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownDistrict" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDistrict_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="DropDownDistrict" ErrorMessage="District must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Branch :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownBranch" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="DropDownBranch" ErrorMessage="Branch must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Submit" runat="server" BackColor="#33CCCC" Font-Bold="True" ForeColor="Black" Height="36px" Text="SUBMIT" Width="400px" OnClick="Submit_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </form>
        </div>

    </div>

    <script>
        function w3_open() {
            document.getElementById("main").style.marginLeft = "15%";
            document.getElementById("mySidebar").style.width = "15%";
            document.getElementById("mySidebar").style.display = "block";
            document.getElementById("openNav").style.display = 'none';
        }
        function w3_close() {
            document.getElementById("main").style.marginLeft = "0%";
            document.getElementById("mySidebar").style.display = "none";
            document.getElementById("openNav").style.display = "inline-block";
        }
    </script>


</body>
</html>
