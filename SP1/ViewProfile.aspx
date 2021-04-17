<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="SP1.ViewPolice" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>View Profile</title>

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
           <form id="form1" runat="server" class="auto-style2">
        <h1>Profile</h1>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Police Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style7">
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
                <td class="auto-style4">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Mother's Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelMName" runat="server" Text="Mother's Name!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Current Address :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelCAddress" runat="server" Text="Address !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Permanent Address :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelPAddress" runat="server" Text="Address !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label23" runat="server" Font-Bold="True" Text="Date of Birth :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelDOB" runat="server" Text="DOB !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Large" Text="Gender :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelGender" runat="server" Text="Gender !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Birth Certificate ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelBirthId" runat="server" Text="Birth Certificate !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="National ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelNationalId" runat="server" Text="National ID!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Passport ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelPassportId" runat="server" Text="Passport ID !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Driving License ID :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelDrivingId" runat="server" Text="Driving License ID !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Material Status :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelMaterialStatus" runat="server" Text="Material Status !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Current Rank :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelRank" runat="server" Text="Rank !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="Current Unit :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelUnit1" runat="server" Text="Unit 1!"></asp:Label>
                    <asp:Label ID="LabelUnit2" runat="server" Text="Unit 2!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Current Division :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelDivision" runat="server" Text="Division!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Current District :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelDistrict" runat="server" Text="District !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Text="Current Branch :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelBranch" runat="server" Text="Branch !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Email :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelEmail" runat="server" Text="Email !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="Contact No :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelContact" runat="server" Text="Contact No!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label20" runat="server" Font-Bold="True" Text="User Name :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelUserName" runat="server" Text="User Name!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label26" runat="server" Font-Bold="True" Text="Joining Rank :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelJoinRank" runat="server" Text="Joining Rank !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="Joining Date :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelJoinDate" runat="server" Text="Joining Date !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label33" runat="server" Font-Bold="True" Text="Salary :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelSalary" runat="server" Text="Salary !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label29" runat="server" Font-Bold="True" Text="Reward Rank :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelRewardRank" runat="server" Text="Reward Rank !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label28" runat="server" Font-Bold="True" Text="XP :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="LabelXP" runat="server" Text="XP !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label30" runat="server" Font-Bold="True" Text="Achievments :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <table class="auto-style8">
            <tr>
                <td class="auto-style1" colspan="7">
                    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="4">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Text="Update Contact Info" Width="568px" OnClick="Button1_Click" UseSubmitBehavior="False" />
                </td>
                <td colspan="3" class="auto-style1">
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Update Password" Width="568px" OnClick="Button2_Click" UseSubmitBehavior="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label31" runat="server" Font-Bold="True" Text="Email :" Font-Size="Large" Enabled="False" Visible="False"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="email" runat="server" Width="400px" Enabled="False" Visible="False" ValidationGroup="email"></asp:TextBox>
                    </td>
                <td class="auto-style9">
                    <asp:Button ID="Button3" runat="server" Text="Update" ValidationGroup="Email" Width="82px" Enabled="False" OnClick="Button3_Click" Visible="False" />
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="email" ErrorMessage="Email must need to be filled!" ValidationGroup="Email"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="EmailValidator" runat="server" ErrorMessage="Email Already Exist!" ForeColor="Red" OnServerValidate="EmailValidator_ServerValidate" ControlToValidate="email" ValidationGroup="Email"></asp:CustomValidator>
                </td>
                <td>
                    <asp:Label ID="Label21" runat="server" Font-Bold="True" Text="Password :" Font-Size="Large" Enabled="False" Visible="False"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="pass" runat="server" Width="310px" TextMode="Password" ValidationGroup="Password" Enabled="False" Visible="False"></asp:TextBox>
                    </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="pass" ErrorMessage="Password must need to be filled!" ValidationGroup="Password"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="confpass" ControlToValidate="pass" ErrorMessage="Password does not match!" ValidationGroup="Password"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label32" runat="server" Font-Bold="True" Text="Contact No :" Font-Size="Large" Enabled="False" Visible="False"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="contactno" runat="server" Width="400px" Enabled="False" Visible="False" ValidationGroup="contact"></asp:TextBox>
                    </td>
                <td class="auto-style9">
                    <asp:Button ID="Button4" runat="server" Text="Update" ValidationGroup="Contact" Width="82px" Enabled="False" OnClick="Button4_Click" Visible="False" />
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="contactno" ErrorMessage="Contact No must need to be filled!" ValidationGroup="Contact"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="ContactValidator" runat="server" ErrorMessage="Contact Number Already Exist!" ForeColor="Red" OnServerValidate="ContactValidator_ServerValidate" ControlToValidate="contactno" ValidationGroup="Contact"></asp:CustomValidator>
                </td>
                <td>
                    <asp:Label ID="Label22" runat="server" Font-Bold="True" Text="Confirm Password :" Font-Size="Large" Enabled="False" Visible="False"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="confpass" runat="server" Width="310px" TextMode="Password" ValidationGroup="Password" Enabled="False" Visible="False"></asp:TextBox>
                    </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="confpass" ErrorMessage="Confirm Password must need to be filled!" ValidationGroup="Password"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="pass" ControlToValidate="confpass" ErrorMessage="Password does not match!" ValidationGroup="Password"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label34" runat="server" Font-Bold="True" Text="Current Address :" Font-Size="Large" Visible="False"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="caddress" runat="server" Width="400px" Enabled="False" Visible="False" ValidationGroup="Address"></asp:TextBox>
                    </td>
                <td class="auto-style9">
                    <asp:Button ID="Button6" runat="server" Text="Update" ValidationGroup="Address" Width="82px" Enabled="False" Visible="False" OnClick="Button6_Click" />
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="caddress" ErrorMessage="Address must need to be filled!" ValidationGroup="Address"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="Button5" runat="server" Text="Update" ValidationGroup="Password" Width="310px" Enabled="False" Visible="False" OnClick="Button5_Click" />
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
