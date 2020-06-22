using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BirthdayApp.Models;
using BirthdayApp.Repository;

namespace BirthdayApp.Controllers
{
    public class HomeController : Controller
    {
        private PeopleRepository PeopleRepository { get; set; }

        public HomeController(PeopleRepository peopleRepository)
        {
            this.PeopleRepository = peopleRepository;
        }

        public IActionResult Index(string? message)
        {
            var result = this.PeopleRepository.GetAll();
            ViewBag.Message = message;
            return View(result);
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
