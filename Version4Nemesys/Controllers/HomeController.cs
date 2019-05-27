using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Version4Nemesys.Interfaces;
using Version4Nemesys.Models;
using Version4Nemesys.Repositories;

namespace Version4Nemesys.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepository _repository;

        public HomeController(IHomeRepository homeRepository)
        {
            _repository = homeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Leaderboard()
        {
            ViewBag.UserCounter = _repository.GetLeaderboard();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
