using ErhanAkcayCET322FinalProject.Data;
using ErhanAkcayCET322FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErhanAkcayCET322FinalProject.ViewComponents
{
    [ViewComponent(Name = "TeamProfileViewComponent")]
    public class TeamProfileViewComponent:ViewComponent
    {

        private readonly ApplicationDbContext _context;
        private readonly matchesContext _matchcontext;

        public TeamProfileViewComponent(ApplicationDbContext context, matchesContext matchcontext)
        {
            _context = context;
            _matchcontext = matchcontext;

        }


        public async Task<IViewComponentResult> InvokeAsync(int? Id)
        {


            var content = await _matchcontext.Matches.Where(p => p.HomeTeamId == Id || p.AwayTeamId == Id).ToListAsync();

            return View(content);
        }

        
    }
}

    

