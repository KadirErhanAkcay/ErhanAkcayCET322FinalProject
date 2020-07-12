using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ErhanAkcayCET322FinalProject.Models;

namespace ErhanAkcayCET322FinalProject.Data
{
    public class matchreportsContext : DbContext
    {
        public matchreportsContext (DbContextOptions<matchreportsContext> options)
            : base(options)
        {
        }

        public DbSet<ErhanAkcayCET322FinalProject.Models.MatchReports> MatchReports { get; set; }
    }
}
