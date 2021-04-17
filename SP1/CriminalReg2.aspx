<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CriminalReg2.aspx.cs" Inherits="SP1.CriminalReg2" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Criminal Registration</title>

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
        <h1>Criminal Registration</h1>

        <table class="auto-style10">
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="ButtonBack" runat="server" BackColor="#33CCCC" CausesValidation="False" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="&lt;- Back" Width="181px" OnClick="ButtonBack_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="ButtonCrimanlExist" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="Add An Existing Criminal" Width="421px" CausesValidation="False" OnClick="ButtonCrimanlExist_Click" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5" colspan="3">
                    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Criminal Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="name" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Name must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label26" runat="server" Font-Bold="True" Text="Alternative Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="altname" runat="server" Width="400px" ToolTip="If Available"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Father's Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="fname" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="fname" ErrorMessage="Father's Name must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Mother's Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="mname" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mname" ErrorMessage="Mother's Name must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Current Address :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="caddress" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="caddress" ErrorMessage="Current Address must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Permanent Address :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="paddress" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="caddress" ErrorMessage="Parmanent Address must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Division :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownDivision" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDivision_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="DropDownDivision" ErrorMessage="Division must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="District :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownDistrict" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDistrict_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="DropDownDistrict" ErrorMessage="District must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Branch :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownBranch" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="DropDownBranch" ErrorMessage="Branch must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label23" runat="server" Font-Bold="True" Text="Date of Birth :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="dob" runat="server" Width="174px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="ButtonDOB" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Small" Text="..." Width="32px" CausesValidation="False" OnClick="ButtonDOB_Click" />
                    <asp:Calendar ID="CalendarDOB" runat="server" Height="24px" Visible="False" Width="25px" OnDayRender="CalendarDOB_DayRender" OnSelectionChanged="CalendarDOB_SelectionChanged" VisibleDate="1990-01-01"></asp:Calendar>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="dob" ErrorMessage="Date of birth must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Large" Text="Gender :"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RadioButtonGender" runat="server" Width="82px" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ControlToValidate="RadioButtonGender" ErrorMessage="Gender must need to be selected!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Birth Certificate ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="birid" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="birid" ErrorMessage="Birth Certificate ID must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="BirthIDValidator" runat="server" ErrorMessage="Birth certificate ID Already Exist!" ForeColor="Red" OnServerValidate="BirthIDValidator_ServerValidate" ControlToValidate="birid"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="National ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="natid" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="natid" ErrorMessage="National ID must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="NationalIdValidator" runat="server" ErrorMessage="National ID Already Exist!" ForeColor="Red" OnServerValidate="NationalIdValidator_ServerValidate" ControlToValidate="natid"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Passport ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="passid" runat="server" Width="400px" ToolTip="If Available"></asp:TextBox>
                </td>
                <td>
                <asp:CustomValidator ID="PassportIDValidator" runat="server" ErrorMessage="Passport ID Already Exist!" ForeColor="Red" OnServerValidate="PassportIDValidator_ServerValidate" ControlToValidate="passid"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Driving License ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="driveid" runat="server" Width="400px" ToolTip="If Available"></asp:TextBox>
                </td>
                <td>
                <asp:CustomValidator ID="DrivingIDValidator" runat="server" ErrorMessage="Driving License ID Already Exist!" ForeColor="Red" OnServerValidate="DrivingIDValidator_ServerValidate" ControlToValidate="driveid"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Contact No :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="contactno" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="contactno" ErrorMessage="Contact No must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="ContactValidator" runat="server" ErrorMessage="Contact Number Already Exist!" ForeColor="Red" OnServerValidate="ContactValidator_ServerValidate" ControlToValidate="contactno"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Size="Large" Text="Remarkable Marks :"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="remarkmarks" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" ControlToValidate="remarkmarks" ErrorMessage="Remarkable Marks need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Material Status :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownMaterial" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownMaterial_SelectedIndexChanged">
                        <asp:ListItem>Single</asp:ListItem>
                        <asp:ListItem>Married</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="DropDownMaterial" ErrorMessage="Material Status must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Size="Large" Text="Husband/Wife's Name :" Enabled="False" Visible="False"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="partnername" runat="server" Width="400px" Enabled="False" Visible="False"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" ControlToValidate="partnername" ErrorMessage="Husband/Wife name must need to be filled!" Enabled="False"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label29" runat="server" Font-Bold="True" Font-Size="Large" Text="No of Children :" Enabled="False" Visible="False"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownNoOfChild" runat="server" Enabled="False" Visible="False">
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem Value="7"></asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" ControlToValidate="DropDownNoOfChild" ErrorMessage="No of Children must need to be filled!" Enabled="False"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label30" runat="server" Font-Bold="True" Text="Criminal Status:" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownListCriminalStatus" runat="server">
                        <asp:ListItem>On Custody</asp:ListItem>
                        <asp:ListItem>On Bail</asp:ListItem>
                        <asp:ListItem>Uncaptured</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" ControlToValidate="DropDownListCriminalStatus" ErrorMessage="Criminal Status must need to be filled!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2" style="font-weight: 700">
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
