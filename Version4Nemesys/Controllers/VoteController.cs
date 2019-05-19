using System;
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

        // Adding a vote under a specific report
        public IActionResult AddVote(VoteViewModel VoteVM)
        {
            //var report = _repository.VoteReport(ReportChosen);
            _repository.AddVote(VoteVM);

            return RedirectToAction("Index");
        }

        [Route("Details/{id:int}")]
        public IActionResult MoarVote(int id)
        {

            VoteViewModel voteView = new VoteViewModel()
            {
                ReportID = id
            };
            _repository.AddVote(voteView);
            return RedirectToAction("Index");
        }
    }
}
