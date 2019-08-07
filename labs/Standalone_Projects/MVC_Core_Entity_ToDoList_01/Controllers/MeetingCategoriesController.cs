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
    public class MeetingCategoriesController : Controller
    {
        private readonly TaskDbContext _context;

        public MeetingCategoriesController(TaskDbContext context)
        {
            _context = context;
        }

        // GET: MeetingCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.MeetingCategory.ToListAsync());
        }

        // GET: MeetingCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetingCategory = await _context.MeetingCategory
                .FirstOrDefaultAsync(m => m.MeetingCategoryID == id);
            if (meetingCategory == null)
            {
                return NotFound();
            }

            return View(meetingCategory);
        }

        // GET: MeetingCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MeetingCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MeetingCategoryID,CategoryName")] MeetingCategory meetingCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meetingCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meetingCategory);
        }

        // GET: MeetingCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetingCategory = await _context.MeetingCategory.FindAsync(id);
            if (meetingCategory == null)
            {
                return NotFound();
            }
            return View(meetingCategory);
        }

        // POST: MeetingCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MeetingCategoryID,CategoryName")] MeetingCategory meetingCategory)
        {
            if (id != meetingCategory.MeetingCategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meetingCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingCategoryExists(meetingCategory.MeetingCategoryID))
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
            return View(meetingCategory);
        }

        // GET: MeetingCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetingCategory = await _context.MeetingCategory
                .FirstOrDefaultAsync(m => m.MeetingCategoryID == id);
            if (meetingCategory == null)
            {
                return NotFound();
            }

            return View(meetingCategory);
        }

        // POST: MeetingCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meetingCategory = await _context.MeetingCategory.FindAsync(id);
            _context.MeetingCategory.Remove(meetingCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingCategoryExists(int id)
        {
            return _context.MeetingCategory.Any(e => e.MeetingCategoryID == id);
        }
    }
}
