<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CaseReg.aspx.cs" Inherits="SP1.casereg" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Case Registration</title>

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
        <h1>Case Registration</h1>
    
        <table style="width: 100%; height: 582px;">
            <tr>
                <td class="auto-style24" colspan="5">
                    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Case Type :"></asp:Label>
                </td>
                <td class="auto-style16" colspan="2">
                    <asp:DropDownList ID="DropDownCaseType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownCaseType_SelectedIndexChanged">
                        <asp:ListItem Value="Criminal">Criminal</asp:ListItem>
                        <asp:ListItem Value="Civil">Civil</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style17" colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" ControlToValidate="DropDownCaseType" ErrorMessage="Case Type must need to be filled!"></asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Case Details :"></asp:Label>
                </td>
                <td class="auto-style13" colspan="2">
                    <asp:TextBox ID="cdetails" runat="server" Width="450px" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td colspan="2" class="auto-style13">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" ControlToValidate="cdetails" ErrorMessage="Details must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Case Inventory/Recovery :"></asp:Label>
                </td>
                <td class="auto-style13" colspan="2">
                    <asp:TextBox ID="cinvent" runat="server" Width="450px"></asp:TextBox>
                </td>
                <td colspan="2" class="auto-style13">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator36" runat="server" ControlToValidate="cinvent" ErrorMessage="Inventory must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Division :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style10" colspan="2">
                <asp:DropDownList ID="DropDownDivision" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDivision_SelectedIndexChanged">
                </asp:DropDownList>
                </td>
                <td colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="DropDownDivision" ErrorMessage="Division must need to be selected!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="District :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style10" colspan="2">
                <asp:DropDownList ID="DropDownDistrict" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDistrict_SelectedIndexChanged">
                </asp:DropDownList>
                </td>
                <td colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="DropDownDistrict" ErrorMessage="District must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" Text="Branch :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style10" colspan="2">
                <asp:DropDownList ID="DropDownBranch" runat="server">
                </asp:DropDownList>
                </td>
                <td colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="DropDownBranch" ErrorMessage="Branch must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Investigation Officer Name :"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="InvestOfficerName" runat="server" ReadOnly="True" Width="221px"></asp:TextBox>
                </td>
                <td class="auto-style23">
                    <asp:TextBox ID="officersearchinvest" runat="server" Width="265px"></asp:TextBox>
                    <asp:Button ID="SearchInvestigationOfficer" runat="server" Text="Search" CausesValidation="False" OnClick="SearchInvestigationOfficer_Click" />
                </td>
                <td class="auto-style23">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator37" runat="server" ControlToValidate="InvestOfficerName" ErrorMessage="Investigation Officer must need to be added!"></asp:RequiredFieldValidator>
                    <br />
                </td>
                <td class="auto-style23">
                    <asp:GridView ID="GridViewInvestOfficer" runat="server" OnSelectedIndexChanged="GridViewInvestOfficer_SelectedIndexChanged">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Select" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Case Plaintiffed By :"></asp:Label>
                </td>
                <td class="auto-style21" colspan="2">
                    <asp:DropDownList ID="DropDownCaseBy" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownCaseBy_SelectedIndexChanged" style="height: 22px">
                        <asp:ListItem>Civilian</asp:ListItem>
                        <asp:ListItem>Police</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style21" colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator39" runat="server" ControlToValidate="DropDownCaseBy" ErrorMessage="Case Plaintiff By must need to be selected!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Case Defendents :" Enabled="False" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21" colspan="2">
                    <asp:TextBox ID="cdefendent" runat="server" Width="450px" Enabled="False" Visible="False" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="auto-style21" colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" ControlToValidate="cdefendent" ErrorMessage="Defendents must need to be filled!" Enabled="False"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:Label ID="Label26" runat="server" Font-Bold="True" Text="Crime Category :" Enabled="False"></asp:Label>
                </td>
                <td class="auto-style21" colspan="2">
                    <asp:DropDownList ID="DropDownCrimeCategory" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style21" colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator38" runat="server" ControlToValidate="DropDownCrimeCategory" ErrorMessage="Crime Category must need to be selected!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                </td>
                <td class="auto-style12" colspan="2">
                    <asp:Button ID="Submit" runat="server" BackColor="#33CCCC" Font-Bold="True" ForeColor="Black" Height="36px" Text="SUBMIT" Width="704px" OnClick="Submit_Click" />
                </td>
                <td class="auto-style8" colspan="2">&nbsp;</td>
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