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
    public partial class CandidateEntryUI : System.Web.UI.Page
    {
        CandidateManager candidateManager=new CandidateManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Candidate candidate=new Candidate();
            candidate.Name = candidateNameTextBox.Text;
            candidate.Symbol = symbolIdTextBox.Text;
            bool isSuccess = false;
            isSuccess = candidateManager.Save(candidate);
            if (!isSuccess)
            {
                messageLabel.Text = "Symbol Already Exit!";
                return;
            }
            else
            {
                messageLabel.Text = "Candidate Entry Successfully!";
                candidateNameTextBox.Text = string.Empty;
                symbolIdTextBox.Text = string.Empty;
            }
           
        }
    }
}