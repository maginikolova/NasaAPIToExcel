using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NasaAPIToExcel.Services.Contracts;
using NasaAPIToExcel.Web.Models;
using System.Diagnostics;

namespace NasaAPIToExcel.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAsteroidsService asteroidService;

        public HomeController(ILogger<HomeController> logger, IAsteroidsService asteroidService)
        {
            _logger = logger;
            this.asteroidService = asteroidService;
        }

        public IActionResult Index()
        {
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
