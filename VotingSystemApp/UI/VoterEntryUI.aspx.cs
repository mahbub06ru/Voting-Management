using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VotingSystemApp.BLL;
using VotingSystemApp.Models;

namespace VotingSystemApp.UI
{
    public partial class VoterEntryUI : System.Web.UI.Page
    {
        VoterManager voterManager = new VoterManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Voter voter = new Voter();
        protected void saveButton_Click(object sender, EventArgs e)
        {
            
            voter.Name = voterNameTextBox.Text;
            voter.VoterId = voterIdTextBox.Text;
            bool isSuccess = false;
               isSuccess= voterManager.Save(voter);
           if (!isSuccess)
            {
                messageLabel.Text = "Voter Already Exit!";
                return;
            }
            else
            {
                messageLabel.Text = "Voter Entry Successfully!";
                voterNameTextBox.Text = string.Empty;
                voterIdTextBox.Text = string.Empty;
            }
           
            
        }
    }
}