using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CreateDesignOrganize.Models;
using Microsoft.AspNetCore.Identity;

namespace CreateDesignOrganize.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                ViewData["Message"] = "Hi " + currentUser.FirstName + "!";
            }
            else
            {
                ViewData["Message"] = "No one is logged in! :(";
            }

            return View();
        }

        public async Task<IActionResult> Contact()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                ViewData["Message"] = "Welcome " + currentUser.FirstName +"!";
            }
            else
            {
                ViewData["Message"] = "No one is logged in! :(";
            }

            return View();
        }

        public async Task<IActionResult> Planner()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                ViewData["Message"] = "Welcome " + currentUser.FirstName + "!";
            }
            else
            {
                ViewData["Message"] = "No one is logged in! :(";
            }

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
