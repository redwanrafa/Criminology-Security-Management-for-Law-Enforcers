<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCase.aspx.cs" Inherits="SP1.SearchCase" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Search Case</title>

</head>

<body>

   


        <div class="w3-container">
            <form id="form1" runat="server" class="auto-style1">
    <h1>Search Case</h1>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Search By :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownListType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged">
                        <asp:ListItem Value="1">Date Added On</asp:ListItem>
                        <asp:ListItem Value="2">Branch</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownListType" ErrorMessage="Select an item to search"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Date Added On :" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="date" runat="server" Width="174px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="ButtonDate" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Small" Text="..." Width="32px" CausesValidation="False" OnClick="ButtonDate_Click" />
                    <asp:Button ID="ButtonSearch" runat="server" Font-Bold="True" Font-Size="Small" OnClick="ButtonSearch_Click" Text="Search" />
                    <asp:Calendar ID="CalendarDate" runat="server" Height="16px" OnSelectionChanged="CalendarDate_SelectionChanged" Visible="False" Width="16px"></asp:Calendar>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="date" ErrorMessage="Date  must need to be added to perform a search!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Text="Division :" Font-Size="Large" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownDivision" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDivision_SelectedIndexChanged" Visible="False">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="DropDownDivision" ErrorMessage="Select a division to search!" Visible="False"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="District :" Font-Size="Large" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownDistrict" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownDistrict_SelectedIndexChanged" Visible="False">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="DropDownDistrict" ErrorMessage="Select a district to search!" Visible="False"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Branch :" Font-Size="Large" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownBranch" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownBranch_SelectedIndexChanged" Visible="False">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="DropDownBranch" ErrorMessage="Select a branch to search!" Visible="False"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridViewCaseList" runat="server" Width="1277px" OnSelectedIndexChanged="GridViewCaseList_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField SelectText="View Details" ShowSelectButton="True" />
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
