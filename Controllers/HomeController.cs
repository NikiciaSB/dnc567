using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DNC567.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace DNC567.Controllers
{
    public class HomeController : Controller
    {
        private DataContext dbContext;
        public HomeController(DataContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            ViewBag.Id = "banana";
            return View();
        }
        [HttpGet("loginreg")]
        public IActionResult LoginReg()
        {
            ViewBag.Id = "apple";
            return View();
        }
        public IActionResult RegisterStudent(User newUser)
        {
            ViewBag.Id = "apple";
            return View("EditStudent");
        }
        public IActionResult RegisterInstructor(User newUser)
        {
            ViewBag.Id = "apple";
            return View("EditStudent");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewBag.Id = "apple";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            ViewBag.Id = "apple";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
