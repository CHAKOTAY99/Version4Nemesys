﻿using System;
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
using Microsoft.AspNetCore.Identity;

namespace Version4Nemesys.Controllers
{
    public class InvestigationController : Controller
    {
        private readonly IInvestigationRepository _repository;

        private readonly UserManager<IdentityUser> _userManager;

        public InvestigationController(IInvestigationRepository repository, UserManager<IdentityUser> userManager)
        {
            _repository = repository;

            _userManager = userManager;
        }

        public IActionResult Create()
        {
            return View();
        }

        // Linking to an investigation for the specific report
        [Route("Create/{id:int}")]
        public IActionResult RetreiveReport(int id)
        {
            var item = _repository.InvestigationByReport(id);
            InvestigationViewModel investigationView = new InvestigationViewModel()
            {
                ReportUsed = id
            };
            investigationView.RelatedReport = item;
            //_repository.AddInvestigation(investigationView);
            return View("Create", investigationView);
        }

        // Add the investigation
        public IActionResult AddInvestigation(InvestigationViewModel InvestigationVM)
        {
            var userId = _userManager.GetUserId(User);
            InvestigationVM.UserId = userId;
            _repository.AddInvestigation(InvestigationVM);
            return RedirectToAction("Index");
        }
        
        // List the Investigations
        public IActionResult Index()
        {
            ViewBag.Investigations = _repository.GetInvestigations();
            return View();
        }

        // Give details of the Report
        [Route("InvestigationDetails/{id:int}")]
        public IActionResult Details(int id)
        {
            var investigation = _repository.GetInvestigationDetails(id);
            InvestigationViewModel detailedInvestigation = new InvestigationViewModel()
            {
                Investigation = investigation
            };
            return View(detailedInvestigation);
        }

        // Switching to the Edit page of an investigation
        [Route("EditInvestigation/{id:int}")]
        public IActionResult Edit(int id)
        {
            var investigation = _repository.GetInvestigationDetails(id);
            InvestigationViewModel detailedInvestigation = new InvestigationViewModel()
            {
                Investigation = investigation,
                InvestigationID = investigation.InvestigationID,
                InvestigationsInTest = investigation.InvestigationsInTest
            };
            return View("Edit", detailedInvestigation);
        }

        // Updating the edited investigaiton
        public IActionResult EditInvestigation(InvestigationViewModel InvestigationVM)
        {
            _repository.EditInvestigation(InvestigationVM);
            return RedirectToAction("Index");
        }
    }
}
