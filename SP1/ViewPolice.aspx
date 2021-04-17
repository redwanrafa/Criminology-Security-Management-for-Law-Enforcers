<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPolice.aspx.cs" Inherits="SP1.ViewPolice1" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>View Police</title>

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
            <form id="form1" runat="server" class="auto-style2">
    <h1>Officer Profile</h1>
        <table class="auto-style1">
            <tr>
                <td colspan="5">
                    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Police Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelName" runat="server" Text="Name!"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Father's Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelFName" runat="server" Text="Father's Name!"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Mother's Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelMName" runat="server" Text="Mother's Name!"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Current Address :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelCAddress" runat="server" Text="Address !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Permanent Address :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelPAddress" runat="server" Text="Address !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label23" runat="server" Font-Bold="True" Text="Date of Birth :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelDOB" runat="server" Text="DOB !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Large" Text="Gender :"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelGender" runat="server" Text="Gender !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Birth Certificate ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelBirthId" runat="server" Text="Birth Certificate !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="National ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelNationalId" runat="server" Text="National ID!"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Passport ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelPassportId" runat="server" Text="Passport ID !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Driving License ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelDrivingId" runat="server" Text="Driving License ID !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Material Status :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:Label ID="LabelMaterialStatus" runat="server" Text="Material Status !"></asp:Label>
                </td>
                <td class="auto-style16">
                </td>
                <td class="auto-style17">
                </td>
                <td class="auto-style17">
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Current Rank :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="LabelRank" runat="server" Text="Rank !"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Up" runat="server" Text="Up" BackColor="#33CCCC" Enabled="False" Font-Size="Large" ForeColor="Black" Visible="False" Width="250px" OnClick="Up_Click" Height="26px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Down" runat="server" Text="Down" BackColor="#33CCCC" Enabled="False" Font-Size="Large" ForeColor="Black" Visible="False" Width="250px" OnClick="Down_Click" Height="26px" />
                </td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="Current Unit :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelUnit1" runat="server" Text="Unit 1!"></asp:Label>
                    <asp:Label ID="LabelUnit2" runat="server" Text="Unit 2!"></asp:Label>
                </td>
                <td class="auto-style13">
                <asp:DropDownList ID="DropDownUnit1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownUnit1_SelectedIndexChanged" Enabled="False" Visible="False">
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownUnit2" runat="server" Enabled="False" Visible="False" AutoPostBack="True">
                </asp:DropDownList>
                </td>
                <td class="auto-style5">
                    <asp:Button ID="UpdateUnit" runat="server" Text="Update" BackColor="#33CCCC" Enabled="False" Font-Size="Large" ForeColor="Black" Visible="False" Width="250px" OnClick="UpdateUnit_Click" Height="25px" />
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Current Division :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelDivision" runat="server" Text="Division!"></asp:Label>
                </td>
                <td class="auto-style13">
                <asp:DropDownList ID="DropDownDivision" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDivision_SelectedIndexChanged" Enabled="False" ValidationGroup="Div" Visible="False">
                </asp:DropDownList>
                </td>
                <td class="auto-style5" rowspan="3">
                    <asp:Button ID="UpdateD" runat="server" Text="Update" BackColor="#33CCCC" Enabled="False" Font-Size="Large" ForeColor="Black" Visible="False" Width="250px" OnClick="UpdateD_Click" Height="25px" />
                </td>
                <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="DropDownDivision" ErrorMessage="Currant Division must need to be filled!" ValidationGroup="Div"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Current District :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelDistrict" runat="server" Text="District !"></asp:Label>
                </td>
                <td class="auto-style13">
                <asp:DropDownList ID="DropDownDistrict" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDistrict_SelectedIndexChanged" Enabled="False" ValidationGroup="Dis" Visible="False">
                </asp:DropDownList>
                </td>
                <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="DropDownDistrict" ErrorMessage="Currant District must need to be filled!" ValidationGroup="Dis"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Text="Current Branch :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelBranch" runat="server" Text="Branch !"></asp:Label>
                </td>
                <td class="auto-style13">
                <asp:DropDownList ID="DropDownBranch" runat="server" AutoPostBack="True" Enabled="False" ValidationGroup="Bra">
                </asp:DropDownList>
                </td>
                <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="DropDownBranch" ErrorMessage="Currant Branch must need to be filled!" ValidationGroup="Bra"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Email :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelEmail" runat="server" Text="Email !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="Contact No :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelContact" runat="server" Text="Contact No!"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label20" runat="server" Font-Bold="True" Text="User Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelUserName" runat="server" Text="User Name!"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label26" runat="server" Font-Bold="True" Text="Joining Rank :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelJoinRank" runat="server" Text="Joining Rank !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="Joining Date :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelJoinDate" runat="server" Text="Joining Date !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label33" runat="server" Font-Bold="True" Text="Salary :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelSalary" runat="server" Text="Salary !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label29" runat="server" Font-Bold="True" Text="Reward Rank :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelRewardRank" runat="server" Text="Reward Rank !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label28" runat="server" Font-Bold="True" Text="XP :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelXP" runat="server" Text="XP !"></asp:Label>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label34" runat="server" Font-Bold="True" Text="Status :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="LabelStatus" runat="server" Text="Status !"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:DropDownList ID="DropDownStatus" runat="server" Enabled="False" Visible="False">
                        <asp:ListItem>Active</asp:ListItem>
                        <asp:ListItem>Suspended</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style5">
                    <asp:Button ID="UpdateStatus" runat="server" Text="Update" BackColor="#33CCCC" Enabled="False" Font-Size="Large" ForeColor="Black" Visible="False" Width="250px" OnClick="UpdateStatus_Click" Height="25px" />
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label30" runat="server" Font-Bold="True" Text="Achievments :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                    </asp:GridView>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
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
