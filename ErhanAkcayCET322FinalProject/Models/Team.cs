using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErhanAkcayCET322FinalProject.Models
{
    public class Team
    {

        
       
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public List<Player> Players { get; set; }
    }
}
