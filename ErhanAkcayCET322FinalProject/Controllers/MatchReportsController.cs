using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ErhanAkcayCET322FinalProject.Data;
using ErhanAkcayCET322FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using System.Text.RegularExpressions;

namespace ErhanAkcayCET322FinalProject.Controllers
{

    [Authorize]
    public class MatchReportsController : Controller
    {
        private readonly matchreportsContext _context;

        public MatchReportsController(matchreportsContext context)
        {
            _context = context;
        }

        // GET: MatchReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.MatchReports.ToListAsync());
        }

        [AllowAnonymous]
        public async Task<IActionResult> matchprofile(int MatchId)
        {
           var matchpro =  _context.MatchReports.Where(p => p.MatchId == MatchId).FirstOrDefault();


            return View(matchpro);
        }

        [AllowAnonymous]
        public async Task<IActionResult> allmatchreports()
        {
            var matchreport = await _context.MatchReports.ToListAsync();


            return View(matchreport);
        }
        // GET: MatchReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchReports = await _context.MatchReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchReports == null)
            {
                return NotFound();
            }

            return View(matchReports);
        }

        // GET: MatchReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MatchReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create([Bind("Id,MatchId,Contents")] MatchReports matchReports)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matchReports);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matchReports);
        }

        // GET: MatchReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchReports = await _context.MatchReports.FindAsync(id);
            if (matchReports == null)
            {
                return NotFound();
            }
            return View(matchReports);
        }

        // POST: MatchReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchId,Contents")] MatchReports matchReports)
        {
            if (id != matchReports.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matchReports);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchReportsExists(matchReports.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(matchReports);
        }

        // GET: MatchReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchReports = await _context.MatchReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchReports == null)
            {
                return NotFound();
            }

            return View(matchReports);
        }

        // POST: MatchReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matchReports = await _context.MatchReports.FindAsync(id);
            _context.MatchReports.Remove(matchReports);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchReportsExists(int id)
        {
            return _context.MatchReports.Any(e => e.Id == id);
        }
    }
}
