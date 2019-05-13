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
    public class HazardController : Controller
    {

        /* THIS IS TEMPORARLY RETIRED */

        private readonly IHazardRepository _repository;

        public HazardController(IHazardRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Create()
        {
            return View();
        }

        // Adding a new hazard
        public IActionResult AddHazard(HazardViewModel HazardVM)
        {
            _repository.AddHazard(HazardVM);
            return RedirectToAction("Index");
        }
        
        // List the Hazards
        public IActionResult Index()
        {
            ViewBag.Hazards = _repository.GetHazards();
            return View();
        }

        /*
        // GET: Hazard
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hazard.ToListAsync());
        }
        /*
        // GET: Hazard/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hazardModel = await _context.Hazard
                .FirstOrDefaultAsync(m => m.HazardID == id);
            if (hazardModel == null)
            {
                return NotFound();
            }

            return View(hazardModel);
        }
        
        // GET: Hazard/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hazard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HazardID,HazardName")] HazardModel hazardModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hazardModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hazardModel);
        }

        // GET: Hazard/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hazardModel = await _context.Hazard.FindAsync(id);
            if (hazardModel == null)
            {
                return NotFound();
            }
            return View(hazardModel);
        }

        // POST: Hazard/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HazardID,HazardName")] HazardModel hazardModel)
        {
            if (id != hazardModel.HazardID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hazardModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HazardModelExists(hazardModel.HazardID))
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
            return View(hazardModel);
        }

        // GET: Hazard/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hazardModel = await _context.Hazard
                .FirstOrDefaultAsync(m => m.HazardID == id);
            if (hazardModel == null)
            {
                return NotFound();
            }

            return View(hazardModel);
        }

        // POST: Hazard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hazardModel = await _context.Hazard.FindAsync(id);
            _context.Hazard.Remove(hazardModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HazardModelExists(int id)
        {
            return _context.Hazard.Any(e => e.HazardID == id);
        }
        */
    }
}
