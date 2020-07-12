using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErhanAkcayCET322FinalProject.Models
{
    public class MatchReports
    {

        public int Id { get; set; }
        public int MatchId{ get; set; }
        public string Contents { get; set; }

        public DateTime Timestamp { get; set; }

        public string MatchName { get; set; }
        
        public string MatchScore { get; set; }
    }
}
