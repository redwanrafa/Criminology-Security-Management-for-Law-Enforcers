<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PoliceReg.aspx.cs" Inherits="SP1.PoliceReg" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Police Registration</title>

</head>

<body>

   

    <div class="w3-main" id="main">

        <div class="w3-amber">
            <button class="w3-button w3-amber w3-hover-black w3-xlarge" onclick="w3_open()">&#9776;</button>
            <div class="w3-container w3-center w3-animate-top" style="left: 0px; top: 0px">
                <h1 dir="ltr">Law Enforcement & Federal Investigation</h1>
                
            </div>
        </div>


        <div class="w3-container">
           <form id="form1" runat="server">
    <h1>Police Registration</h1>
        <table class="auto-style2" style="width:100%;">
        <tr>
            <td class="auto-style16" colspan="3">
                    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Police Name :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="name" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Name must need to be filled!"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Father's Name :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="fname" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="fname" ErrorMessage="Father's Name must need to be filled!"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Mother's Name :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="mname" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mname" ErrorMessage="Mother's Name must need to be filled!"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Current Address :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="caddress" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="caddress" ErrorMessage="Current Address must need to be filled!"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Permanent Address :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="paddress" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="caddress" ErrorMessage="Parmanent Address must need to be filled!"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label23" runat="server" Font-Bold="True" Text="Date of Birth :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="dob" runat="server" Width="174px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="ButtonDOB" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" Text="..." Width="32px" CausesValidation="False" OnClick="ButtonDOB_Click" />
                    <asp:Calendar ID="CalendarDOB" runat="server" Height="24px" Width="25px" OnDayRender="CalendarDOB_DayRender" OnSelectionChanged="CalendarDOB_SelectionChanged" VisibleDate="1990-01-01"></asp:Calendar>
            </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="dob" ErrorMessage="Date of birth must need to be filled!"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Large" Text="Gender :"></asp:Label>
                </td>
            <td class="auto-style9">
                <asp:RadioButtonList ID="RadioButtonGender" runat="server" Width="82px" RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ControlToValidate="RadioButtonGender" ErrorMessage="Gender must need to be selected!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Birth Certificate ID :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style14">
                    <asp:TextBox ID="birid" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="birid" ErrorMessage="Birth Certificate ID must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="BirthIDValidator" runat="server" ErrorMessage="Birth certificate ID Already Exist!" ForeColor="Red" OnServerValidate="BirthIDValidator_ServerValidate" ControlToValidate="birid"></asp:CustomValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="National ID :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="natid" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="natid" ErrorMessage="National ID must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="NationalIdValidator" runat="server" ErrorMessage="National ID Already Exist!" ForeColor="Red" OnServerValidate="NationalIdValidator_ServerValidate" ControlToValidate="natid"></asp:CustomValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Passport ID :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="passid" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="passid" ErrorMessage="Passport ID must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="PassportIDValidator" runat="server" ErrorMessage="Passport ID Already Exist!" ForeColor="Red" OnServerValidate="PassportIDValidator_ServerValidate" ControlToValidate="passid"></asp:CustomValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Driving License ID :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="driveid" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="driveid" ErrorMessage="Driving License ID must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="DrivingIDValidator" runat="server" ErrorMessage="Driving License ID Already Exist!" ForeColor="Red" OnServerValidate="DrivingIDValidator_ServerValidate" ControlToValidate="driveid"></asp:CustomValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Material Status :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownMaterial" runat="server">
                    <asp:ListItem>Single</asp:ListItem>
                    <asp:ListItem>Married</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="DropDownMaterial" ErrorMessage="Material Status must need to be filled!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Current Rank :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownRank1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownRank1_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownRank2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownRank2_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style12">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="DropDownRank1" ErrorMessage="Currant Rank must need to be filled!"></asp:RequiredFieldValidator>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ControlToValidate="DropDownRank2" ErrorMessage="Currant Rank must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="RankValidator" runat="server" ErrorMessage="There is only one IG can be in the system !" ForeColor="Red" OnServerValidate="RankValidator_ServerValidate" ControlToValidate="DropDownRank2"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="Current Unit :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style18">
                <asp:DropDownList ID="DropDownUnit1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownUnit1_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownUnit2" runat="server" Enabled="False" Visible="False" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td class="auto-style19">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="DropDownUnit1" ErrorMessage="Currant Unit must need to be filled!"></asp:RequiredFieldValidator>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ControlToValidate="DropDownUnit2" ErrorMessage="Currant Unit must need to be filled!" Enabled="False"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Current Division :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownDivision" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDivision_SelectedIndexChanged" ValidationGroup="Div">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="DropDownDivision" ErrorMessage="Currant Division must need to be filled!" ValidationGroup="Div"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Current District :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownDistrict" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDistrict_SelectedIndexChanged" ValidationGroup="Dis">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="DropDownDistrict" ErrorMessage="Currant District must need to be filled!" ValidationGroup="Dis"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Text="Current Branch :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownBranch" runat="server" AutoPostBack="True" ValidationGroup="Bra">
                </asp:DropDownList>
            </td>
            <td class="auto-style7">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="DropDownBranch" ErrorMessage="Currant Branch must need to be filled!" ValidationGroup="Bra"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Email :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="email" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="email" ErrorMessage="Email must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="EmailValidator" runat="server" ErrorMessage="Email Already Exist!" ForeColor="Red" OnServerValidate="EmailValidator_ServerValidate" ControlToValidate="email"></asp:CustomValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="Contact No :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="contactno" runat="server" Width="400px"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="contactno" ErrorMessage="Contact No must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="ContactValidator" runat="server" ErrorMessage="Contact Number Already Exist!" ForeColor="Red" OnServerValidate="ContactValidator_ServerValidate" ControlToValidate="contactno"></asp:CustomValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label20" runat="server" Font-Bold="True" Text="User Name :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="username" runat="server" Width="400px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="username" ErrorMessage="User Name must need to be filled!"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="UserNameValidator" runat="server" ErrorMessage="User Name Already Exist!" ForeColor="Red" OnServerValidate="UserNameValidator_ServerValidate" ControlToValidate="username"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label21" runat="server" Font-Bold="True" Text="Password :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="pass" runat="server" Width="400px" TextMode="Password"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="pass" ErrorMessage="Password must need to be filled!"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="confpass" ControlToValidate="pass" ErrorMessage="Password does not match!"></asp:CompareValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                    <asp:Label ID="Label22" runat="server" Font-Bold="True" Text="Confirm Password :" Font-Size="Large"></asp:Label>
                </td>
            <td class="auto-style9">
                    <asp:TextBox ID="confpass" runat="server" Width="400px" TextMode="Password"></asp:TextBox>
                    </td>
            <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="confpass" ErrorMessage="Confirm Password must need to be filled!"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="pass" ControlToValidate="confpass" ErrorMessage="Password does not match!"></asp:CompareValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5" colspan="2">
                    <asp:Button ID="Submit" runat="server" BackColor="#33CCCC" Font-Bold="True" ForeColor="Black" Height="36px" Text="SUBMIT" Width="400px" OnClick="Submit_Click" />
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
