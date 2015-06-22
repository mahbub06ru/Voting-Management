<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CastVoteUI.aspx.cs" Inherits="VotingSystemApp.UI.CastVote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <ul class="nav nav-pills">
                <li ><a href="VoterEntryUI.aspx">Visitor Entry</a></li>
                <li><a href="CandidateEntryUI.aspx">Candidate Entry</a></li>
                <li  class="active"><a href="CastVoteUI.aspx">Cast Vote</a></li>
                <li><a href="#">View Result</a></li>
            </ul>
        <br/><br/>
    <div>
        <table>
            <tr>
                <td>Voter Id:</td>
                <td>
                    <asp:TextBox ID="voterIdTextBox" runat="server"></asp:TextBox>

                </td>
            </tr>
            
             <tr>
                <td>Select Symbol of Candidate:</td>
                <td>
                    <asp:DropDownList ID="symbolDropDownList" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                </td>
            </tr>
        </table>
    </div>
    </div>
    </form>
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
</body>
</html>
