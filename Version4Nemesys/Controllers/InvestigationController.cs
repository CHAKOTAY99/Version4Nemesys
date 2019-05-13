using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Version4Nemesys.Data;
using Version4Nemesys.Models;

namespace Version4Nemesys.Controllers
{
    public class InvestigationController : Controller
    {

        /*
        private readonly ApplicationDbContext _context;

        public InvestigationModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InvestigationModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Investigations.ToListAsync());
        }

        // GET: InvestigationModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investigationModel = await _context.Investigations
                .FirstOrDefaultAsync(m => m.InvestigationID == id);
            if (investigationModel == null)
            {
                return NotFound();
            }

            return View(investigationModel);
        }

        // GET: InvestigationModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InvestigationModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InvestigationID,ActionDate,InvestigationDescription,UserID,States")] InvestigationModel investigationModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(investigationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(investigationModel);
        }

        // GET: InvestigationModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investigationModel = await _context.Investigations.FindAsync(id);
            if (investigationModel == null)
            {
                return NotFound();
            }
            return View(investigationModel);
        }

        // POST: InvestigationModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InvestigationID,ActionDate,InvestigationDescription,UserID,States")] InvestigationModel investigationModel)
        {
            if (id != investigationModel.InvestigationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(investigationModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvestigationModelExists(investigationModel.InvestigationID))
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
            return View(investigationModel);
        }

        // GET: InvestigationModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investigationModel = await _context.Investigations
                .FirstOrDefaultAsync(m => m.InvestigationID == id);
            if (investigationModel == null)
            {
                return NotFound();
            }

            return View(investigationModel);
        }

        // POST: InvestigationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var investigationModel = await _context.Investigations.FindAsync(id);
            _context.Investigations.Remove(investigationModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvestigationModelExists(int id)
        {
            return _context.Investigations.Any(e => e.InvestigationID == id);
        }
        */
    }
}
