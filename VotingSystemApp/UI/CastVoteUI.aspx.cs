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
    public partial class CastVote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CastVoteManager castVoteManager=new CastVoteManager();

            if (!IsPostBack)
            {
                symbolDropDownList.DataSource = castVoteManager.GetAllSymbols();
                symbolDropDownList.DataTextField = "Symbol";
                symbolDropDownList.DataValueField = "Id";
                symbolDropDownList.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            VoteCast voteCast=new VoteCast();
            voteCast.VoterId = voterIdTextBox.Text;
            voteCast.CandidateId =Convert.ToInt32(symbolDropDownList.SelectedValue);
            CastVoteManager castVoteManager=new CastVoteManager();
           bool isSuccess= castVoteManager.Save(voteCast);
        }
    }
}