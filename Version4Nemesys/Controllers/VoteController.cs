﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Version4Nemesys.Data;
using Version4Nemesys.Interfaces;
using Version4Nemesys.Models;
using Version4Nemesys.ViewModels;

namespace Version4Nemesys.Controllers
{
    public class VoteController : Controller
    {
        private readonly IVoteRepository _repository;

        public VoteController(IVoteRepository repository)
        {
            _repository = repository;
        }
        // Adding a record in vote 
        [Route("Vote/{id:int}")]
        public IActionResult AddVote(int id)
        {
            var item = _repository.VoteByReport(id);
            VoteViewModel voteView = new VoteViewModel()
            {
                ReportID = id
            };
            voteView.RelatedReport = item;
            _repository.AddVote(voteView);
            return RedirectToAction("Index", "Report");
        }
    }
}
