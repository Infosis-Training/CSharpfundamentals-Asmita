using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Data;
using MovieManagement.Models;

namespace MovieManagement.Controllers
{
    public class CrewController : Controller
    {
        private readonly MovieManagementDb _context;

        public CrewController(MovieManagementDb context)
        {
            _context = context;
        }

        // GET: Crew
        public async Task<IActionResult> Index()
        {
              return _context.Crew != null ? 
                          View(await _context.Crew.ToListAsync()) :
                          Problem("Entity set 'MovieManagementDb.Crew'  is null.");
        }

        // GET: Crew/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Crew == null)
            {
                return NotFound();
            }

            var crew = await _context.Crew
                .FirstOrDefaultAsync(m => m.Id == id);
            if (crew == null)
            {
                return NotFound();
            }

            return View(crew);
        }

        // GET: Crew/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Crew/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Role,Phone,Dob")] Crew crew)
        {
            if (ModelState.IsValid)
            {
                _context.Add(crew);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(crew);
        }

        // GET: Crew/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Crew == null)
            {
                return NotFound();
            }

            var crew = await _context.Crew.FindAsync(id);
            if (crew == null)
            {
                return NotFound();
            }
            return View(crew);
        }

        // POST: Crew/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Role,Phone,Dob")] Crew crew)
        {
            if (id != crew.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(crew);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CrewExists(crew.Id))
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
            return View(crew);
        }

        // GET: Crew/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Crew == null)
            {
                return NotFound();
            }

            var crew = await _context.Crew
                .FirstOrDefaultAsync(m => m.Id == id);
            if (crew == null)
            {
                return NotFound();
            }

            return View(crew);
        }

        // POST: Crew/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Crew == null)
            {
                return Problem("Entity set 'MovieManagementDb.Crew'  is null.");
            }
            var crew = await _context.Crew.FindAsync(id);
            if (crew != null)
            {
                _context.Crew.Remove(crew);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CrewExists(int id)
        {
          return (_context.Crew?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
