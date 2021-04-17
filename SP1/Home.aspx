<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SP1.Home" %>

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Home</title>

</head>

<body>
        <div class="w3-container">
            <form id="form1" runat="server">
                <table class="w3-table-all w3-centered">
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="Green" Text="On Going Investigations"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:GridView ID="GridViewOnGoingCases" runat="server" OnSelectedIndexChanged="GridViewOnGoingCases_SelectedIndexChanged" Width="1103px">
                                <Columns>
                                    <asp:CommandField SelectText="View Details" ShowSelectButton="True" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
                <table class="w3-table-all w3-centered">
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="Red" Text="Notice Board"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:GridView ID="GridViewNoticeBoard" runat="server" Width="1103px" OnSelectedIndexChanged="GridViewNoticeBoard_SelectedIndexChanged">
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
