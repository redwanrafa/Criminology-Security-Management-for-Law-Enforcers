<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewWitness.aspx.cs" Inherits="SP1.ViewWitness" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>View Witness</title>

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
             <form id="form1" runat="server">
    <h1>Witness Profile</h1>

        <table class="auto-style4">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Witness Name :" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelName" runat="server" Text="Name!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Father's Name :" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelFName" runat="server" Text="Father's Name!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Mother's Name :" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelMName" runat="server" Text="Mother's Name!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Address :" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelCAddress" runat="server" Text="Address !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Division :" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelDivision" runat="server" Text="Division!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="District :" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelDistrict" runat="server" Text="District !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Text="Branch :" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelBranch" runat="server" Text="Branch !"></asp:Label>
                </td>
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