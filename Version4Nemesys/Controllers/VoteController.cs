using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<IdentityUser> _userManager;

        public VoteController(IVoteRepository repository, UserManager<IdentityUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }
        // Adding a record in vote 
        [Route("Vote/{id:int}")]
        public IActionResult AddVote(int id)
        {
            var userId = _userManager.GetUserId(User);
            var item = _repository.VoteByReport(id);
            VoteViewModel voteView = new VoteViewModel()
            {
                ReportID = id,
                UserId = userId
        };
            voteView.RelatedReport = item;
            _repository.AddVote(voteView);
            return RedirectToAction("Index", "Report");
        }
    }
}
