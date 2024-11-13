using E_Voting_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Voting_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddElection()
        {
            return View();
        }

        public IActionResult CastVote()
        {
            return View();
        }

        public IActionResult Profile() 
        {
            return View();
        }

        public IActionResult AddParty()
        {
            return View();
        }

        public IActionResult About()
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
