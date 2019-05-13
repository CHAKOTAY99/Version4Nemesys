using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Version4Nemesys.Data;
using Version4Nemesys.Models;
using Version4Nemesys.Models.ViewModels;
using Version4Nemesys.Repositories;

namespace Version4Nemesys.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportRepository _repository;

        public ReportController(IReportRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Create()
        {
            return View();
        }

        // Adding a new Report
        public IActionResult AddReport(ReportViewModel ReportVM)
        {
            _repository.AddReport(ReportVM);
            return RedirectToAction("Index");
        }

        // List the Reports
        public IActionResult Index()
        {
            ViewBag.Reports = _repository.GetReports();
            return View();
        }

        /*
        // GET: Report
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reports.Include(r => r.HazardsModel).Include(r => r.PhotoModel);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Report/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportModel = await _context.Reports
                .Include(r => r.HazardsModel)
                .Include(r => r.PhotoModel)
                .FirstOrDefaultAsync(m => m.ReportID == id);
            if (reportModel == null)
            {
                return NotFound();
            }

            return View(reportModel);
        }

        // GET: Report/Create
        public IActionResult Create()
        {
            ViewData["HazardID"] = new SelectList(_context.Hazard, "HazardID", "HazardName");
            ViewData["PhotoID"] = new SelectList(_context.Photos, "PhotoID", "PhotoName");
            return View();
        }

        // POST: Report/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportID,EventDate,ReportDate,HazardID,UserID,EventLocation,EventDescription,PhotoID,ReportUpvotes,States")] ReportModel reportModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HazardID"] = new SelectList(_context.Hazard, "HazardID", "HazardName", reportModel.HazardID);
            ViewData["PhotoID"] = new SelectList(_context.Photos, "PhotoID", "PhotoName", reportModel.PhotoID);
            return View(reportModel);
        }

        // GET: Report/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportModel = await _context.Reports.FindAsync(id);
            if (reportModel == null)
            {
                return NotFound();
            }
            ViewData["HazardID"] = new SelectList(_context.Hazard, "HazardID", "HazardName", reportModel.HazardID);
            ViewData["PhotoID"] = new SelectList(_context.Photos, "PhotoID", "PhotoName", reportModel.PhotoID);
            return View(reportModel);
        }

        // POST: Report/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportID,EventDate,ReportDate,HazardID,UserID,EventLocation,EventDescription,PhotoID,ReportUpvotes,States")] ReportModel reportModel)
        {
            if (id != reportModel.ReportID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportModelExists(reportModel.ReportID))
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
            ViewData["HazardID"] = new SelectList(_context.Hazard, "HazardID", "HazardName", reportModel.HazardID);
            ViewData["PhotoID"] = new SelectList(_context.Photos, "PhotoID", "PhotoName", reportModel.PhotoID);
            return View(reportModel);
        }

        // GET: Report/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportModel = await _context.Reports
                .Include(r => r.HazardsModel)
                .Include(r => r.PhotoModel)
                .FirstOrDefaultAsync(m => m.ReportID == id);
            if (reportModel == null)
            {
                return NotFound();
            }

            return View(reportModel);
        }

        // POST: Report/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportModel = await _context.Reports.FindAsync(id);
            _context.Reports.Remove(reportModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportModelExists(int id)
        {
            return _context.Reports.Any(e => e.ReportID == id);
        }
        */
    }
}
