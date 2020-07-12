using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErhanAkcayCET322FinalProject.Models
{
    public class Matches
    {

        Team teamsrep = new Team();

      
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int HomeGoals { get; set; }

        public int AwayGoals { get; set; }

        public DateTime Timestamp { get; set; }
        
        public string MatchName { get; set; }
    }

}
