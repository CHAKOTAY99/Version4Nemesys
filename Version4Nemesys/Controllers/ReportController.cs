using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Version4Nemesys.Data;
using Version4Nemesys.Models;
using Version4Nemesys.ViewModels;
using Version4Nemesys.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Version4Nemesys.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportRepository _repository;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<IdentityUser> _userManager;

        public ReportController(IReportRepository reportRepository, IHostingEnvironment hostingEnvironment, UserManager<IdentityUser> userManager)
        {
            _repository = reportRepository;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public IActionResult Create()
        {
            return View();
        }

        // Adding a new Report
        [HttpPost]
        [Authorize]
        public IActionResult AddReport(ReportViewModel ReportVM)
        {            
            string uniqueFileName = null;
            var userId = _userManager.GetUserId(User);
            ReportVM.UserId = userId;
            if (ReportVM.Photo != null)
            {
                string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "UploadedImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ReportVM.Photo.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFileName);
                ReportVM.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                ReportVM.PhotoLocation = uniqueFileName;
            }
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
