using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Core_Entity_ToDoList_01.Models;

namespace MVC_Core_Entity_ToDoList_01.Controllers
{
    public class AthleticsMeetingsController : Controller
    {
        private readonly TaskDbContext _context;

        public AthleticsMeetingsController(TaskDbContext context)
        {
            _context = context;
        }

        // GET: AthleticsMeetings
        public async Task<IActionResult> Index()
        {
            var taskDbContext = _context.AthleticsMeetings.Include(a => a.MeetingCategory);
            return View(await taskDbContext.ToListAsync());
        }

        // GET: AthleticsMeetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athleticsMeetings = await _context.AthleticsMeetings
                .Include(a => a.MeetingCategory)
                .FirstOrDefaultAsync(m => m.AthleticsMeetingsID == id);
            if (athleticsMeetings == null)
            {
                return NotFound();
            }

            return View(athleticsMeetings);
        }

        // GET: AthleticsMeetings/Create
        public IActionResult Create()
        {
            ViewData["MeetingCategoryID"] = new SelectList(_context.MeetingCategory, "MeetingCategoryID", "CategoryName");
            return View();
        }

        // POST: AthleticsMeetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AthleticsMeetingsID,MeetingName,MeetingLocation,MeetingDate,MeetingCategoryID")] AthleticsMeetings athleticsMeetings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(athleticsMeetings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MeetingCategoryID"] = new SelectList(_context.MeetingCategory, "MeetingCategoryID", "CategoryName", athleticsMeetings.MeetingCategoryID);
            return View(athleticsMeetings);
        }

        // GET: AthleticsMeetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athleticsMeetings = await _context.AthleticsMeetings.FindAsync(id);
            if (athleticsMeetings == null)
            {
                return NotFound();
            }
            ViewData["MeetingCategoryID"] = new SelectList(_context.MeetingCategory, "MeetingCategoryID", "CategoryName", athleticsMeetings.MeetingCategoryID);
            return View(athleticsMeetings);
        }

        // POST: AthleticsMeetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AthleticsMeetingsID,MeetingName,MeetingLocation,MeetingDate,MeetingCategoryID")] AthleticsMeetings athleticsMeetings)
        {
            if (id != athleticsMeetings.AthleticsMeetingsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(athleticsMeetings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AthleticsMeetingsExists(athleticsMeetings.AthleticsMeetingsID))
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
            ViewData["MeetingCategoryID"] = new SelectList(_context.MeetingCategory, "MeetingCategoryID", "CategoryName", athleticsMeetings.MeetingCategoryID);
            return View(athleticsMeetings);
        }

        // GET: AthleticsMeetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athleticsMeetings = await _context.AthleticsMeetings
                .Include(a => a.MeetingCategory)
                .FirstOrDefaultAsync(m => m.AthleticsMeetingsID == id);
            if (athleticsMeetings == null)
            {
                return NotFound();
            }

            return View(athleticsMeetings);
        }

        // POST: AthleticsMeetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var athleticsMeetings = await _context.AthleticsMeetings.FindAsync(id);
            _context.AthleticsMeetings.Remove(athleticsMeetings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AthleticsMeetingsExists(int id)
        {
            return _context.AthleticsMeetings.Any(e => e.AthleticsMeetingsID == id);
        }
    }
}
