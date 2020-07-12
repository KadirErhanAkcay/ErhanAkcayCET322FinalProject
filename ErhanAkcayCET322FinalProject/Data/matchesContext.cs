using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ErhanAkcayCET322FinalProject.Models;

namespace ErhanAkcayCET322FinalProject.Data
{
    public class matchesContext : DbContext
    {
        public matchesContext (DbContextOptions<matchesContext> options)
            : base(options)
        {
        }

        public DbSet<ErhanAkcayCET322FinalProject.Models.Matches> Matches { get; set; }

        public DbSet<ErhanAkcayCET322FinalProject.Models.MatchReports> MatchReport { get; set; }
    }
}
