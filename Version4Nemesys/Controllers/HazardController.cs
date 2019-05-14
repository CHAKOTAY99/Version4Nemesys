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
    }
}
