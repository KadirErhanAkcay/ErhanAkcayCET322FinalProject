using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ErhanAkcayCET322FinalProject.Models;

namespace ErhanAkcayCET322FinalProject.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Index()
        {

            List<LeagueTableResult> results = new List<LeagueTableResult>();
            return View();
        }
    }
}
