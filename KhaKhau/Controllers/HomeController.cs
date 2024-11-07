﻿using KhaKhau.Areas.Identity.Data;
using KhaKhau.Models;
using KhaKhau.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KhaKhau.Controllers
{


    
    public class HomeController : Controller
    {
        
       
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this._userManager = userManager;
        }

        [AllowAnonymous]
        
        public IActionResult Index() {
          
            ViewData["UserID"]= _userManager.GetUserId(this.User);
        
            return View();
        }
        [Authorize(Roles ="user")]
        
        public IActionResult Privacy()
        {
            return View();
        } 
        public IActionResult temptList()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult GioiThieu()
        {
            return View();
        }

    }
}