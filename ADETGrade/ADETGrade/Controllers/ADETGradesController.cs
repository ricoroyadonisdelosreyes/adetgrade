using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ADETGrade.GradeData;
using ADETGrade.Models;

namespace ADETGrade.Controllers
{
    public class ADETGradesController : Controller
    {
        private readonly GradeContext _context;

        public ADETGradesController(GradeContext context)
        {
            _context = context;
        }

        // GET: ADETGrades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Grades.ToListAsync());
        }

        // GET: ADETGrades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aDETGrades = await _context.Grades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aDETGrades == null)
            {
                return NotFound();
            }

            return View(aDETGrades);
        }

        // GET: ADETGrades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ADETGrades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudName,Address,Course,YearSection,PrelimQ1,PrelimQ2,PrelimQ3,PrelimA1,PrelimA2,PrelimA3,PrelimTotal,MidtermQ1,MidtermQ2,MidtermQ3,MidtermA1,MidtermA2,MidtermA3,MidTermTotal,PreFinalQ1,PreFinalQ2,PreFinalQ3,PreFinalA1,PreFinalA2,PreFinalA3,PreFinalTotal,FinalQ1,FinalQ2,FinalQ3,FinalA1,FinalA2,FinalA3,FinalTotal")] ADETGrades aDETGrades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aDETGrades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aDETGrades);
        }

        // GET: ADETGrades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aDETGrades = await _context.Grades.FindAsync(id);
            if (aDETGrades == null)
            {
                return NotFound();
            }
            return View(aDETGrades);
        }

        // POST: ADETGrades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudName,Address,Course,YearSection,PrelimQ1,PrelimQ2,PrelimQ3,PrelimA1,PrelimA2,PrelimA3,PrelimTotal,MidtermQ1,MidtermQ2,MidtermQ3,MidtermA1,MidtermA2,MidtermA3,MidTermTotal,PreFinalQ1,PreFinalQ2,PreFinalQ3,PreFinalA1,PreFinalA2,PreFinalA3,PreFinalTotal,FinalQ1,FinalQ2,FinalQ3,FinalA1,FinalA2,FinalA3,FinalTotal")] ADETGrades aDETGrades)
        {
            if (id != aDETGrades.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aDETGrades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ADETGradesExists(aDETGrades.Id))
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
            return View(aDETGrades);
        }

        // GET: ADETGrades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aDETGrades = await _context.Grades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aDETGrades == null)
            {
                return NotFound();
            }

            return View(aDETGrades);
        }

        // POST: ADETGrades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aDETGrades = await _context.Grades.FindAsync(id);
            _context.Grades.Remove(aDETGrades);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ADETGradesExists(int id)
        {
            return _context.Grades.Any(e => e.Id == id);
        }
    }
}
