using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VotingSystemApp.DAL;
using VotingSystemApp.Models;

namespace VotingSystemApp.BLL
{
    public class VoterManager
    {
        VoterGateway voterGateway=new VoterGateway();
        public bool IsVoterIdExits(string voterId)
        {
            Voter voter = voterGateway.GetVoterByVoterId(voterId);
            if (voter != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Save(Voter voter)
        {
            bool isVoterIdExit = IsVoterIdExits(voter.VoterId);
            if (isVoterIdExit)
            {
                return false;
            }
            return voterGateway.Save(voter)>0;
        }

      
    }
}