using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Version4Nemesys.Data;
using Version4Nemesys.Models;
using Version4Nemesys.Repositories;
using Version4Nemesys.Models.ViewModels;

namespace Version4Nemesys.Controllers
{
    public class InvestigationController : Controller
    {
        private readonly IInvestigationRepository _repository;

        public InvestigationController(IInvestigationRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Create()
        {
            return View();
        }

        // Adding a new Report
        public IActionResult AddInvestigation(InvestigationViewModel InvestigationVM, int id)
        {
            _repository.AddInvestigation(InvestigationVM, id);
            return RedirectToAction("Index");
        }

        // List the Reports
        public IActionResult Index()
        {
            ViewBag.Reports = _repository.GetInvestigations();
            return View();
        }
        /*
        // Give details of the Report
        [Route("Details/{id:int}")]
        public IActionResult Details(int id)
        {
            var report = _repository.ShowInvestigationDetails(id);
            ReportViewModel detailModel = new ReportViewModel()
            {
                Report = report
            };
            return View(detailModel);
        }
        */
    }
}
