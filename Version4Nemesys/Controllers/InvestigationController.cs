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
using Version4Nemesys.Interfaces;
using Version4Nemesys.ViewModels;

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

        // Creating an investigation for the specific report
        [Route("Investigation/{id:int}")]
        public IActionResult AddInvestigation(int id)
        {
            var item = _repository.InvestigationByReport(id);
            InvestigationViewModel investigationView = new InvestigationViewModel()
            {
                ReportUsed = id
            };
            investigationView.RelatedReport = item;
            _repository.AddInvestigation(investigationView);
            return View(investigationView);
        }

        // List the Reports
        public IActionResult Index()
        {
            ViewBag.Reports = _repository.GetInvestigations();
            return View();
        }
    }
}
