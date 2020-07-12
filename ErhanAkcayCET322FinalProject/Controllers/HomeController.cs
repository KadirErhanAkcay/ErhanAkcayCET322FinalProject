using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ErhanAkcayCET322FinalProject.Models;
using ErhanAkcayCET322FinalProject.Data;

namespace ErhanAkcayCET322FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly matchreportsContext _context;

        public HomeController(matchreportsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var matchreport = _context.MatchReports.ToList();


            return View(matchreport);
            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
