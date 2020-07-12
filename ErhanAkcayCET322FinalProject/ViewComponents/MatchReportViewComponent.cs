using ErhanAkcayCET322FinalProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErhanAkcayCET322FinalProject.Models;

namespace ErhanAkcayCET322FinalProject.ViewComponents
{

    [ViewComponent(Name ="MatchReportViewComponent")]
    public class MatchReportViewComponent:ViewComponent
    {
        private readonly matchreportsContext _context;
        
        public MatchReportViewComponent(matchreportsContext context)
        {
            _context = context;
            
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            
            var content = await _context.MatchReports.OrderByDescending(p => p.Id).ToListAsync();

            return View(content);
        }


    }
}
