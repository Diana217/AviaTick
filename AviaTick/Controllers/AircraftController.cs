using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AviaTick;

namespace AviaTick.Controllers
{
    public class AircraftController : Controller
    {
        private readonly AviaTickDbContext _context;

        public AircraftController(AviaTickDbContext context)
        {
            _context = context;
        }

        // GET: Aircraft
        public async Task<IActionResult> Index()
        {
              return _context.Aircraft != null ? 
                          View(await _context.Aircraft.ToListAsync()) :
                          Problem("Entity set 'AviaTickDbContext.Aircraft'  is null.");
        }

        // GET: Aircraft/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Aircraft == null)
            {
                return NotFound();
            }

            var aircraft = await _context.Aircraft
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aircraft == null)
            {
                return NotFound();
            }

            return View(aircraft);
        }

        // GET: Aircraft/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aircraft/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SeatsNumber")] Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aircraft);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aircraft);
        }

        // GET: Aircraft/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Aircraft == null)
            {
                return NotFound();
            }

            var aircraft = await _context.Aircraft.FindAsync(id);
            if (aircraft == null)
            {
                return NotFound();
            }
            return View(aircraft);
        }

        // POST: Aircraft/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SeatsNumber")] Aircraft aircraft)
        {
            if (id != aircraft.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aircraft);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AircraftExists(aircraft.Id))
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
            return View(aircraft);
        }

        // GET: Aircraft/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Aircraft == null)
            {
                return NotFound();
            }

            var aircraft = await _context.Aircraft
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aircraft == null)
            {
                return NotFound();
            }

            return View(aircraft);
        }

        // POST: Aircraft/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Aircraft == null)
            {
                return Problem("Entity set 'AviaTickDbContext.Aircraft'  is null.");
            }
            var aircraft = await _context.Aircraft.FindAsync(id);
            if (aircraft != null)
            {
                _context.Aircraft.Remove(aircraft);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AircraftExists(int id)
        {
          return (_context.Aircraft?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
