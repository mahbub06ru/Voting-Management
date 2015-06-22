using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingSystemApp.Models
{
    public class VoteCast
    {
        public int Id { get; set; }
        public string VoterId { get; set; }
        public int CandidateId { get; set; }
    }
}