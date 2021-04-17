<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCase.aspx.cs" Inherits="SP1.ViewCase" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>View Case</title>

</head>

<body>



        <div class="w3-container">
           <form id="form1" runat="server" class="auto-style1">
        <h1>Case Details</h1>
        <table style="width:100%;">
            <tr>
                <td colspan="7">
                    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="ButtonInvReport" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="Add Investigation Report" Width="250px" CausesValidation="False" OnClick="ButtonInvReport_Click" Enabled="False" Visible="False" />
                </td>
                <td>
                    <asp:Button ID="ButtonCriminal" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="Add A Criminal" Width="250px" CausesValidation="False" OnClick="ButtonCriminal_Click" Enabled="False" Visible="False" />
                </td>
                <td colspan="2">
                    <asp:Button ID="ButtonWitness" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="Add A Witness" Width="250px" CausesValidation="False" OnClick="ButtonWitness_Click" Enabled="False" Visible="False" />
                </td>
                <td colspan="2">
                    <asp:Button ID="ButtonCharge" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="Add Charges" Width="250px" CausesValidation="False" Enabled="False" Visible="False" OnClick="ButtonCharge_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonVerdict" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="Add Verdict" Width="250px" CausesValidation="False" Enabled="False" Visible="False" OnClick="ButtonVerdict_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Case Type :" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelType" runat="server" Text="Case Type !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Case Details :"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelCDetails" runat="server" Text="Case Details !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Case Inventory/Recovery :"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelInventory" runat="server" Text="Inventory !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Division :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style8" colspan="6">
                    <asp:Label ID="LabelDivision" runat="server" Text="Division!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="District :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style6" colspan="6">
                    <asp:Label ID="LabelDistrict" runat="server" Text="District !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" Text="Branch :" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelBranch" runat="server" Text="Branch !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Investigation Officer Name :"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelInvName" runat="server" Text="Investigation Officer Name!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Case Defendents :" Enabled="False" Visible="False"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelCDefendent" runat="server" Text="Case Defendents !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label26" runat="server" Font-Bold="True" Text="Crime Category :" Enabled="False"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelCrimeCat" runat="server" Text="Crime Category !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="Case Status :" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelStatus" runat="server" Text="Case Status"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Case Plaintiffed By :"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelCPlaintiffBy" runat="server" Text="Plaintiff By !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label31" runat="server" Font-Bold="True" Text="Case Current Court:" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelCourt" runat="server" Text="Current Court"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label32" runat="server" Font-Bold="True" Text="Case Added On:" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2" colspan="6">
                    <asp:Label ID="LabelCaseAddOn" runat="server" Text="Added On!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label34" runat="server" Font-Bold="True" Text="Investigation Report:" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Label ID="LabelInvReport" runat="server" Text="Investigation Report"></asp:Label>
                    <br />
                    <asp:TextBox ID="InvReport" runat="server" Enabled="False" TextMode="MultiLine" ValidationGroup="Inv" Visible="False" Width="369px"></asp:TextBox>
                </td>
                <td class="auto-style10" colspan="2">
                    <asp:Button ID="Submit" runat="server" BackColor="#33CCCC" Font-Bold="True" ForeColor="Black" Height="36px" Text="SUBMIT" Width="86px" OnClick="Submit_Click" Enabled="False" ValidationGroup="Inv" Visible="False" />
                </td>
                <td colspan="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="InvReport" ErrorMessage="Investigation Report Must need to be filled !" ValidationGroup="Inv"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label33" runat="server" Font-Bold="True" Text="Investigation Report Added On:" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelInvAddOn" runat="server" Text="Not Added Yet !"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label35" runat="server" Font-Bold="True" Text="Investigation Report Days Remaining :" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="3">
                    <asp:Label ID="LabelInvTimeRemain" runat="server" Text="Time Left !"></asp:Label>
                </td>
                <td colspan="3">
                    <asp:Button ID="ButtonReassignInv" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="Reassign Investigation Officer" Width="300px" CausesValidation="False" Enabled="False" Visible="False" OnClick="ButtonReassignInv_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label30" runat="server" Font-Bold="True" Text="Case Witness:" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:GridView ID="GridViewWitness" runat="server" OnSelectedIndexChanged="GridViewWitness_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField SelectText="View Profile" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label28" runat="server" Font-Bold="True" Text="Case Plaintiff:" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:Label ID="LabelPlaintiffByName" runat="server" Text="Plaintiff By Name!"></asp:Label>
                    <asp:GridView ID="GridViewPlaintiff" runat="server" OnSelectedIndexChanged="GridViewPlaintiff_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField SelectText="View Profile" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label29" runat="server" Font-Bold="True" Text="Case Criminal:" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:GridView ID="GridViewCriminal" runat="server" OnSelectedIndexChanged="GridViewCriminal_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField SelectText="View Profile" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label37" runat="server" Font-Bold="True" Text="Case Verdict:" Font-Size="Large"></asp:Label>
                </td>
                <td colspan="6">
                    <asp:GridView ID="GridViewVerdict" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label36" runat="server" Font-Bold="True" Text="Investigation Officer Name :" Enabled="False" Visible="False"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="InvestOfficerName" runat="server" ReadOnly="True" Width="221px" Enabled="False" ValidationGroup="InvOff" Visible="False"></asp:TextBox>
                    <asp:Button ID="AddInvOfficer" runat="server" Text="Add" OnClick="AddInvOfficer_Click" BackColor="#33CCCC" Enabled="False" Font-Size="Large" ForeColor="Black" ValidationGroup="InvOff" Visible="False" Width="48px" />
                </td>
                <td colspan="2">
                    <asp:TextBox ID="officersearchinvest" runat="server" Width="265px" Enabled="False" Visible="False"></asp:TextBox>
                    <asp:Button ID="SearchInvestigationOfficer" runat="server" Text="Search" CausesValidation="False" OnClick="SearchInvestigationOfficer_Click" Enabled="False" Visible="False" />
                </td>
                <td colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator37" runat="server" ControlToValidate="InvestOfficerName" ErrorMessage="Investigation Officer must need to be added!" ValidationGroup="InvOff"></asp:RequiredFieldValidator>
                    <asp:GridView ID="GridViewInvestOfficer" runat="server" OnSelectedIndexChanged="GridViewInvestOfficer_SelectedIndexChanged" Enabled="False" Visible="False">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Select" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
        
    </form>
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
