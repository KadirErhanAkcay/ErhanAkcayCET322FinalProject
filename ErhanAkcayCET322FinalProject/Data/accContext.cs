using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ErhanAkcayCET322FinalProject.Models;

namespace ErhanAkcayCET322FinalProject.Data
{
    public class accContext : DbContext
    {
        public accContext (DbContextOptions<accContext> options)
            : base(options)
        {
        }

        public DbSet<ErhanAkcayCET322FinalProject.Models.Account> Account { get; set; }
    }
}
