<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VoterEntryUI.aspx.cs" Inherits="VotingSystemApp.UI.VoterEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css"/>

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <ul class="nav nav-pills">
                <li class="active"><a href="VoterEntryUI.aspx">Visitor Entry</a></li>
                <li><a href="CandidateEntryUI.aspx">Candidate Entry</a></li>
                <li><a href="CastVoteUI.aspx">Cast Vote</a></li>
                <li><a href="#">View Result</a></li>
            </ul>
        <br/><br/>
        <div>
            <table>
                <tr>
                    <td>Voter Name:
                    </td>
                    <td>
                        <asp:TextBox ID="voterNameTextBox" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>Voter Id:
                    </td>
                    <td>
                        <asp:TextBox ID="voterIdTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClientClick="return validateForm()" OnClick="saveButton_Click" /></td>
                    <td>
                        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
            </div>
    </form>
    <script>
        function validateForm() {
            var voterName = document.forms["form1"]["voterNameTextBox"].value;
            var voterId = document.forms["form1"]["voterIdTextBox"].value;
            if (voterName == null || voterName == "") {
                alert("Name must be filled out");
                return false;
            }
            if (voterId == null || voterId == "") {
                alert("Voter Id must be filled out");
                return false;
            }
            if (voterId.length < 12) {
                alert("Voter Id must be grater then 12 characters");
                return false;
            }
        }
    </script>
   <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
</body>
</html>
