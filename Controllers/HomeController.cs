using BookProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookRepository _repository;

        // We want the HomeController to receive the repository in addition to the logger
        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            //We will need to access these things in the project, so we want them to be public
            _logger = logger; // Assign private logger to public logger
            _repository = repository; // Assign private repository to public repository
        }

        public IActionResult Index()
        {
            return View(_repository.Books); // With the view, we will also pass the repository
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
