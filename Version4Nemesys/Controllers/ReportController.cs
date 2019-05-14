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

        // Give details of the Report
        [Route("Details/{id:int}")]
        public IActionResult Details(int id)
        {
            var report = _repository.ShowReportDetails(id);
            ReportViewModel detailModel = new ReportViewModel()
            {
                Report = report
            };
            return View(detailModel);
        }
    }
}
