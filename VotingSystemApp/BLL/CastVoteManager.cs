using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VotingSystemApp.DAL;
using VotingSystemApp.Models;

namespace VotingSystemApp.BLL
{
    public class CastVoteManager
    {
        CastVoteGateway castVoteGateway=new CastVoteGateway();
        public List<Candidate> GetAllSymbols()
        {
            return castVoteGateway.GetAllSymbols();
        }

        public bool Save(VoteCast voteCast)
        {
           return castVoteGateway.Save(voteCast)>0;
        }
    }
}