using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Version4Nemesys.ViewModels;

namespace Version4Nemesys.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public AccountController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        
        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }
        
        public async Task<ActionResult> RoleChangeAsync(AccountViewModel AccountVM)
        {
            var userId = _userManager.GetUserId(User);
            IdentityUser user = await _userManager.FindByIdAsync(userId);
            //IdentityUser user = await UserManager.Find
            if(AccountVM.JobsList == 0)
            {
                await _userManager.AddToRoleAsync(user, "Investigator");
            } else
            {
                await _userManager.AddToRoleAsync(user, "Reporter");
            }
            return RedirectToAction("Index");
        }
        /*
        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}