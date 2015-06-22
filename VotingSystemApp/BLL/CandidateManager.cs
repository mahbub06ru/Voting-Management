using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VotingSystemApp.DAL;
using VotingSystemApp.Models;

namespace VotingSystemApp.BLL
{
    public class CandidateManager
    {
        CandidateGateway candidateGateway=new CandidateGateway();
        public bool Save(Candidate candidate)
        {
            bool isSymbolExit = IsSymbolExits(candidate.Symbol);
            if (isSymbolExit)
            {
                return false;
            }
            return candidateGateway.Save(candidate) > 0;
        }

        private bool IsSymbolExits(string symbol)
        {
            Candidate candidate = candidateGateway.GetCandidateBySymbol(symbol);
            if (candidate != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}