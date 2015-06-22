using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingSystemApp.Models
{
    public class Voter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VoterId { get; set; }
    }
}